using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class MBTIAnswerList11111111333333333 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "MBTIAnswerList",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60);

            migrationBuilder.CreateIndex(
                name: "IX_MBTIAnswerList_UserId",
                table: "MBTIAnswerList",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_MBTIAnswerList_Users_UserId",
                table: "MBTIAnswerList",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MBTIAnswerList_Users_UserId",
                table: "MBTIAnswerList");

            migrationBuilder.DropIndex(
                name: "IX_MBTIAnswerList_UserId",
                table: "MBTIAnswerList");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "MBTIAnswerList",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");
        }
    }
}
