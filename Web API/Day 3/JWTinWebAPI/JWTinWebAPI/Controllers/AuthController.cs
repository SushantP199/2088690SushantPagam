using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace JWTinWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [AllowAnonymous]
    public class AuthController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetToken()
        {
            AuthController authController = new AuthController();
            string token = authController.GenerateJSONWebToken(1, "user");

            return Ok(token);
        }

        private string GenerateJSONWebToken(int id, string role)
        {
            var key = new SymmetricSecurityKey(System.Text.Encoding.ASCII.GetBytes("this is my custom Secret key for authnetication"));

            var credential = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var claims = new List<Claim> { new Claim(ClaimTypes.Role, role), new Claim("userId", id.ToString()) };

            var token = new JwtSecurityToken(
                issuer:"SysAdm", 
                audience: "users", 
                claims: claims, 
                expires: DateTime.Now.AddMinutes(10), 
                signingCredentials: credential
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
