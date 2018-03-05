using Bogus.DataSets;
using Faker_API.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Faker_API.Areas.v1.Controllers
{
    public class NameController : BaseApiController
    {
        public IActionResult FirstName(Name.Gender? gender = null) => 
            Result(Faker.Name.FirstName(gender));
        
        public IActionResult LastName(Name.Gender? gender = null) => 
            Result(Faker.Name.LastName(gender));
        
        public IActionResult FullName(Name.Gender? gender = null) => 
            Result(Faker.Name.FullName(gender));
        
        public IActionResult Prefix(Name.Gender? gender = null) => 
            Result(Faker.Name.Prefix(gender));
        
        public IActionResult Suffix() => 
            Result(Faker.Name.Suffix());
        
        public IActionResult FindName(string firstName = "", string lastName = "", bool? withPrefix = null, bool? withSuffix = null, Name.Gender? gender = null) => 
            Result(Faker.Name.FindName(firstName, lastName, withPrefix, withSuffix, gender));
        
        public IActionResult JobTitle() => 
            Result(Faker.Name.JobTitle());
        
        public IActionResult JobDescriptor() => 
            Result(Faker.Name.JobDescriptor());
        
        public IActionResult JobArea() => 
            Result(Faker.Name.JobArea());
        
        public IActionResult JobType() => 
            Result(Faker.Name.JobType());
    }
}