namespace BurgerApp.Models.Model.Domain
{
    public class Order
    {
        public Order()
        {

        }
        public Order(int id, string firstName, string lastName, bool iseDelivered,
                                        string location, IEnumerable<Burger> burger)
        {
            if (firstName is null)
            {
                throw new ArgumentNullException(nameof(firstName));
            }
            if (lastName is null)
            {
                throw new ArgumentNullException(nameof(lastName));
            }
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            IsDelivered = iseDelivered;
            Location = location;
            Burgers = burger;
        }
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string FullName => $"{FirstName} {LastName}";
        public bool IsDelivered { get; set; } = false;
        public string Location { get; set; } = string.Empty;
        public IEnumerable<Burger> Burgers { get; set; } = new List<Burger>();

    }
}
