using FiltersLesson.Filters;
using FiltersLesson.Models;
using FiltersLesson.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace FiltersLesson.Controllers
{
    public class SumController : Controller
    {

        private readonly SumProvider sumProvider;
        
        public SumController(
            SumProvider sumProvider)
        {
            this.sumProvider = sumProvider;
        }

        [HttpGet]
        [Route("/Sum")]  
        public IActionResult Index() {

            return View();
        }

        [HttpPost]
        [CensorNumber]
        [Route("/Sum")]
        public IActionResult Index(NumbersBindingModel model)
        {
            
            this.sumProvider.Sum = model.FirstNumber + model.SecondNumber;
            ViewData["result"] = this.sumProvider.Sum;
            return View();            
        }

        [HttpGet("Increment")]
        public IActionResult Increment() {

            this.sumProvider.Sum++;
            ViewData["result"] = this.sumProvider.Sum;
            return View("Index");
        }

        [HttpGet("Decrement")]
        public IActionResult Decrement()
        {
            this.sumProvider.Sum--;
            ViewData["result"] = this.sumProvider.Sum;
            return View("Index");
        }
    }
}
