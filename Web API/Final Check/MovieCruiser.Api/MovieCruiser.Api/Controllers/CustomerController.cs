using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MovieCruiser.Api.Models;

namespace MovieCruiser.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly UserManager<AppUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IConfiguration configuration;

        public CustomerController(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.configuration = configuration;
        }

        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            string str = configuration["ConnectionStrings:con"];

            var date = DateTime.Now;

            return MovieOps.GetMoviesList(str).Where(p => p.Active == true && p.DateOfLaunch <= date);
        }

        [HttpGet("{userid}", Name = "Get Customer")]
        public object Get(int userid)
        {
            int movieCount = 0;

            List<Movie> list = new List<Movie>(MovieOps.FavoriteList(userid, ref movieCount));

            return new { list, movieCount };
        }

        [HttpPost]
        public IActionResult Post([FromBody] List<Favorite> favorites)
        {
            MovieOps.InsertIntoFavorites(favorites);

            return Ok();
        }

        [HttpDelete("{favId}")]
        public string Delete(int favId)
        {
            return MovieOps.Delete(favId);
        }
    }
}
