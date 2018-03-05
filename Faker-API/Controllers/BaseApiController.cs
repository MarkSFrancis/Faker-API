using Bogus;
using Faker_API.Factories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Faker_API.Controllers
{
    public class BaseApiController : Controller
    {
        public BaseApiController()
        {
            JsonFactory = new JsonFactory();
        }

        protected JsonFactory JsonFactory { get; }
        protected Faker Faker { get; private set; }
        protected string Locale { get; private set; }

        protected JsonResult Result(object value)
        {
            return JsonFactory.Result(Locale, value);
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Locale = (string) context.RouteData.Values["locale"];
            Faker = new Faker(Locale);
        }
    }
}