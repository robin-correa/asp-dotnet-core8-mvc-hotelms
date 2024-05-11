using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelMS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedHotelsAndRoomCategoriesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "CreatedAt", "Email", "Name", "Phone", "UpdatedAt", "Website" },
                values: new object[] { 1, "21 Robin Street", new DateTime(2024, 5, 11, 4, 17, 54, 818, DateTimeKind.Utc).AddTicks(8934), "robin.correa21@gmail.com", "Default Hotel", "1121-1121-1121", new DateTime(2024, 5, 11, 4, 17, 54, 818, DateTimeKind.Utc).AddTicks(8936), "http://robincorrea.com" });

            migrationBuilder.InsertData(
                table: "RoomCategories",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "TotalAdult", "TotalCapacity", "TotalChild", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, null, "Standard room", "Standard", 2, 2, 1, null },
                    { 2, null, "Spacious and luxurious room", "Deluxe", 2, 2, 1, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
