using Faker_API.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Faker_API.Areas.v1.Controllers
{
    public class InternetController : BaseApiController
    {
        // TODO
        public IActionResult Avatar() =>
            Result(Faker.Internet.Avatar());

        public IActionResult Email(string firstName = null, string lastName = null, string provider = null) =>
            Result(Faker.Internet.Email(firstName, lastName, provider));

        public IActionResult ExampleEmail(string firstName = null, string lastName = null) =>
            Result(Faker.Internet.ExampleEmail(firstName, lastName));

        public IActionResult UserName(string firstName = null, string lastName = null) =>
            Result(Faker.Internet.UserName(firstName, lastName));

        public IActionResult DomainName() =>
            Result(Faker.Internet.DomainName());

        public IActionResult DomainWord() =>
            Result(Faker.Internet.DomainWord());

        public IActionResult DomainSuffix() =>
            Result(Faker.Internet.DomainSuffix());

        public IActionResult Ip() =>
            Result(Faker.Internet.Ip());

        public IActionResult Ipv6() =>
            Result(Faker.Internet.Ipv6());

        public IActionResult UserAgent() =>
            Result(Faker.Internet.UserAgent());

        public IActionResult Mac() =>
            Result(Faker.Internet.Mac());

        public IActionResult Password() =>
            Result(Faker.Internet.Password());

        public IActionResult Color() =>
            Result(Faker.Internet.Color());

        public IActionResult Protocol() =>
            Result(Faker.Internet.Protocol());

        public new IActionResult Url() =>
            Result(Faker.Internet.Url());

        public IActionResult UrlWithPath() =>
            Result(Faker.Internet.UrlWithPath());
    }
}