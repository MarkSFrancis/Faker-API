using Faker_API.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Faker_API.Areas.v1.Controllers
{
    public class PhoneNumbersController : BaseApiController
    {
        public IActionResult PhoneNumber(string format = null) =>
            Result(Faker.Phone.PhoneNumber(format));
        
        public IActionResult PhoneNumberFormat(int phoneFormatsArrayIndex = 0) =>
            Result(Faker.Phone.PhoneNumberFormat(phoneFormatsArrayIndex));
    }
}