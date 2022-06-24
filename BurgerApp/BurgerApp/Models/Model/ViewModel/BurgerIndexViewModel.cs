using BurgerApp.Models.Model.Domain;

namespace BroSBurgersApp.Models.Model.ViewModel
{
    public class BurgerIndexViewModel
    {
        public IEnumerable<Burger> Burgers { get; set; } = new List<Burger>();
    }
}
