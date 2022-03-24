using Microsoft.AspNetCore.Mvc;
using Restaurant.Api.Models;

namespace Restaurant.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IConfiguration configuration;

        public CustomerController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        
        [HttpGet]
        public IEnumerable<MenuItem> Get()
        {
            string conn = configuration["ConnectionStrings.con"];

            List<MenuItem> menuItems = new List<MenuItem>();

            MenuItemOps menuItemOps = new MenuItemOps();

            menuItems = menuItemOps.GetMenuItemData(conn);

            return menuItems;
        }

        [HttpGet("{id}")]
        public IEnumerable<MenuItem> Get(int id)
        {
            string conn = configuration["ConnectionStrings.con"];

            List<MenuItem> menuItem = new List<MenuItem>();

            MenuItemOps menuItemOps = new MenuItemOps();

            menuItem = menuItemOps.GetMenuItemByID(conn, id);

            return menuItem;
        }

        [HttpPost]
        public void Post([FromBody] string value) { }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value) { }

        [HttpDelete("{id}")]
        public void Delete(int id) { }
    }
}
