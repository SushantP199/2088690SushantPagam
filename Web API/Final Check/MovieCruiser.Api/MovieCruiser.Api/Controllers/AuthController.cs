using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using MovieCruiser.Api.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MovieCruiser.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<AppUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IConfiguration configuration;

        public AuthController(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.configuration = configuration;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(Registration registration)
        {
            AppUser appUser = new AppUser
            {
                UserName = registration.UserName,
                Email = registration.Email,
                PhoneNumber = registration.PhoneNumber,

            };

            IdentityResult result = await userManager.CreateAsync(appUser, registration.Password);

            if (!result.Succeeded) return BadRequest(result.Errors);

            if (!await roleManager.RoleExistsAsync("Customers"))
                await roleManager.CreateAsync(new IdentityRole { Name = "Customers" });

            result = await userManager.AddToRoleAsync(appUser, "Customers");

            if (!result.Succeeded) return BadRequest(result.Errors);

            return Ok();
        }

        private async Task<string> GetTockenAsync(User model)
        {
            AppUser appUser = await userManager.FindByNameAsync(model.UserName);


            bool isValid = await userManager.CheckPasswordAsync(appUser, model.Password);


            string key = configuration["JwtSettings:Key"];
            string issuer = configuration["JwtSettings:Issuer"];
            string audience = configuration["JwtSettings:Audience"];
            int durationInMinutes = int.Parse(configuration["JwtSettings:DurationInMinutes"]);

            IList<Claim> userClaims = await userManager.GetClaimsAsync(appUser);
            userClaims.Add(new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()));
            userClaims.Add(new Claim(JwtRegisteredClaimNames.Sub, appUser.UserName));

            byte[] keyBytes = System.Text.Encoding.ASCII.GetBytes(key);
            SecurityKey securityKey = new SymmetricSecurityKey(keyBytes);
            SigningCredentials signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);


            JwtSecurityToken jwtSecurityToken = new JwtSecurityToken(
                issuer: issuer,
                audience: audience,
                expires: DateTime.Now.AddMinutes(durationInMinutes),
                signingCredentials: signingCredentials,
                claims: userClaims
                );
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            string token = tokenHandler.WriteToken(jwtSecurityToken);

            return token;
        }
    }
}
