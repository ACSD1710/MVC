namespace BurgerApp.Models.Model.Domain
{
    public class Burger
    {
        public Burger()
        {

        }

        public Burger(int id, string name, decimal price, bool hasFries, bool isVegetarian, bool isVegan)
        {
            if (name is null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            Id = id;
            Name = name;
            Price = price;
            HasFries = hasFries;
            IsVegetarian = isVegetarian;
            IsVegan = isVegan;
        }
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public bool IsVegetarian { get; set; }
        public bool IsVegan { get; set; }
        public bool HasFries { get; set; }

    }
}
