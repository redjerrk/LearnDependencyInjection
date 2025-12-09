using LearnDependencyInjection.Services;
using Microsoft.AspNetCore.Mvc;

namespace LearnDependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        private readonly INumberService numberService1;
        private readonly INumberService numberService2;

        public HomeController(INumberService numberService1, INumberService numberService2)
        {
            this.numberService1 = numberService1;
            this.numberService2 = numberService2;
        }

        [HttpGet]
        [Route("number")]
        public IActionResult Get()
        {
            return Ok(new
            {
                number1 = numberService1.GetNumber(),
                number2 = numberService2.GetNumber()
            });
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
