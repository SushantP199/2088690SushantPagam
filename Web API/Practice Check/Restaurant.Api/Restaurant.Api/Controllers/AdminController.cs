using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Api.Models;

namespace Restaurant.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IConfiguration configuration;

        public AdminController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        [HttpGet]
        [Authorize]
        public IEnumerable<MenuItem> Get()
        {
            string conn = configuration["ConnectionStrings.con"];

            List<MenuItem> menuItems = new List<MenuItem>();

            MenuItemOps menuItemOps = new MenuItemOps();

            menuItems = menuItemOps.GetMenuItemData(conn);

            return menuItems;
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] MenuItem menu)
        {

            string conn = configuration["ConnectionStrings.con"];

            MenuItemOps menuItemOps = new MenuItemOps();

            if (menuItemOps.UpdateMenu(conn, id, menu)) return Ok("Menu Item Updated!");

            return BadRequest("something went wrong !!!");
        }
    }
}
