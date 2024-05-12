namespace Passenger.Core.Entities
{
    public class Customer
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Address { set; get; }
        public string Phone { set; get; }
        public IList<Booking> Bookings { set; get; }

    }
}
