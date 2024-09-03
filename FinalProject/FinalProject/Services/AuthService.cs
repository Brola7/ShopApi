using FinalProject.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace FinalProject.Services
{
    public class AuthService : IAuthService
    {
        private readonly ProjectContext _context;

        public AuthService(ProjectContext context)
        {
            _context = context;
        }

        public async Task<User> Login(string username, string password)
        {
            var user = await _context.Users.Include(u => u.UserRoles).ThenInclude(ur => ur.Role).FirstOrDefaultAsync(x => x.UserName == username);
            if (user == null || !VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
            {
                return null;
            }
            return user;
        }

        public async Task<User> Register(User user, string password)
        {
            if (await UserExists(user.UserName))
            {
                return null;
            }

            byte[] passwordHash, passwordSalt;
            CreatePasswordHash(password, out passwordHash, out passwordSalt);

            user.PasswordHash = Convert.ToBase64String(passwordHash);
            user.PasswordSalt = Convert.ToBase64String(passwordSalt);

            // Find the "User" role
            var userRole = await _context.Roles.FirstOrDefaultAsync(r => r.Name == "User");
            if (userRole == null)
            {
                // Create the "User" role if it doesn't exist
                userRole = new Role { Name = "User" };
                await _context.Roles.AddAsync(userRole);
                await _context.SaveChangesAsync();
            }

            // Assign the "User" role to the new user
            user.UserRoles = new List<UserRole>
            {
                new UserRole { User = user, Role = userRole }
            };

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<bool> UserExists(string username)
        {
            return await _context.Users.AnyAsync(x => x.UserName == username);
        }

        private bool VerifyPasswordHash(string password, string storedPasswordHash, string passwordSalt)
        {
            byte[] salt = Convert.FromBase64String(passwordSalt);
            byte[] storedHash = Convert.FromBase64String(storedPasswordHash);

            using (var hmac = new HMACSHA512(salt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != storedHash[i])
                        return false;
                }
            }
            return true;
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        public async Task<User> ChangePass(string username, string oldPassword, string newPassword)
        {
            var user = await _context.Users.Include(u => u.UserRoles).ThenInclude(ur => ur.Role).FirstOrDefaultAsync(x => x.UserName == username);
            if (user == null || !VerifyPasswordHash(oldPassword, user.PasswordHash, user.PasswordSalt))
            {
                return null;
            }

            return await ChangeHelper(user, newPassword);
        }

        private async Task<User> ChangeHelper(User user, string newPassword)
        {
            byte[] passwordHash, passwordSalt;
            CreatePasswordHash(newPassword, out passwordHash, out passwordSalt);

            user.PasswordHash = Convert.ToBase64String(passwordHash);
            user.PasswordSalt = Convert.ToBase64String(passwordSalt);

            await _context.SaveChangesAsync();
            return user;
        }
    }
}
