using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services.Lab3;

namespace WebApplication1.Controllers.Lab3
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ShapeController : ControllerBase
    {
        [HttpGet]
        public int GetArea()
        {
            var rectangle = new Rectangle(23, 23);
            return rectangle.GetArea();
        }
        public int GetSumArea()
        {
            var rectangle = new Rectangle(3, 3);
            var rectangle2 = new Rectangle(4, 4);
            return rectangle + rectangle2;
        }
    }
}
