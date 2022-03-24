using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Restaurant.Api.Models;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;

namespace Restaurant.Api.Controllers
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

        public async Task<IActionResult> GetAsync(Login model)
        {
            Login login = new Login();
            login.Username = ("User1");
            login.Password = ("paswword1");
            login.Id = 1;

            string token = await GetTockenAsync(login);

            return Ok(new { jwt = token });
        }

        private async Task<string> GetTockenAsync(Login model)
        {
            AppUser appUser = await userManager.FindByNameAsync(model.Username);

            bool isValid = await userManager.CheckPasswordAsync(appUser, model.Password);

            string key = configuration["JwtSettings:Key"];
            string issuer = configuration["JwtSettings:Issuer"];
            string audience = configuration["JwtSettings:Audience"];
            int durationInMinutes = int.Parse(configuration["JwtSettings:DurationInMinutes"]);

            IList<Claim> userClaims = await userManager.GetClaimsAsync(appUser);
            userClaims.Add(new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()));
            userClaims.Add(new Claim(JwtRegisteredClaimNames.Sub, appUser.FullName));

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