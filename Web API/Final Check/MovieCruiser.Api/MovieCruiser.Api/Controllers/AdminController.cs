using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MovieCruiser.Api.Models;

namespace MovieCruiser.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly UserManager<AppUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IConfiguration configuration;

        public AdminController(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.configuration = configuration;
        }

        [HttpGet]
        [Authorize]
        public IEnumerable<Movie> Get()
        {
            string conn = configuration["ConnectionStrings.con"];

            List<Movie> menuItems = new List<Movie>();

            MovieOps movieItemOps= new MovieOps();

            menuItems = (List<Movie>)MovieOps.GetMoviesList(conn);

            return menuItems;
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Movie movie)
        {
            string con = configuration["ConnectionStrings.con"];

            if (MovieOps.Update(id, movie)) return Ok("Data Updated");

            return BadRequest("Something Went Wrong");
        }
    }
}