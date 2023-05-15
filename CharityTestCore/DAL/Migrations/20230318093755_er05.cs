using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class er05 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MBTIAnswerList",
                columns: table => new
                {
                    x_ = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Person_ = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_MBTIAnswerList", x => x.x_);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MBTIAnswerList");
        }
    }
}
