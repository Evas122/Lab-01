using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using WebApplicationtest1.Models.Person;

namespace WebApplicationtest1.Controllers
{
    public class PersonController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public PersonController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            var model = new PersonViewModel()
            {
                Persons = new PersonViewModel().GetPersons()
            };
            return View(model);
        }

    }
}
