using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace FinalProject.Filters
{
    public class RoleFilter : ActionFilterAttribute, IAsyncActionFilter
    {
        private readonly string _allowedRoles;

        public RoleFilter(string allowedRoles)
        {
            _allowedRoles = allowedRoles;
        }

        public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            var tokenKey = configuration.GetValue<string>("AppSettings:Token");

            if (context.HttpContext.Request.Headers.TryGetValue("Authorization", out var authorizationHeader))
            {
                var token = authorizationHeader.ToString().Replace("Bearer ", "");

                var tokenHandler = new JwtSecurityTokenHandler();
                var validationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(tokenKey)),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };

                try
                {
                    var principal = tokenHandler.ValidateToken(token, validationParameters, out var validatedToken);

                    var roles = principal.Claims
                        .Where(c => c.Type == ClaimTypes.Role)
                        .Select(c => c.Value.ToLower())
                        .ToArray();

                    var normalizedAllowedRoles = _allowedRoles.ToLower();
                    var filterRolesArray = normalizedAllowedRoles.Split(",");

                    if (!roles.Any(role => filterRolesArray.Contains(role)))
                    {
                        context.Result = new UnauthorizedResult();
                        return;
                    }
                }
                catch (SecurityTokenException)
                {
                    context.Result = new UnauthorizedResult();
                    return;
                }
            }
            else
            {
                context.Result = new UnauthorizedResult();
                return;
            }

            await next();
        }
    }
}
