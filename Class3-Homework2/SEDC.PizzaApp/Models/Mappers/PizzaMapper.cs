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
                Id = pizzaDb.Id,
                Name = pizzaDb.Name,
                Price = pizzaDb.HasExtras ? pizzaDb.Price + 10 : pizzaDb.Price,
                PizzaSize = pizzaDb.PizzaSize
            };
        }
    }
}
