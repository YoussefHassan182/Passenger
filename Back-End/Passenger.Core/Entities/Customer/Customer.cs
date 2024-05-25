using Microsoft.AspNetCore.Identity;

namespace Passenger.Core.Entities
{
    public class Customer : IdentityUser
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string? Address { set; get; }
        public IList<Booking> Bookings { set; get; }

    }
}
