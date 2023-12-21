using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelBooking.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "441a72de-e9f6-48ba-942a-1b6f16cec2a2", "AQAAAAIAAYagAAAAEHrtBGhtXYZks/kA3CLse9hxqSs1HzXNVYBFsjSItKK8z7Xvd7JEXA2e+co3tby79A==", "f36a1334-f225-47aa-8016-2f0344488d86" });

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
                columns: new[] { "Id", "ComplimentaryServices", "EmergencyContact", "OccupancyStatus" },
                values: new object[,]
                {
                    { 1, "Wi-Fi, Breakfast", "12345678", true },
                    { 2, "Pool Access, Newspaper", "87654321", false },
                    { 3, "Gym Access, Parking", "55558888", true },
                    { 4, "Airport Shuttle", "33332222", false }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "CheckInDate", "CheckOutDate", "CustomerId", "Destination", "HotelId", "NumGuest", "StaffId", "Status", "StayId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "City A", 1, 2, 1, true, 1 },
                    { 2, new DateTime(2023, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "City B", 2, 1, 2, true, 2 },
                    { 3, new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "City C", 3, 3, 3, false, 3 },
                    { 4, new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "City D", 4, 2, 4, true, 4 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CustomerId", "Date", "Description", "Rating", "StayId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enjoyed the stay, great service!", 4.5m, 1 },
                    { 2, 2, new DateTime(2023, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Decent stay, room was comfortable", 3.0m, 2 },
                    { 3, 3, new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Outstanding experience, highly recommended!", 5.0m, 3 },
                    { 4, 4, new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Average stay, room cleanliness could be improved", 2.5m, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b8c8035-2be5-436f-8b80-8a5fed1438ce", "AQAAAAIAAYagAAAAEByKPT0Wn5Qm6lDBBIYmQBRu1yvC9abPnpjKUJU/9LFMvNlk9UOxm/V425unqyiSvg==", "155ed921-7cc0-4044-8d42-00869be81ea7" });
        }
    }
}
