using Microsoft.EntityFrameworkCore;
using Passenger.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passenger.Infrastructure.Data
{
    public static class RelationShipMap
    {
        public static void MapRelationShips(this ModelBuilder builder)
        {
            builder.Entity<Booking>()
                    .HasOne(i => i.Customer)
                    .WithMany(i => i.Booking)
                    .HasForeignKey(i => i.CustomerID).IsRequired()
                    .IsRequired().OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Customer>()
                .HasKey(i => i.Cus_Id);

            builder.Entity<Payment>()
                .HasOne(i => i.Customer)
                .WithMany(i => i.Payment)
                .HasForeignKey(i => i.CustomerID)
                .IsRequired().OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Payment>()
                .HasOne(i => i.Customer)
                .WithMany(i => i.Payment)
                .HasForeignKey(i => i.CustomerID)
                .IsRequired().OnDelete(DeleteBehavior.Cascade);

            builder.Entity<City>().HasKey(i=>i.ZipCode); 

            builder.Entity<Country>()
                .HasKey(i=> i.Id);
            
                     




        }
    }
}
