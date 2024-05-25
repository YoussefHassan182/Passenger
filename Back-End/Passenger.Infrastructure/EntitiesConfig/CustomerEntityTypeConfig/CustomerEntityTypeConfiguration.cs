using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Passenger.Core.Entities;

namespace Passenger.Infrastructure.EntitiesConfig.CustomerEntityTypeConfig
{
    public class CustomerEntityTypeConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable(nameof(Customer));
            builder.HasKey(a => a.Id);
            builder.Property(a=>a.Id).IsRequired().ValueGeneratedOnAdd();
        }
    }
}
