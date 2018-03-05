using Faker_API.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Faker_API.Areas.v1.Controllers
{
    public class ImageController : BaseApiController
    {
        public IActionResult Image(int width = 640, int height = 480, bool randomize = false, bool https = false) =>
            Result(Faker.Image.Image(width, height, randomize, https));

        public IActionResult Abstract(int width = 640, int height = 480, bool randomize = false, bool https = false) =>
            Result(Faker.Image.Abstract(width, height, randomize, https));

        public IActionResult Animals(int width = 640, int height = 480, bool randomize = false, bool https = false) =>
            Result(Faker.Image.Animals(width, height, randomize, https));

        public IActionResult Business(int width = 640, int height = 480, bool randomize = false, bool https = false) =>
            Result(Faker.Image.Business(width, height, randomize, https));

        public IActionResult Cats(int width = 640, int height = 480, bool randomize = false, bool https = false) =>
            Result(Faker.Image.Cats(width, height, randomize, https));

        public IActionResult City(int width = 640, int height = 480, bool randomize = false, bool https = false) =>
            Result(Faker.Image.City(width, height, randomize, https));

        public IActionResult Food(int width = 640, int height = 480, bool randomize = false, bool https = false) =>
            Result(Faker.Image.Food(width, height, randomize, https));

        public IActionResult Nightlife(int width = 640, int height = 480, bool randomize = false, bool https = false) =>
            Result(Faker.Image.Nightlife(width, height, randomize, https));

        public IActionResult Fashion(int width = 640, int height = 480, bool randomize = false, bool https = false) =>
            Result(Faker.Image.Fashion(width, height, randomize, https));

        public IActionResult People(int width = 640, int height = 480, bool randomize = false, bool https = false) =>
            Result(Faker.Image.People(width, height, randomize, https));

        public IActionResult Nature(int width = 640, int height = 480, bool randomize = false, bool https = false) =>
            Result(Faker.Image.Nature(width, height, randomize, https));

        public IActionResult Sports(int width = 640, int height = 480, bool randomize = false, bool https = false) =>
            Result(Faker.Image.Sports(width, height, randomize, https));

        public IActionResult Technics(int width = 640, int height = 480, bool randomize = false, bool https = false) =>
            Result(Faker.Image.Technics(width, height, randomize, https));

        public IActionResult Transport(int width = 640, int height = 480, bool randomize = false, bool https = false) =>
            Result(Faker.Image.Transport(width, height, randomize, https));

        public IActionResult DataUri(int width, int height) =>
            Result(Faker.Image.DataUri(width, height));
    }
}