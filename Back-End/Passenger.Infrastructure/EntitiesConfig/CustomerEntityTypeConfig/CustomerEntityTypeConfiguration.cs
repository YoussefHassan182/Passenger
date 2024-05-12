using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Passenger.Infrastructure.Data;

namespace Passenger.Infrastructure.EntitiesConfig.CustomerEntityTypeConfig
{
    public class CustomerEntityTypeConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(_ => _.Id);
            builder.Property(_=>_.Id).IsRequired().ValueGeneratedOnAdd();
        }
    }
}
