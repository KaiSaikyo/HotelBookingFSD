using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelBooking.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "fabfd4ba-1668-4ae2-9482-5c8d17fc7b99", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEMZjpySsgx/35QeMkPU6nmtx+cy3aUmyWTgLIqonytxA+B5vzpJO0BQ/EA5kGZ06Ew==", null, false, "04219bda-91c2-46b8-9f44-a35292b0a74e", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "Amenities", "Availability", "Description", "Name", "Rating" },
                values: new object[,]
                {
                    { 1, "333 Orchard Rd, Mandarin Orchard Singapore", "Breakfast, Wifi, Gym", true, "Hilton Hotels & Resorts is a global brand of full-service hotels and resorts.", "Hilton Hotel", 3.5m },
                    { 2, "1 Fullerton Square, Singapore 049178", "Breakfast, Gym, Laundry", true, "The Fullerton Hotel Singapore offers 5-star luxury rooms & suites with exceptional services.", "Fullerton Hotel", 5m },
                    { 3, "768 Upper Serangoon Rd, Singapore 534636", "Game Center, Swimming Pool, Wifi", false, "Your go-to hotel for awesome rates, comfortable rooms, and accessible locations.", "St 81 Hotel", 3m },
                    { 4, "Desaru Coast, Jln Pantai 3, 81930, Johor, Malaysia", "Breakfast, Wifi, Gym", true, "Your ultimate destination getaway at the leading entertainment hotel in Desaru Coast, Johor, Malaysia.", "Hard Rock Hotel", 2.5m }
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "Email", "Mobile", "Name", "Password" },
                values: new object[,]
                {
                    { 1, "T.amos@gmail.com", "98765432", "AMOS TAN", "AT123" },
                    { 2, "JBman@hotmail.com", "87654321", "JACK BRYAN", "JBpassword" },
                    { 3, "LSING@hotmail.com", "65432109", "LIM HSING", "passwordLH" },
                    { 4, "TZXiang@gmail.com", "12345678", "TAY ZI XIANG", "TZXTZX" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "Id", "Description", "HotelId", "Price", "Size" },
                values: new object[,]
                {
                    { 1, "The Twin Room", 1, 2404m, "25 sqm" },
                    { 2, "Deluxe Twin Room", 1, 2324m, "20 sqm" },
                    { 3, "Single Office Room", 2, 1531m, "15 sqm" },
                    { 4, "Single Room", 4, 592.5m, "5 sqm" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Staffs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
