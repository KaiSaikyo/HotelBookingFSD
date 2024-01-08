using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelBooking.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9186f4b7-c05b-415a-a4e2-f45f649182f0", "AQAAAAIAAYagAAAAEHpdWKeysJN1ytvMRCastGBIHNodJjZd/mZouAeInvx6ogKQBh0mqIZ1J2XeOzAo+g==", "a933c9cd-c1af-417c-bcbe-fa518b0ebcb4" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CardNumber", "Cvv", "Email", "ExpiryDate", "Mobile", "Name", "Password", "PaymentType" },
                values: new object[,]
                {
                    { 1, "1234567812345678", "123", "sara.jones@example.com", new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "87654321", "SARA JONES", "sara123", "CreditCard" },
                    { 2, "9876543210987654", "456", "mike.smith@example.com", new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "98765432", "MIKE SMITH", "mikepass", "DebitCard" },
                    { 3, "8765123412345678", "789", "jason.lee@example.com", new DateTime(2026, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "87651234", "JASON LEE", "jasonPass", "CreditCard" },
                    { 4, "9876234512345678", "567", "emily.tan@example.com", new DateTime(2028, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "98762345", "EMILY TAN", "emilyPwd", "DebitCard" }
                });

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
                table: "Bookings",
                columns: new[] { "Id", "CheckInDate", "CheckOutDate", "CustomerId", "Destination", "HotelId", "NumGuest", "StaffId", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "City A", 1, 2, 1, true },
                    { 2, new DateTime(2023, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "City B", 2, 1, 2, true },
                    { 3, new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "City C", 3, 3, 3, false },
                    { 4, new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "City D", 4, 2, 4, true }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CustomerId", "Date", "Description", "Rating" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enjoyed the stay, great service!", 4.5m },
                    { 2, 2, new DateTime(2023, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Decent stay, room was comfortable", 3.0m },
                    { 3, 3, new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Outstanding experience, highly recommended!", 5.0m },
                    { 4, 4, new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Average stay, room cleanliness could be improved", 2.5m }
                });

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

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Amenities", "Number", "RoomMaxStay", "RoomMinStay", "RoomTypeId" },
                values: new object[,]
                {
                    { 1, "2 King Beds", "704A", 5, 3, 1 },
                    { 2, "1 King Bed, 1 Office Room", "680B", 3, 2, 2 },
                    { 3, "2 Single Beds", "530F", 5, 4, 3 },
                    { 4, "1 Single Bed, 1 Fax Machine", "745C", 3, 1, 4 }
                });

            migrationBuilder.InsertData(
                table: "Stays",
                columns: new[] { "Id", "BookingId", "ComplimentaryServices", "EmergencyContact", "OccupancyStatus" },
                values: new object[,]
                {
                    { 1, 1, "Wi-Fi, Breakfast", "12345678", true },
                    { 2, 2, "Pool Access, Newspaper", "87654321", false },
                    { 3, 3, "Gym Access, Parking", "55558888", true },
                    { 4, 4, "Airport Shuttle", "33332222", false }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Stays",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Stays",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Stays",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Stays",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 4);

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
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4);

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
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hotels",
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "212a0327-6189-4d5c-b34c-1293a248bcb5", "AQAAAAIAAYagAAAAENhw5ml+yjkRC+a/2Y9Y+WL32vRxm3A7YBjOTq8hIJZVZ2FjAtQ6j4ThaSEFLIHbpA==", "af4266db-cd2d-43ae-a6d2-5c46ab22e2c7" });
        }
    }
}
