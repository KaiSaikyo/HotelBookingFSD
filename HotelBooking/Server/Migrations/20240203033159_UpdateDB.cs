using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelBooking.Server.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56295c77-ae21-4d1a-bfb0-c359e0de3a06", "AQAAAAIAAYagAAAAEPD1LVXRT0JN/70md/VHvZoiiRSuoOfEMYAMQ9b56pUxJNWzv0jdt4iAH/a2jYBPgQ==", "f5ff66cf-af0b-4611-933c-81f272de22b0" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImagePath",
                value: "css/img/hotel/81_Hotel.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b313af4-905c-4792-bff1-7f315522a594", "AQAAAAIAAYagAAAAEP0dxC/m0iM2F+BSqp83KNI8OJLY9QDVlgB9XtXM+uJHarG/v23Dl4QLIfFlN/e3/w==", "541d7218-f000-4cc1-bb87-41fe0b084329" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImagePath",
                value: "css/img/hotel/st_81_hotel.jpg");
        }
    }
}
