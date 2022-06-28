namespace BroSBurgersApp.Models.Model.ViewModel
{
    public class BurgerViewModel
    {
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public bool IsVegetarian { get; set; } = false;
        public bool IsVegan { get; set; } = false;
        public bool HasFries { get; set; } = false;

    }
}
