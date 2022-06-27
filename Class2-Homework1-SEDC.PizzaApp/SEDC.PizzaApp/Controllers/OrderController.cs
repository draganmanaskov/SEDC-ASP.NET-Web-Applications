using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Models;

namespace SEDC.PizzaApp.Controllers
{
    public class OrderController : Controller
    {
        //http://localhost:[port]/ListOrders
        [Route("ListOrders")]
        public IActionResult Index()
        {
            return View();
        }

        //http://localhost:[port]/Order/Details/{id?}
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return new EmptyResult();
            }

            Order order = StaticDb.Orders.FirstOrDefault(x => x.Id == id);
            if (order == null)
            {
                return RedirectToAction("Error");
            }

            return View(order);
        }

        //http://localhost:[port]/Order/JsonData
        public IActionResult JsonData()
        {
            Example jsonDataExample = new Example()
            {
                Id = 1,
                UserId = 23,
                PizzaId = 2,
            };

            return new JsonResult(jsonDataExample);
        }

        public IActionResult Redirect()
        {
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Error()
        {
            return View();
        }

    }
}
