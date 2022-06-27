using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.Mappers;
using SEDC.PizzaApp.Models.ViewModels;

namespace SEDC.PizzaApp.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            List<Pizza> dbPizzas = StaticDb.Pizzas;

            List<PizzaViewModel> pizzaViewModels = dbPizzas.Select(x => PizzaMapper.ToPizzaViewModel(x)).ToList();

            return View(pizzaViewModels);
        }

        public IActionResult GetPizzas()
        {
            List<Pizza> dbPizzas = StaticDb.Pizzas;
            return View(dbPizzas);
        }

        public IActionResult Details(int? id)
        {
            if(id == null)
            {
                return RedirectToAction("Error");
            }

            Pizza pizza = StaticDb.Pizzas.FirstOrDefault(x => x.Id == id);
            if(pizza == null)
            {
                //return RedirectToAction("Error");
                return View("ResourceNotFound");
            }

            PizzaViewModel pizzaViewModel = PizzaMapper.ToPizzaViewModel(pizza);

            return View(pizzaViewModel);
        }

        public IActionResult Error()
        {
            return View();
        }

    }
}
