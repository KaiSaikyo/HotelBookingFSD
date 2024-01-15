using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelBooking.Server.Migrations
{
    /// <inheritdoc />
    public partial class NewNewDataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04302cfb-0702-45dd-a16b-a1d0cbb6329f", "AQAAAAIAAYagAAAAEDfZ01U/jK0ubCOX/WeKWRbRn3aNfg5s1Kx9cjhmPr2CsV8lu9u2q+A4gjBgQBwlRQ==", "f1934db6-e507-4c28-8e33-e25952fe75e8" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                column: "RoomTypeId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                column: "RoomTypeId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                column: "RoomTypeId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                column: "RoomTypeId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "StayId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "StayId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "StayId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "StayId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Stays",
                keyColumn: "Id",
                keyValue: 1,
                column: "RoomId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Stays",
                keyColumn: "Id",
                keyValue: 2,
                column: "RoomId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Stays",
                keyColumn: "Id",
                keyValue: 3,
                column: "RoomId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Stays",
                keyColumn: "Id",
                keyValue: 4,
                column: "RoomId",
                value: 4);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9bcaa501-e36b-453f-8750-9214cd431bbf", "AQAAAAIAAYagAAAAEPHEuSP1hQPqtC7AMRPyGesCoSyXl9pUldoW9bBKZfXbFOFbt2gv1TrsdAcSt8W3Ug==", "5906ba08-db78-401f-931e-207358c7d50c" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                column: "RoomTypeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                column: "RoomTypeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3,
                column: "RoomTypeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4,
                column: "RoomTypeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "StayId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "StayId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "StayId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "StayId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stays",
                keyColumn: "Id",
                keyValue: 1,
                column: "RoomId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stays",
                keyColumn: "Id",
                keyValue: 2,
                column: "RoomId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stays",
                keyColumn: "Id",
                keyValue: 3,
                column: "RoomId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Stays",
                keyColumn: "Id",
                keyValue: 4,
                column: "RoomId",
                value: null);
        }
    }
}
