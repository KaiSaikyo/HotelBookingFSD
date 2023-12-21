using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelBooking.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddApplicationTables3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stays_Rooms_RoomId",
                table: "Stays");

            migrationBuilder.DropIndex(
                name: "IX_Stays_RoomId",
                table: "Stays");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "Stays");

            migrationBuilder.AddColumn<int>(
                name: "HotelId",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2007b23-7c00-4756-9872-198f6e2cf207", "AQAAAAIAAYagAAAAEEDiGKY7IrnhsjtwMk6IFrpsmk/0JpYnNArQiwDHHZilmCEALR/5VC8leNN25jOm4w==", "4511d4ec-3c52-4f9a-a933-2b69a3f3a580" });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_HotelId",
                table: "Bookings",
                column: "HotelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Hotels_HotelId",
                table: "Bookings",
                column: "HotelId",
                principalTable: "Hotels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Hotels_HotelId",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_HotelId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "HotelId",
                table: "Bookings");

            migrationBuilder.AddColumn<int>(
                name: "RoomId",
                table: "Stays",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e4ce16e-a0a3-4788-9e12-90f77d10babc", "AQAAAAIAAYagAAAAEEa6Rz0Jv2D7S79mfXez1MUnJ+EwAnVJBEsdx00CPI0AtvH8vWU8wfC/gZ+H6Iom+w==", "073066fb-4b3f-4ac4-89a4-5b575dd9691d" });

            migrationBuilder.CreateIndex(
                name: "IX_Stays_RoomId",
                table: "Stays",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Stays_Rooms_RoomId",
                table: "Stays",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
