using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Passenger.Infrastructure.Data;
namespace Passenger.Infrastructure.EntitiesConfig.BookingEntityTypeConfig
{
    public class BookingEntityTypeConfiguration : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder.HasKey(_ => _.Id);
            builder.Property(_ => _.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Property(_ => _.TripId).IsRequired();
            builder.Property(_=>_.CustomerId).IsRequired();
            builder.Property(_ => _.PaymentAmount).IsRequired().HasPrecision(18, 2);

            builder.HasOne(_ => _.Trip)
                .WithMany()
                .HasForeignKey(_ => _.TripId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(_ => _.Customer)
               .WithMany()
               .HasForeignKey(_ => _.CustomerId)
               .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
