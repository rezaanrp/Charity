using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class discsedd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QuizQuestionDiscs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuestionNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuizQuestionDiscs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuizAnswernDiscs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuizQuestionDiscId = table.Column<int>(type: "int", nullable: false),
                    Score = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuizAnswernDiscs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuizAnswernDiscs_QuizQuestionDiscs_QuizQuestionDiscId",
                        column: x => x.QuizQuestionDiscId,
                        principalTable: "QuizQuestionDiscs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "QuizQuestionDiscs",
                columns: new[] { "Id", "Category", "Name", "QuestionNumber" },
                values: new object[,]
                {
                    { 1, "S", "معتمد و علاقمند", 1 },
                    { 2, "S", "اهل مدارا و محترم", 1 },
                    { 3, "D", "شجاع و ماجراجو", 1 },
                    { 4, "C", "سازگار و پیرو", 1 },
                    { 5, "S", "بامحبت و مهربان", 2 },
                    { 6, "S", "ملایم و سازگار", 2 },
                    { 7, "D", "مصمم و نتیجه‌گرا", 2 },
                    { 8, "I", "راضی و خشنود", 2 },
                    { 9, "I", "نوآور و آرمانی", 3 },
                    { 10, "C", "محافظه‌کار و محتاط", 3 },
                    { 11, "I", "اجتماعی و خوش‌مشرب", 3 },
                    { 12, "S", "اصلاح‌طلب و اهل مذاکره", 3 },
                    { 13, "D", "بی‌پروا و مستقل", 4 },
                    { 14, "C", "محافظه‌کار و محتاط", 4 },
                    { 15, "I", "بی‌خیال و سر به هوا", 4 },
                    { 16, "S", "مهربان و صمیمی", 4 },
                    { 17, "C", "دقیق و صریح", 5 },
                    { 18, "D", "متمرکز و هدفمند", 5 },
                    { 19, "S", "علاقمند به کار گروهی و تابع", 5 },
                    { 20, "I", "مشوق دیگران و انگیزاننده", 5 },
                    { 21, "C", "باوجدان و برنامه‌ریز", 6 },
                    { 22, "D", "ترقی‌خواه", 6 },
                    { 23, "D", "متهور و بی‌پروا", 6 },
                    { 24, "S", "قابل اعتماد و شنونده خوب", 6 },
                    { 25, "S", "حساس و ناامید", 7 },
                    { 26, "D", "رد هرگونه مخالفت و حق‌به‌جانب", 7 },
                    { 27, "C", "از خود راضی و مخفی کردن احساسات", 7 },
                    { 28, "I", "پیش بردن حرف خود و خواهان دیده‌شدن", 7 },
                    { 29, "D", "قوانین خسته‌تان می‌کند، سلحشور", 8 },
                    { 30, "D", "قوانین را به چالش می‌کشید، شجاع", 8 },
                    { 31, "C", "قوانین حس امنیت می‌دهد، قانونمند", 8 },
                    { 32, "S", "قوانین حس عدالت می‌دهد، عادل", 8 },
                    { 33, "S", "به دنبال تعادل و آرام", 9 },
                    { 34, "I", "پرحرف و جذاب", 9 },
                    { 35, "C", "منظم و قانونمند", 9 },
                    { 36, "D", "بی‌پروا و با روحیه بالا", 9 },
                    { 37, "D", "پاداش در مقابل دستاورد را دوست دارید", 10 },
                    { 38, "I", "از گردهمایی اجتماعی لذت می‌برید", 10 },
                    { 39, "C", "ادامه تحصیل را مهم می‌دانید", 10 },
                    { 40, "S", "از در معرض خطر بودن بیزارید", 10 },
                    { 41, "C", "نظام‌مند و مدیریت زمان خوب", 11 },
                    { 42, "S", "مضطرب و شتاب‌زده", 11 },
                    { 43, "S", "قابل اتکا و دارای پشتکار", 11 },
                    { 44, "I", "احساسی و عجول", 11 },
                    { 45, "C", "محتاط و محاسبه‌گر", 12 },
                    { 46, "C", "ثابت‌قدم و دقیق در جزئیات", 12 },
                    { 47, "I", "اجتماعی و مشتاق", 12 },
                    { 48, "D", "مسئولیت‌پذیر و صریح", 12 },
                    { 49, "C", "درگیر نکردن احساسات و محتاط", 13 },
                    { 50, "I", "غیرمنطقی و تعهد غیرعملی", 13 },
                    { 51, "D", "از خود راضی و مقاوم در برابر تغییر", 13 },
                    { 52, "D", "رک، بی‌ملاحظه و آمرانه", 13 },
                    { 53, "I", "هیجانی و شاد", 14 },
                    { 54, "S", "حامی و مدافع", 14 },
                    { 55, "C", "روش‌مند و دقیق", 14 },
                    { 56, "D", "رقابتی و استدلالی", 14 },
                    { 57, "C", "تحلیلگر خوب", 15 },
                    { 58, "S", "شنونده خوب", 15 },
                    { 59, "I", "مشوق خوب", 15 },
                    { 60, "D", "نماینده خوب", 15 },
                    { 61, "C", "دنبال حقایق هستید", 16 },
                    { 62, "S", "دنبال پیروی هستید", 16 },
                    { 63, "D", "دنبال رهبری هستید", 16 },
                    { 64, "I", "دنبال متقاعد کردن هستید", 16 },
                    { 65, "D", "قدرتمند و سخت‌کوش", 17 },
                    { 66, "I", "خوش‌بین و جذاب", 17 },
                    { 67, "S", "همکاری با دیگران و کمک‌کننده", 17 },
                    { 68, "C", "خیلی دقیق و صریح", 17 },
                    { 69, "S", "وفادار و متفکر", 18 },
                    { 70, "D", "چالشی و پیشگام", 18 },
                    { 71, "C", "تحلیلگر و با نزاکت", 18 },
                    { 72, "I", "محبوب و متقاعدکننده", 18 },
                    { 73, "I", "صبور و عجله نکردن برای خرید چیزی", 19 },
                    { 74, "I", "قاطع و تصمیم سریع برای خرید", 19 },
                    { 75, "I", "خودخواه و هزینه کردن برای خواسته ها", 19 },
                    { 76, "I", "خویشتن دار", 19 },
                    { 77, "I", "سازگار و دوستانه", 20 },
                    { 78, "I", "پرتحرک و سرزنده", 20 },
                    { 79, "I", "نترس و شجاع", 20 },
                    { 80, "I", "منظم و تطبیق پذیر", 20 },
                    { 81, "I", "سفت و سخت و کمال گرا", 21 },
                    { 82, "I", "پرهیز از یکنواختی و کارهای تکراری", 21 },
                    { 83, "I", "دوستار تغییر و اقدام برای آن", 21 },
                    { 84, "I", "خوش مشرب و رفتار محبت آمیز", 21 },
                    { 85, "I", "مؤثر و تاثیرگذار", 22 },
                    { 86, "I", "از توجه و فرصت های جدید لذت میبرید", 22 },
                    { 87, "I", "اجتناب از درگیری و آرام بودن", 22 },
                    { 88, "I", "اصولی و دیپلماتیک", 22 },
                    { 89, "I", "عجول و هیجانی", 23 },
                    { 90, "I", "حسابگر", 23 },
                    { 91, "I", "مدعی و سلطه گر", 23 },
                    { 92, "I", "غیر تهاجمی و قابل پیش بینی", 23 },
                    { 93, "I", "خلاق و منحصر به فرد", 24 },
                    { 94, "I", "برنامه ریزی برای نتیجه و نتیجه گرا", 24 },
                    { 95, "I", "قابل اعتماد و معتبر", 24 },
                    { 96, "I", "با استانداردهای بالا و معیارگرا", 24 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_QuizAnswernDiscs_QuizQuestionDiscId",
                table: "QuizAnswernDiscs",
                column: "QuizQuestionDiscId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuizAnswernDiscs");

            migrationBuilder.DropTable(
                name: "QuizQuestionDiscs");
        }
    }
}
