using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.ViewModels;

namespace SEDC.PizzaApp.Models.Mappers
{
    public static class UserMapper
    {
        public static UserViewModel ToUserViewModel(User userDb)
        {
            return new UserViewModel
            {
                FullName = $"{userDb.FirstName} {userDb.LastName}"
            };
        }
    }
}
