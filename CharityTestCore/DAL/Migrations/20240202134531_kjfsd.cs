using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class kjfsd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "MBTIAnswerList");

            migrationBuilder.DropColumn(
                name: "Family",
                table: "MBTIAnswerList");

            migrationBuilder.DropColumn(
                name: "MobileNumber",
                table: "MBTIAnswerList");

            migrationBuilder.DropColumn(
                name: "NationalCode",
                table: "MBTIAnswerList");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "MBTIAnswerList",
                newName: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "MBTIAnswerList",
                newName: "Name");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "MBTIAnswerList",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Family",
                table: "MBTIAnswerList",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                defaultValue: "");

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
        }
    }
}
