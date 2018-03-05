using Bogus.DataSets;
using Faker_API.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Faker_API.Areas.v1.Controllers
{
    public class AddressController : BaseApiController
    {
        public IActionResult ZipCode(string format) => 
            Result(Faker.Address.ZipCode(format));

        public IActionResult City() => 
            Result(Faker.Address.City());

        public IActionResult StreetAddress(bool useFullAddress = false) =>
            Result(Faker.Address.StreetAddress(useFullAddress));

        public IActionResult CityPrefix() => 
            Result(Faker.Address.CityPrefix());

        public IActionResult CitySuffix() => 
            Result(Faker.Address.CitySuffix());

        public IActionResult StreetName() => 
            Result(Faker.Address.StreetName());

        public IActionResult SecondaryAddress() => 
            Result(Faker.Address.SecondaryAddress());

        public IActionResult County() => 
            Result(Faker.Address.County());

        public IActionResult Country() =>
            Result(Faker.Address.Country());

        public IActionResult FullAddress() =>
            Result(Faker.Address.FullAddress());

        public IActionResult CountryCode(Iso3166Format format) =>
            Result(Faker.Address.CountryCode(format));

        public IActionResult State() =>
            Result(Faker.Address.State());

        public IActionResult StateAbbr() =>
            Result(Faker.Address.StateAbbr());

        public IActionResult Latitude(double min = -90D, double max = 90D) =>
            Result(Faker.Address.Latitude(min, max));

        public IActionResult Longitude(double min = -180D, double max = 180D) =>
            Result(Faker.Address.Longitude(min, max));

        public IActionResult Direction(bool useAbbreviation = false) =>
            Result(Faker.Address.Direction(useAbbreviation));

        public IActionResult CardinalDirection(bool useAbbreviation = false) =>
            Result(Faker.Address.CardinalDirection(useAbbreviation));

        public IActionResult OrdinalDirection(bool useAbbreviation = false) =>
            Result(Faker.Address.OrdinalDirection(useAbbreviation));
    }
}