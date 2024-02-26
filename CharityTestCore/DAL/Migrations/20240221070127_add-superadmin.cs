using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class addsuperadmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Family", "HashPassword", "IsDelete", "MobileNumber", "Name", "NationalNumber", "Role", "UserName" },
                values: new object[] { new Guid("97842857-cc39-49e1-4449-08dc23f263f7"), "سیستم", "1hO2KL3nZdudecMmm3hT5sh7m7Y9P9R030JzQxRlpkg=", false, "09132370000", "مدیر", "2211111111", "superadmin", "r_admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("97842857-cc39-49e1-4449-08dc23f263f7"));
        }
    }
}
