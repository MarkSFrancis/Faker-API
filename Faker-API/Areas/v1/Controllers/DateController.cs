using System;
using System.Diagnostics.Contracts;
using Faker_API.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Faker_API.Areas.v1.Controllers
{
    public class DateController : BaseApiController
    {
        public IActionResult Past(int yearsToGoBack = 1, DateTime? refDate = null) =>
            Result(Faker.Date.Past(yearsToGoBack, refDate));

        public IActionResult Soon(int days = 1) =>
            Result(Faker.Date.Soon(days));

        public IActionResult Future(int yearsToGoForward = 1, DateTime? refDate = null) =>
            Result(Faker.Date.Future(yearsToGoForward, refDate));

        public IActionResult Between(DateTime start, DateTime end) =>
            Result(Faker.Date.Between(start, end));

        public IActionResult Recent(int days = 1) =>
            Result(Faker.Date.Recent(days));

        public IActionResult Timespan(TimeSpan? maxSpan = null) =>
            Result(Faker.Date.Timespan(maxSpan));

        public IActionResult Month(bool abbrivation = false, bool abbreviation = false, bool useContext = false) =>
            Result(Faker.Date.Month(abbrivation || abbreviation, useContext));

        public IActionResult Weekday(bool abbrivation = false, bool abbreviation = false, bool useContext = false) =>
            Result(Faker.Date.Weekday(abbrivation || abbreviation, useContext));
    }
}