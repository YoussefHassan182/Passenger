namespace Passenger.Core.Entities
{
    public class Booking
    {
        public int Id { get; set; }
        public double PaymentAmount { set; get; }
        public DateTime Date { set; get; }
        public int CustomerId { set; get; }
        public Customer Customer { set; get; }
        public int TripId { set; get; }
        public Trip Trip { set; get; }
    }

}
