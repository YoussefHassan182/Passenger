using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Passenger.Infrastructure.Migrations
{
    public partial class intial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    ZipCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.ZipCode);
                    table.ForeignKey(
                        name: "FK_City_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Cus_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cus_Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Cus_Phone = table.Column<int>(type: "int", maxLength: 11, nullable: false),
                    Cus_Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Cus_Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityZipCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Cus_Id);
                    table.ForeignKey(
                        name: "FK_Customer_City_CityZipCode",
                        column: x => x.CityZipCode,
                        principalTable: "City",
                        principalColumn: "ZipCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Booking",
                columns: table => new
                {
                    Book_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Book_Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Book_Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Book_Date = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 5, 3, 9, 24, 54, 464, DateTimeKind.Local).AddTicks(6386)),
                    Book_Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Book_Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Book_Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Book_StartPoint = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Book_EndPoint = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Book_Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.Book_Id);
                    table.ForeignKey(
                        name: "FK_Booking_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "Cus_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    Pay_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pay_Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Pay_Date = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 5, 3, 9, 24, 54, 464, DateTimeKind.Local).AddTicks(7477)),
                    Pay_Type = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Pay_Currency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Pay_Id);
                    table.ForeignKey(
                        name: "FK_Payment_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "Cus_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Booking_CustomerID",
                table: "Booking",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_City_CountryId",
                table: "City",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_CityZipCode",
                table: "Customer",
                column: "CityZipCode");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_CustomerID",
                table: "Payment",
                column: "CustomerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Booking");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Country");
        }
    }
}
