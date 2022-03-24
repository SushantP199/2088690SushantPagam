using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Api.Models;

namespace Restaurant.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserManager<AppUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IConfiguration configuration;

        public UserController(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.configuration = configuration;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(Login model)
        {
            AppUser appUser = await userManager.FindByNameAsync(model.Username);

            if (appUser == null) return BadRequest("Invalid username/password");

            bool isValid = await userManager.CheckPasswordAsync(appUser, model.Password);

            if (!isValid) return BadRequest("Invalid username/password");

            return Ok(isValid);
        }

        [HttpPost("signup")]
        public async Task<IActionResult> Register(User model)
        {
            AppUser appUser = new AppUser
            {
                UserName = model.Username,
                Email = model.Email,
                PhoneNumber = model.PhoneNumber,
                FullName = model.FullName,
                Age = model.Age
            };

            IdentityResult result = await userManager.CreateAsync(appUser, model.Password);

            if (!result.Succeeded) return BadRequest(result.Errors);

            if (!await roleManager.RoleExistsAsync("Customers"))
                await roleManager.CreateAsync(new IdentityRole { Name = "Customers" });

            result = await userManager.AddToRoleAsync(appUser, "Customers");

            if (!result.Succeeded) return BadRequest(result.Errors);

            return Ok();
        }
    }
}
