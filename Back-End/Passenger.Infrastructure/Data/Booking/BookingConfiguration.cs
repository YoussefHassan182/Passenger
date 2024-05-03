using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passenger.Infrastructure.Data
{
    public class BookingConfiguration : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder.ToTable("Booking");
            builder.HasKey(i => i.Book_Id);

            builder.Property(i => i.Book_Id)
                .ValueGeneratedOnAdd();

            builder.Property(i => i.Book_Price)
                .IsRequired();

            builder.Property(i => i.Book_Discount)
                .IsRequired();

            builder.Property(i => i.Book_Title)
                .IsRequired();

            builder.Property(i => i.Book_Description)
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(i => i.Book_Date)
                .HasDefaultValue(DateTime.Now);

            builder.Property(i => i.Book_Type)
                .IsRequired();

            builder.Property(i => i.Book_StartPoint)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(i => i.Book_EndPoint)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(i => i.Book_Status)
                .IsRequired();

        }
    }
}
