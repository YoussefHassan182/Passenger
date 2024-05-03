using Microsoft.EntityFrameworkCore;
using Passenger.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passenger.Infrastructure.Data
{
    public class MyContext :DbContext
    {
        //public MyContext(DbContextOptions options) : base (options){}

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Booking> Booking { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Country> Country { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new CustomerConfiguration().Configure(modelBuilder.Entity<Customer>());
            new BookingConfiguration().Configure(modelBuilder.Entity<Booking>());
            new PaymentConfiguration().Configure(modelBuilder.Entity<Payment>());
            new CityConfiguration().Configure(modelBuilder.Entity<City>());
            new CountryConfiguration().Configure(modelBuilder.Entity<Country>());


            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies()
                .UseSqlServer("Data Source=.; Initial Catalog= Booking_WebSite; Integrated Security=True;");
        }
    }
}
