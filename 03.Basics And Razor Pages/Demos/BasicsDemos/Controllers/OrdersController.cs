namespace BasicsDemos.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Linq;

    public class OrdersController : Controller
    {
        public IActionResult Details() {

            int id = int.Parse(Request.Path.Value.Split("/").Last());
            ViewData["Title"] = "Welcome to the Details Page !";
            return View(model: id);
        }                
    }
}
