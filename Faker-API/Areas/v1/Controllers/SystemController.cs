using Faker_API.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Faker_API.Areas.v1.Controllers
{
    public class SystemController : BaseApiController
    {
        public IActionResult FileName(string ext = null) =>
            Result(Faker.System.FileName(ext));
        
        public IActionResult DirectoryPath() =>
            Result(Faker.System.DirectoryPath());
        
        public IActionResult FilePath() =>
            Result(Faker.System.FilePath());
        
        public IActionResult MimeType() =>
            Result(Faker.System.MimeType());
        
        public IActionResult CommonFileType() =>
            Result(Faker.System.CommonFileType());
        
        public IActionResult CommonFileExt() =>
            Result(Faker.System.CommonFileExt());
        
        public IActionResult FileType() =>
            Result(Faker.System.FileType());
        
        public IActionResult FileExt(string mimeType = null) =>
            Result(Faker.System.FileExt(mimeType));
        
        public IActionResult Semver() =>
            Result(Faker.System.Semver());
        
        public IActionResult Version() =>
            Result(Faker.System.Version());
        
        public IActionResult Exception() =>
            Result(Faker.System.Exception());
    }
}