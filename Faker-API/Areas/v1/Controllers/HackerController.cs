using Faker_API.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Faker_API.Areas.v1.Controllers
{
    public class HackerController : BaseApiController
    {
        public IActionResult Abbreviation() =>
            Result(Faker.Hacker.Abbreviation());

        public IActionResult Adjective() =>
            Result(Faker.Hacker.Adjective());

        public IActionResult Noun() =>
            Result(Faker.Hacker.Noun());

        public IActionResult Verb() =>
            Result(Faker.Hacker.Verb());

        public IActionResult IngVerb() =>
            Result(Faker.Hacker.IngVerb());

        public IActionResult Phrase() =>
            Result(Faker.Hacker.Phrase());
    }
}