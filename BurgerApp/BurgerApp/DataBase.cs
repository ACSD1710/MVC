using BurgerApp.Models.Model.Domain;

namespace BurgerApp
{
    public static class DataBase
    {
        public static IList<Burger> BurgersBase = new List<Burger>
        {
            new Burger(0, "BasicBro", 140, true, false, false),
            new Burger(1, "Don't be, a Chicken Bro", 150, true, false, false),
            new Burger(2, "Vege Bro", 200, true, true, false),
            new Burger(3, "Angry Bro", 170, true, false, false),
            new Burger(4, "Smash Bro", 210, false, false, false),
        };
    }
}
