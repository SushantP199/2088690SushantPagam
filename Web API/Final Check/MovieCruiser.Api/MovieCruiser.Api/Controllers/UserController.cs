using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MovieCruiser.Api.Models;

namespace MovieCruiser.Api.Controllers
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

        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            string conn = configuration["ConnectionStrings:con"];

            MovieOps movieOps = new MovieOps();

            List<Movie> movies = new List<Movie>();

            movies = (List<Movie>)MovieOps.GetMoviesList(conn);

            return movies;
        }
    }
}
