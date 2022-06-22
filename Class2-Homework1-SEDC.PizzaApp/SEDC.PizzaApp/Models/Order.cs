namespace SEDC.PizzaApp.Models
{
    public class Order
    {
        public int _totalPrice = 0;
        public int Id { get; set; }
        public int UserId { get; set; }
        public List<int> PizzaIds { get; set; }
        public int GetTotalPrice()
        {
            return _totalPrice;
        }

        public List<Pizza> GetPizzas()
        {
            List<Pizza> pizzaList = new List<Pizza>();

            foreach(int pizzaId in PizzaIds)
            {
                Pizza pizza = StaticDb.Pizzas.FirstOrDefault(x => x.Id == pizzaId);

                _totalPrice += pizza.Price;

                pizzaList.Add(pizza);
            }

            return pizzaList;
        }

        public DateTime OrderDate = DateTime.Now;
    }
}
