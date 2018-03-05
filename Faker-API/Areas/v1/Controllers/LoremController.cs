using Faker_API.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Faker_API.Areas.v1.Controllers
{
    public class LoremController : BaseApiController
    {
        public IActionResult Word() =>
            Result(Faker.Lorem.Word());

        public IActionResult Words(int num = 3) =>
            Result(Faker.Lorem.Words(num));

        public IActionResult Letter(int num = 1) =>
            Result(Faker.Lorem.Letter(num));

        public IActionResult Sentence(int? wordCount = null, int? range = 0) =>
            Result(Faker.Lorem.Sentence(wordCount, range));

        public IActionResult Slug(int wordCount = 3) =>
            Result(Faker.Lorem.Slug(wordCount));

        public IActionResult Sentences(int? sentenceCount = null, string seperator = "\n") =>
            Result(Faker.Lorem.Sentences(sentenceCount, seperator));

        public IActionResult Paragraph(int min = 3) =>
            Result(Faker.Lorem.Paragraph(min));

        public IActionResult Paragraphs(int count = 3, int? min = null, int? max = null, string seperator = "\n\n")
        {
            if (min == null && max == null)
            {
                // Use count
                return Result(Faker.Lorem.Paragraphs(count, seperator));
            }

            if (min == null)
            {
                return StatusCode(404);
            }
            else if (max == null)
            {
                return StatusCode(404);
            }

            // Use min and max
            return Result(Faker.Lorem.Paragraphs(min.Value, max.Value, seperator));
        }

        public IActionResult Text() =>
            Result(Faker.Lorem.Text());

        public IActionResult Lines(int? lineCount = null, string seperator = "\n") =>
            Result(Faker.Lorem.Lines(lineCount, seperator));

    }
}