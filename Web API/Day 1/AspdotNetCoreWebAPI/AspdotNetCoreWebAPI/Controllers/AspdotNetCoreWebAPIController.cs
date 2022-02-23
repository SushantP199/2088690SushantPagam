using Microsoft.AspNetCore.Mvc;

namespace AspdotNetCoreWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AspdotNetCoreWebAPIController : Controller
    {

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("GET verb");
        }

        [HttpPost]
        public IActionResult Post()
        {
            return Ok("POST verb");
        }

        [HttpPatch]
        public IActionResult Put()
        {
            return Ok("PATCH verb");
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok("DELETE verb");
        }
    }
}
