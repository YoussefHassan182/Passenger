using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Passenger.Core.Entities;

namespace Passenger.Infrastructure.EntitiesConfig.TripEntityTypeConfig
{
    public class TripEntityTypeConfiguration : IEntityTypeConfiguration<Trip>
    {
        public void Configure(EntityTypeBuilder<Trip> builder)
        {
            builder.HasKey(_ => _.Id);
            builder.Property(_=>_.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Property(_ => _.Cost).IsRequired().HasPrecision(18, 2);
            builder.Property(_ => _.Name).IsRequired().HasMaxLength(100);
            builder.Property(_=>_.Description).IsRequired().HasMaxLength(200);
        }
    }
}
