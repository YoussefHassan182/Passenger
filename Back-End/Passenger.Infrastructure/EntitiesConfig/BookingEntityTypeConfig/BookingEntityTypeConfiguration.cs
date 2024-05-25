using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Passenger.Core.Entities;

namespace Passenger.Infrastructure.EntitiesConfig.BookingEntityTypeConfig
{
    public class BookingEntityTypeConfiguration : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder.ToTable(nameof(Booking));
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Property(a => a.TripId).IsRequired();
            builder.Property(a=>a.CustomerId).IsRequired();
            builder.Property(a => a.PaymentAmount).IsRequired().HasPrecision(18, 2);

            builder.HasOne(a => a.Trip)
                .WithMany()
                .HasForeignKey(a => a.TripId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(a => a.Customer)
               .WithMany()
               .HasForeignKey(a => a.CustomerId)
               .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
