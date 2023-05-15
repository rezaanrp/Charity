using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class MBTIADDNAME : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Person_",
                table: "MBTIAnswerList");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "MBTIAnswerList",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MobileNumber",
                table: "MBTIAnswerList",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NationalCode",
                table: "MBTIAnswerList",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "xFamily",
                table: "MBTIAnswerList",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "xName",
                table: "MBTIAnswerList",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "MBTIAnswerList");

            migrationBuilder.DropColumn(
                name: "MobileNumber",
                table: "MBTIAnswerList");

            migrationBuilder.DropColumn(
                name: "NationalCode",
                table: "MBTIAnswerList");

            migrationBuilder.DropColumn(
                name: "xFamily",
                table: "MBTIAnswerList");

            migrationBuilder.DropColumn(
                name: "xName",
                table: "MBTIAnswerList");

            migrationBuilder.AddColumn<int>(
                name: "Person_",
                table: "MBTIAnswerList",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
