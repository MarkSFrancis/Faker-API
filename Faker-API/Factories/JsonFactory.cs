using Microsoft.AspNetCore.Mvc;

namespace Faker_API.Factories
{
    public class JsonFactory
    {
        public JsonResult Result(string locale, object value)
        {
            return new JsonResult(new 
            {
                locale,
                value
            });
        }
    }
}
