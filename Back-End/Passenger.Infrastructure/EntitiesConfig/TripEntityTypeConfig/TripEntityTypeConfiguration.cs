using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Passenger.Core.Entities;

namespace Passenger.Infrastructure.EntitiesConfig.TripEntityTypeConfig
{
    public class TripEntityTypeConfiguration : IEntityTypeConfiguration<Trip>
    {
        public void Configure(EntityTypeBuilder<Trip> builder)
        {
            builder.ToTable(nameof(Trip));
            builder.HasKey(a => a.Id);
            builder.Property(a=>a.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Property(a => a.Cost).IsRequired().HasPrecision(18, 2);
            builder.Property(a => a.Name).IsRequired().HasMaxLength(100);
            builder.Property(a=>a.Description).IsRequired().HasMaxLength(200);
        }
    }
}
