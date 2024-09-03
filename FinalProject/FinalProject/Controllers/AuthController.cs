using FinalProject.Entities;
using FinalProject.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using FinalProject.DTOs;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using FinalProject.Filters;

namespace FinalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private readonly IAuthService _authService;
        private readonly IConfiguration _config;
        private readonly ProjectContext _context;

        public AuthController(IAuthService authService, IConfiguration config, ProjectContext context)
        {
            _authService = authService;
            _config = config;
            _context = context;
        }
        [HttpPost("register")]
        public async Task<IActionResult> Register(UserDto user)
        {
            if (await _authService.UserExists(user.Username))
                return BadRequest("Username already exists");

            var role = _context.Roles.FirstOrDefault(x => x.Name == "User");

            if (role == null)
            {
                return BadRequest("The 'User' role does not exist.");
            }

            var userToCreate = new User
            {
                UserName = user.Username,
                Created = DateTime.Now,
                UserRoles = new List<UserRole> { new UserRole { RoleId = role.Id } }
            };

            var createdUser = await _authService.Register(userToCreate, user.Password);

            return Ok();
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(UserDto user)
        {
            var userFromRepo = await _authService.Login(user.Username, user.Password);

            if (userFromRepo == null)
                return Unauthorized();

            var roles = userFromRepo.UserRoles.Select(ur => ur.Role.Name).ToList();

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, userFromRepo.Id.ToString()),
                new Claim(ClaimTypes.Name, userFromRepo.UserName)
            };

            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config.GetSection("AppSettings:Token").Value));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddMinutes(20),
                SigningCredentials = creds
            };

            var tokenHandler = new JwtSecurityTokenHandler();

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return Ok(new
            {
                token = tokenHandler.WriteToken(token),
                userFromRepo
            });
        }


        [HttpPut("changepassword")]
        [Authorize]
        [RoleFilter("User,Admin")]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePassDto dto)
        {
            var user = await _authService.ChangePass(dto.Username, dto.OldPassword, dto.NewPassword);
            if (user == null)
            {
                return BadRequest("Password change failed");
            }
            return Ok(user);
        }
    }
}
