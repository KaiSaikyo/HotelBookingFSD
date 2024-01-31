using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelBooking.Server.Migrations
{
    /// <inheritdoc />
    public partial class imgTest1db : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b6a0f6a-4a39-47a2-8623-81105dcc98fe", "AQAAAAIAAYagAAAAECmJ/dsX9VukY5RRCSNkg0u82BFlEw+FiOiztKFxGlDRKaFBJ4D2KikCUCBb2Kp9Aw==", "dd20cc51-738e-4f9a-a6d2-a8f6df15d8d0" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImagePath",
                value: "css/img/hotel/hilton_hotel.jpg");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImagePath",
                value: "css/img/hotel/fullerton_hotel.jpg");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImagePath",
                value: "css/img/hotel/st_81_hotel.jpg");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImagePath",
                value: "css/img/hotel/hard_rock_hotel.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b50aa21-6c93-4e58-a722-7727a6c66a92", "AQAAAAIAAYagAAAAEIzTg7TvKIiH7odeyzg0txEGEgqgKJy+T+HnukMMenKiS7KEys36/xtMxKBKgiedcw==", "efbe48bf-926a-417b-9452-cc7ff55f1dc6" });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImagePath",
                value: "hilton_hotel.jpg");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImagePath",
                value: "fullerton_hotel.jpg");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImagePath",
                value: "st_81_hotel.jpg");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImagePath",
                value: "hard_rock_hotel.jpg");
        }
    }
}
