using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class CreateNew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EptQuestion",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Family = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    NationalCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: true),
                    HaveSkill = table.Column<bool>(type: "bit", nullable: true),
                    BeforeYouHaveJob = table.Column<bool>(type: "bit", nullable: true),
                    DoYouWantHaveJob = table.Column<bool>(type: "bit", nullable: true),
                    S01 = table.Column<byte>(type: "tinyint", nullable: false),
                    S02 = table.Column<byte>(type: "tinyint", nullable: false),
                    S03 = table.Column<byte>(type: "tinyint", nullable: false),
                    S04 = table.Column<byte>(type: "tinyint", nullable: false),
                    S05 = table.Column<byte>(type: "tinyint", nullable: false),
                    S06 = table.Column<byte>(type: "tinyint", nullable: false),
                    S07 = table.Column<byte>(type: "tinyint", nullable: false),
                    S08 = table.Column<byte>(type: "tinyint", nullable: false),
                    S09 = table.Column<byte>(type: "tinyint", nullable: false),
                    S10 = table.Column<byte>(type: "tinyint", nullable: false),
                    S11 = table.Column<byte>(type: "tinyint", nullable: false),
                    S12 = table.Column<byte>(type: "tinyint", nullable: false),
                    S13 = table.Column<byte>(type: "tinyint", nullable: false),
                    S14 = table.Column<byte>(type: "tinyint", nullable: false),
                    S15 = table.Column<byte>(type: "tinyint", nullable: false),
                    S16 = table.Column<byte>(type: "tinyint", nullable: false),
                    S17 = table.Column<byte>(type: "tinyint", nullable: false),
                    S18 = table.Column<byte>(type: "tinyint", nullable: false),
                    S19 = table.Column<byte>(type: "tinyint", nullable: false),
                    S20 = table.Column<byte>(type: "tinyint", nullable: false),
                    S21 = table.Column<byte>(type: "tinyint", nullable: false),
                    S22 = table.Column<byte>(type: "tinyint", nullable: false),
                    S23 = table.Column<byte>(type: "tinyint", nullable: false),
                    S24 = table.Column<byte>(type: "tinyint", nullable: false),
                    S25 = table.Column<byte>(type: "tinyint", nullable: false),
                    S26 = table.Column<byte>(type: "tinyint", nullable: false),
                    S27 = table.Column<byte>(type: "tinyint", nullable: false),
                    S28 = table.Column<byte>(type: "tinyint", nullable: false),
                    S29 = table.Column<byte>(type: "tinyint", nullable: false),
                    S30 = table.Column<byte>(type: "tinyint", nullable: false),
                    S31 = table.Column<byte>(type: "tinyint", nullable: false),
                    S32 = table.Column<byte>(type: "tinyint", nullable: false),
                    S33 = table.Column<byte>(type: "tinyint", nullable: false),
                    S34 = table.Column<byte>(type: "tinyint", nullable: false),
                    S35 = table.Column<byte>(type: "tinyint", nullable: false),
                    S36 = table.Column<byte>(type: "tinyint", nullable: false),
                    S37 = table.Column<byte>(type: "tinyint", nullable: false),
                    S38 = table.Column<byte>(type: "tinyint", nullable: false),
                    S39 = table.Column<byte>(type: "tinyint", nullable: false),
                    S40 = table.Column<byte>(type: "tinyint", nullable: false),
                    S41 = table.Column<byte>(type: "tinyint", nullable: false),
                    S42 = table.Column<byte>(type: "tinyint", nullable: false),
                    S43 = table.Column<byte>(type: "tinyint", nullable: false),
                    S44 = table.Column<byte>(type: "tinyint", nullable: false),
                    S45 = table.Column<byte>(type: "tinyint", nullable: false),
                    S46 = table.Column<byte>(type: "tinyint", nullable: false),
                    S47 = table.Column<byte>(type: "tinyint", nullable: false),
                    S48 = table.Column<byte>(type: "tinyint", nullable: false),
                    S49 = table.Column<byte>(type: "tinyint", nullable: false),
                    S50 = table.Column<byte>(type: "tinyint", nullable: false),
                    S51 = table.Column<byte>(type: "tinyint", nullable: false),
                    S52 = table.Column<byte>(type: "tinyint", nullable: false),
                    S53 = table.Column<byte>(type: "tinyint", nullable: false),
                    S54 = table.Column<byte>(type: "tinyint", nullable: false),
                    S55 = table.Column<byte>(type: "tinyint", nullable: false),
                    S56 = table.Column<byte>(type: "tinyint", nullable: false),
                    S57 = table.Column<byte>(type: "tinyint", nullable: false),
                    S58 = table.Column<byte>(type: "tinyint", nullable: false),
                    S59 = table.Column<byte>(type: "tinyint", nullable: false),
                    S60 = table.Column<byte>(type: "tinyint", nullable: false),
                    S61 = table.Column<byte>(type: "tinyint", nullable: false),
                    S62 = table.Column<byte>(type: "tinyint", nullable: false),
                    S63 = table.Column<byte>(type: "tinyint", nullable: false),
                    S64 = table.Column<byte>(type: "tinyint", nullable: false),
                    S65 = table.Column<byte>(type: "tinyint", nullable: false),
                    S66 = table.Column<byte>(type: "tinyint", nullable: false),
                    S67 = table.Column<byte>(type: "tinyint", nullable: false),
                    S68 = table.Column<byte>(type: "tinyint", nullable: false),
                    S69 = table.Column<byte>(type: "tinyint", nullable: false),
                    S70 = table.Column<byte>(type: "tinyint", nullable: false),
                    S71 = table.Column<byte>(type: "tinyint", nullable: false),
                    S72 = table.Column<byte>(type: "tinyint", nullable: false),
                    S73 = table.Column<byte>(type: "tinyint", nullable: false),
                    S74 = table.Column<byte>(type: "tinyint", nullable: false),
                    S75 = table.Column<byte>(type: "tinyint", nullable: false),
                    S76 = table.Column<byte>(type: "tinyint", nullable: false),
                    S77 = table.Column<byte>(type: "tinyint", nullable: false),
                    S78 = table.Column<byte>(type: "tinyint", nullable: false),
                    S79 = table.Column<byte>(type: "tinyint", nullable: false),
                    S80 = table.Column<byte>(type: "tinyint", nullable: false),
                    S81 = table.Column<byte>(type: "tinyint", nullable: false),
                    S82 = table.Column<byte>(type: "tinyint", nullable: false),
                    S83 = table.Column<byte>(type: "tinyint", nullable: false),
                    S84 = table.Column<byte>(type: "tinyint", nullable: false),
                    S85 = table.Column<byte>(type: "tinyint", nullable: false),
                    S86 = table.Column<byte>(type: "tinyint", nullable: false),
                    S87 = table.Column<byte>(type: "tinyint", nullable: false),
                    S88 = table.Column<byte>(type: "tinyint", nullable: false),
                    S89 = table.Column<byte>(type: "tinyint", nullable: false),
                    S90 = table.Column<byte>(type: "tinyint", nullable: false),
                    S91 = table.Column<byte>(type: "tinyint", nullable: false),
                    S92 = table.Column<byte>(type: "tinyint", nullable: false),
                    S93 = table.Column<byte>(type: "tinyint", nullable: false),
                    S94 = table.Column<byte>(type: "tinyint", nullable: false),
                    S95 = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EptQuestion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EptQuiz",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Answer1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Answer2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Answer3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Answer4 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EptQuiz", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MBTIAnswerList",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Family = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    NationalCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: true),
                    Answer1 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer2 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer3 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer4 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer5 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer6 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer7 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer8 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer9 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer10 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer11 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer12 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer13 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer14 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer15 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer16 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer17 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer18 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer19 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer20 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer21 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer22 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer23 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer24 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer25 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer26 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer27 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer28 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer29 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer30 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer31 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer32 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer33 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer34 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer35 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer36 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer37 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer38 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer39 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer40 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer41 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer42 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer43 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer44 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer45 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer46 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer47 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer48 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer49 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer50 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer51 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer52 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer53 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer54 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer55 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer56 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer57 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer58 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer59 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer60 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer61 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer62 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer63 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer64 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer65 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer66 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer67 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer68 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer69 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer70 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer71 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer72 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer73 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer74 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer75 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer76 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer77 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer78 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer79 = table.Column<byte>(type: "tinyint", nullable: false),
                    Answer80 = table.Column<byte>(type: "tinyint", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MBTIAnswerList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MBTIQuestionList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Answer1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Answer2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Answer3 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MBTIQuestionList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "mGenGroup",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Group = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mGenGroup", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    HashPassword = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Family = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    NationalNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EptQuestion");

            migrationBuilder.DropTable(
                name: "EptQuiz");

            migrationBuilder.DropTable(
                name: "MBTIAnswerList");

            migrationBuilder.DropTable(
                name: "MBTIQuestionList");

            migrationBuilder.DropTable(
                name: "mGenGroup");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
