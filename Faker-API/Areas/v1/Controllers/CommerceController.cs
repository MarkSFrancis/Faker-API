using Faker_API.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Faker_API.Areas.v1.Controllers
{
    public class CommerceController : BaseApiController
    {
        public IActionResult Department(int max = 3, bool returnMax = false) =>
            Result(Faker.Commerce.Department(max, returnMax));

        public IActionResult Price(decimal min = 1M, decimal max = 1000M, int decimals = 2, string symbol = "") =>
            Result(Faker.Commerce.Price(min, max, decimals, symbol));

        public IActionResult Categories(int num) =>
            Result(Faker.Commerce.Categories(num));

        public IActionResult ProductName() =>
            Result(Faker.Commerce.ProductName());

        public IActionResult Color() =>
            Result(Faker.Commerce.Color());

        public IActionResult Product() =>
            Result(Faker.Commerce.Product());

        public IActionResult ProductAdjective() =>
            Result(Faker.Commerce.ProductAdjective());

        public IActionResult ProductMaterial() =>
            Result(Faker.Commerce.ProductMaterial());
    }
}