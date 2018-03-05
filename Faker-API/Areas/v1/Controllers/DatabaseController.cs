using Faker_API.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Faker_API.Areas.v1.Controllers
{
    public class DatabaseController : BaseApiController
    {
        public IActionResult Column() =>
            Result(Faker.Database.Column());

        public IActionResult Type() =>
            Result(Faker.Database.Type());

        public IActionResult Collation() =>
            Result(Faker.Database.Collation());

        public IActionResult Engine() =>
            Result(Faker.Database.Engine());
    }
}