using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Faker_API.Areas.v1.Controllers
{
    public class CommerceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}