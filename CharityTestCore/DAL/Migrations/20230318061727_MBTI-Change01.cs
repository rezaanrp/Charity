using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class MBTIChange01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Answer1Value",
                table: "MBTIQuestionList");

            migrationBuilder.DropColumn(
                name: "AnswerValue",
                table: "MBTIQuestionList");

            migrationBuilder.DropColumn(
                name: "Answer2",
                table: "MBTIAnswerList");

            migrationBuilder.RenameColumn(
                name: "QestionList_",
                table: "MBTIAnswerList",
                newName: "Person_x_");

            migrationBuilder.AddColumn<string>(
                name: "Answer3",
                table: "MBTIQuestionList",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Answer1",
                table: "MBTIAnswerList",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Question_",
                table: "MBTIAnswerList",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "RegisterDate",
                table: "MBTIAnswerList",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_MBTIAnswerList_Person_x_",
                table: "MBTIAnswerList",
                column: "Person_x_");

            migrationBuilder.AddForeignKey(
                name: "FK_MBTIAnswerList_EptQuestion_Person_x_",
                table: "MBTIAnswerList",
                column: "Person_x_",
                principalTable: "EptQuestion",
                principalColumn: "x_",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MBTIAnswerList_EptQuestion_Person_x_",
                table: "MBTIAnswerList");

            migrationBuilder.DropIndex(
                name: "IX_MBTIAnswerList_Person_x_",
                table: "MBTIAnswerList");

            migrationBuilder.DropColumn(
                name: "Answer3",
                table: "MBTIQuestionList");

            migrationBuilder.DropColumn(
                name: "Question_",
                table: "MBTIAnswerList");

            migrationBuilder.DropColumn(
                name: "RegisterDate",
                table: "MBTIAnswerList");

            migrationBuilder.RenameColumn(
                name: "Person_x_",
                table: "MBTIAnswerList",
                newName: "QestionList_");

            migrationBuilder.AddColumn<int>(
                name: "Answer1Value",
                table: "MBTIQuestionList",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AnswerValue",
                table: "MBTIQuestionList",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Answer1",
                table: "MBTIAnswerList",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "Answer2",
                table: "MBTIAnswerList",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
