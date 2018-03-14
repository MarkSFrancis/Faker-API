using Faker_API.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Faker_API.Areas.v1.Controllers
{
    public class RantController : BaseApiController
    {
        public IActionResult Review(string product = "product") =>
            Result(Faker.Rant.Review(product));
        
        public IActionResult Reviews(string product = "product", int lines = 2) =>
            Result(Faker.Rant.Reviews(product, lines));
    }
}