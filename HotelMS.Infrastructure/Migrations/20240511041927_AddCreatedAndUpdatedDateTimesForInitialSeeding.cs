using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelMS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddCreatedAndUpdatedDateTimesForInitialSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 11, 4, 19, 27, 134, DateTimeKind.Utc).AddTicks(4779), new DateTime(2024, 5, 11, 4, 19, 27, 134, DateTimeKind.Utc).AddTicks(4786) });

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 11, 4, 19, 27, 134, DateTimeKind.Utc).AddTicks(4924), new DateTime(2024, 5, 11, 4, 19, 27, 134, DateTimeKind.Utc).AddTicks(4926) });

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 11, 4, 19, 27, 134, DateTimeKind.Utc).AddTicks(4928), new DateTime(2024, 5, 11, 4, 19, 27, 134, DateTimeKind.Utc).AddTicks(4929) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 11, 4, 17, 54, 818, DateTimeKind.Utc).AddTicks(8934), new DateTime(2024, 5, 11, 4, 17, 54, 818, DateTimeKind.Utc).AddTicks(8936) });

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "RoomCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { null, null });
        }
    }
}
