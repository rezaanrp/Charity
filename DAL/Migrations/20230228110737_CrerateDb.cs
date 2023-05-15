using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class CrerateDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EptQuestion",
                columns: table => new
                {
                    x_ = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    xName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    xFamily = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
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
                    table.PrimaryKey("PK_EptQuestion", x => x.x_);
                });

            migrationBuilder.CreateTable(
                name: "NewsCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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

            migrationBuilder.CreateTable(
                name: "AllNews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MainContent = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    Staus = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ImageData = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    ImageMimeType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Show = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllNews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AllNews_NewsCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "NewsCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AllNews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AllNews_CategoryId",
                table: "AllNews",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_AllNews_UserId",
                table: "AllNews",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AllNews");

            migrationBuilder.DropTable(
                name: "EptQuestion");

            migrationBuilder.DropTable(
                name: "NewsCategories");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
