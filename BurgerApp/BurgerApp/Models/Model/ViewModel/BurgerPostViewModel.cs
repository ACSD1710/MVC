namespace BroSBurgersApp.Models.Model.ViewModel
{
    public class BurgerPostViewModel
    {
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public bool IsVegetarian { get; set; }
        public bool IsVegan { get; set; }

    }
}
