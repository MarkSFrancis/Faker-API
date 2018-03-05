using Microsoft.AspNetCore.Mvc;

namespace Faker_API.Areas.v1.Controllers
{
    [Route("v1/[controller]")]
    public class HomeController : Controller
    {
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Json(new
            {
                id,
                page = "Get",
                success = true
            });
        }
    }
}