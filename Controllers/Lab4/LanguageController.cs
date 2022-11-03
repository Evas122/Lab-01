using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services.Lab4;

namespace WebApplication1.Controllers.Lab4
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class LanguageController : ControllerBase
    {
        [HttpGet]
        public string GetLang()
        {
            var lang = new Polish();
            return lang.getLang();
        }
    }
}
