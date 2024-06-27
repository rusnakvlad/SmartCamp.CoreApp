using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartCamp.Core.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedDefaultAdminRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "048897f2-04c3-4467-a853-6b73b1e80adc", null, "Admin", "ADMIN" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "048897f2-04c3-4467-a853-6b73b1e80adc");
        }
    }
}
