using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.ViewModels;
using SEDC.PizzaApp.Models.Mappers;

namespace SEDC.PizzaApp.Controllers
{
    public class PizzaController : Controller
    {

        public IActionResult Index()
        {
            List<Pizza> pizzaDb = StaticDb.Pizzas;

            List<PizzaViewModel> pizzaViewModels = pizzaDb.Select(x => PizzaMapper.ToPizzaViewModel(x)).ToList();

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
                return new EmptyResult();
            }

            Pizza pizza = StaticDb.Pizzas.FirstOrDefault(x => x.Id == id);

            if(pizza == null)
            {
                return new EmptyResult();
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
