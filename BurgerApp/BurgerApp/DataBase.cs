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

        public static int CreateBurger(Burger burger)
        {
            var burgerId = BurgersBase.OrderBy(x => x.Id).LastOrDefault()?.Id ?? 0;
            burger.Id = ++burgerId;
            BurgersBase.Add(burger);
            return burgerId;
        }
        public static void EditBurger(Burger model)
        {
            int burgerIndex = 0;
            foreach (var burger in BurgersBase)
            {
                if (burger.Id == model.Id)
                {
                    break;
                }
                burgerIndex++;
            }
            if (BurgersBase[burgerIndex] is not null)
            {
                BurgersBase[burgerIndex] = model;
            }

        }
        public static void RemoveBurger(int id)
        {
            /*int burgerIndex = 0;
            foreach (var burger in BurgersBase)
            {
                if (burger.Id == id)
                {
                    break;
                };
                burgerIndex++;
            }
            BurgersBase.RemoveAt(burgerIndex);*/
            var model = BurgersBase.SingleOrDefault(x => x.Id == id);
            if (model is not null)
            {
                RemoveBurgerModel(model);
            }
        }
        public static void RemoveBurgerModel(Burger model)
        {
            BurgersBase.Remove(model);
        }

    }
}
