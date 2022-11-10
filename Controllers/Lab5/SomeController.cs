using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services.Lab5;

namespace WebApplication1.Controllers.Lab5
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class SomeController : ControllerBase
    {
        [HttpGet]
        public string CallMethod()
        {
            var someInstance = new SomeClass();
            return someInstance.Print(null);
        }
    }
}
