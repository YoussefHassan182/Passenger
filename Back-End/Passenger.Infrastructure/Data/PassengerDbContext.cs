using Microsoft.EntityFrameworkCore;
using Passenger.Core.Entities;
using Passenger.Infrastructure.EntitiesConfig.BookingEntityTypeConfig;
using Passenger.Infrastructure.EntitiesConfig.CustomerEntityTypeConfig;
using Passenger.Infrastructure.EntitiesConfig.TripEntityTypeConfig;

namespace Passenger.Infrastructure.Data
{
    public class PassengerDbContext : DbContext
    {
        public PassengerDbContext(DbContextOptions<PassengerDbContext> options) : base(options)
        {
        }
        public DbSet<Trip> Trips { set; get; }
        public DbSet<Booking> Bookings { set; get; }
        public DbSet<Customer> Customers { set; get; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new TripEntityTypeConfiguration());
            builder.ApplyConfiguration(new CustomerEntityTypeConfiguration());
            builder.ApplyConfiguration(new BookingEntityTypeConfiguration());

            base.OnModelCreating(builder);
        }
    }
}
