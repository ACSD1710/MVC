using BroSBurgersApp.Models.Model.ViewModel;
using BurgerApp.Models.Model.Domain;

namespace BroSBurgersApp.Models.Model.Mapper
{
    public static class BurgerMapper
    {
        public static Burger CreateBurger(BurgerViewModel model)
        {
            //return new Burger(0, model.Name, model.Price, model.HasFries, model., false);
            return new Burger
            {
                HasFries = model.HasFries,
                IsVegan = model.IsVegan,
                IsVegetarian = model.IsVegetarian,
                Name = model.Name,
                Price = model.Price,
            };
        }
    }
}
