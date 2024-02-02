using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class asasas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Family", "HashPassword", "MobileNumber", "Name", "NationalNumber", "Role", "UserName" },
                values: new object[] { new Guid("7fee1078-53fe-4a93-9f80-e9338c928024"), "سیستم", "iuJVMTAyPlSJ6JhIkBdpz7k5L2/Gg8MbOQDfBGQ12WE=", "09130000000", "مدیر", "1234567980", "admin", "p_admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fee1078-53fe-4a93-9f80-e9338c928024"));
        }
    }
}
