namespace Passenger.Infrastructure.Data
{
    public class Trip
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { set; get; }
        public int Duration { set; get; }
        public double Cost { set; get; }
        public IList<Booking> Bookings { set; get; }
    }
}
