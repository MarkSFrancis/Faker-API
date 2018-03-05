using Faker_API.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Faker_API.Areas.v1.Controllers
{
    public class CompanyController : BaseApiController
    {
        public IActionResult CompanySuffix() =>
            Result(Faker.Company.CompanySuffix());

        public IActionResult CompanyName(string format = null, int? formatIndex = null)
        {
            if (format != null)
            {
                return Result(Faker.Company.CompanyName(format));
            }

            return Result(Faker.Company.CompanyName(formatIndex));
        }

        public IActionResult CatchPhrase() =>
            Result(Faker.Company.CatchPhrase());

        public IActionResult Bs() =>
            Result(Faker.Company.Bs());
    }
}