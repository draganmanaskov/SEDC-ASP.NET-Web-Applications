using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.ViewModels;

namespace SEDC.PizzaApp.Models.Mappers
{
    public static class PizzaMapper
    {
        public static PizzaViewModel ToPizzaViewModel(Pizza pizzaDb)
        {
            return new PizzaViewModel
            {
                PizzaName = pizzaDb.Name,
                Price = pizzaDb.Price,
                IsOnPromotion = pizzaDb.IsOnPromotion
            };
        }
    }
}
