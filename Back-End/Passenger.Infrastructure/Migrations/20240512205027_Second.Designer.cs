﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Passenger.Infrastructure.Data;

#nullable disable

namespace Passenger.Infrastructure.Migrations
{
    [DbContext(typeof(PassengerDbContext))]
    [Migration("20240512205027_Second")]
    partial class Second
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Passenger.Core.Entities.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int?>("CustomerId1")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<double>("PaymentAmount")
                        .HasPrecision(18, 2)
                        .HasColumnType("float(18)");

                    b.Property<int>("TripId")
                        .HasColumnType("int");

                    b.Property<int?>("TripId1")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("CustomerId1");

                    b.HasIndex("TripId");

                    b.HasIndex("TripId1");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("Passenger.Core.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Passenger.Core.Entities.Trip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("Cost")
                        .HasPrecision(18, 2)
                        .HasColumnType("float(18)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Trips");
                });

            modelBuilder.Entity("Passenger.Core.Entities.Booking", b =>
                {
                    b.HasOne("Passenger.Core.Entities.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .IsRequired();

                    b.HasOne("Passenger.Core.Entities.Customer", null)
                        .WithMany("Bookings")
                        .HasForeignKey("CustomerId1");

                    b.HasOne("Passenger.Core.Entities.Trip", "Trip")
                        .WithMany()
                        .HasForeignKey("TripId")
                        .IsRequired();

                    b.HasOne("Passenger.Core.Entities.Trip", null)
                        .WithMany("Bookings")
                        .HasForeignKey("TripId1");

                    b.Navigation("Customer");

                    b.Navigation("Trip");
                });

            modelBuilder.Entity("Passenger.Core.Entities.Customer", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("Passenger.Core.Entities.Trip", b =>
                {
                    b.Navigation("Bookings");
                });
#pragma warning restore 612, 618
        }
    }
}
