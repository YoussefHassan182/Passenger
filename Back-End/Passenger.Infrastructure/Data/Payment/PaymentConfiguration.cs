using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passenger.Infrastructure.Data
{
    public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.ToTable("Payment");
            builder.HasKey(i => i.Pay_Id);

            builder.Property(i => i.Pay_Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder.Property(i => i.Pay_Type)
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(i => i.Pay_Amount)
                .IsRequired();

            builder.Property(i => i.Pay_Currency)
                .IsRequired();

            builder.Property(i => i.Pay_Date)
                .HasDefaultValue( DateTime.Now);

            builder.Property (i => i.CustomerID).IsRequired();









        }
    }
}
