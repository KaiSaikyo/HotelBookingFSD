using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelBooking.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddApplicationTables1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b8c8035-2be5-436f-8b80-8a5fed1438ce", "AQAAAAIAAYagAAAAEByKPT0Wn5Qm6lDBBIYmQBRu1yvC9abPnpjKUJU/9LFMvNlk9UOxm/V425unqyiSvg==", "155ed921-7cc0-4044-8d42-00869be81ea7" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2007b23-7c00-4756-9872-198f6e2cf207", "AQAAAAIAAYagAAAAEEDiGKY7IrnhsjtwMk6IFrpsmk/0JpYnNArQiwDHHZilmCEALR/5VC8leNN25jOm4w==", "4511d4ec-3c52-4f9a-a933-2b69a3f3a580" });
        }
    }
}
