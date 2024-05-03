using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passenger.Infrastructure.Data
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customer");
            builder.HasKey(i => i.Cus_Id);
            
            builder.Property(i=>i.Cus_Id)
                    .ValueGeneratedOnAdd()
                    .IsRequired();
            
            builder.Property(i => i.Cus_Name)
                .IsRequired().HasMaxLength(150);
            
            builder.Property(i => i.Cus_Email)
                    .IsRequired()
                    .HasMaxLength(50);
            
            builder.Property(i => i.Cus_Phone)
                .IsRequired()
                .HasMaxLength(11);
            
            builder.Property(i => i.Cus_Password)
                .IsRequired();

            builder.Property(i => i.CityZipCode).IsRequired();







        }
    }
}
