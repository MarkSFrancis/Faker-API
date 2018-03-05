using Faker_API.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Faker_API.Areas.v1.Controllers
{
    public class HelpersController : BaseApiController
    {
        public IActionResult Replace(string format) =>
            Result(new Bogus.Randomizer().Replace(format));

        public IActionResult Handlebars(string format) =>
            Result(Faker.Parse(format));
    }
}