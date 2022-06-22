namespace SEDC.PizzaApp.Models
{
    public class Example
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PizzaId { get; set; }

        public DateTime OrderDate = DateTime.Now;
    }
}
