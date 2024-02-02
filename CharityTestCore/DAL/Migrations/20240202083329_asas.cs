using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class asas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "EptQuestion");

            migrationBuilder.DropColumn(
                name: "Family",
                table: "EptQuestion");

            migrationBuilder.DropColumn(
                name: "MobileNumber",
                table: "EptQuestion");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "EptQuestion");

            migrationBuilder.DropColumn(
                name: "NationalCode",
                table: "EptQuestion");

            migrationBuilder.AddColumn<string>(
                name: "UserId_",
                table: "EptQuestion",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Users_NationalNumber",
                table: "Users",
                column: "NationalNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserName",
                table: "Users",
                column: "UserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_NationalNumber",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_UserName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserId_",
                table: "EptQuestion");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "EptQuestion",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Family",
                table: "EptQuestion",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MobileNumber",
                table: "EptQuestion",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "EptQuestion",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NationalCode",
                table: "EptQuestion",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");
        }
    }
}
