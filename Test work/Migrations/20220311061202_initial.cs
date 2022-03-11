using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test_work.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Citizens",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citizens", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Citizens",
                columns: new[] { "Id", "Age", "Name", "Sex" },
                values: new object[,]
                {
                    { "acmwojeiwqe9", (byte)0, "Anna Titova", "female" },
                    { "ajkvdnLdj22po11", (byte)0, "Pishkun Vladislav", "male" },
                    { "cnoqjpIdjkqpo11", (byte)0, "Sascha Braemer", "male" },
                    { "djkqpo11cnoqjpI", (byte)0, "Jessica Braemer", "female" },
                    { "guyqwhoij6", (byte)0, "Dmitry Vegas", "male" },
                    { "hqwuiehquikxhc5", (byte)0, "German Titov", "male" },
                    { "kjlqwoijeo7", (byte)0, "Solomon Shlemovich", "male" },
                    { "lkkpokqw8", (byte)0, "Alex Whitedrinker", "female" },
                    { "lkqjweiojqiow4", (byte)0, "Erzhena Koroleva", "female" },
                    { "qjIdwojqiowj10", (byte)0, "Elmo Kennedy", "male" },
                    { "qmvqqwrqsds2", (byte)0, "Jack Anderson", "male" },
                    { "qyfgqiyhwfoq1", (byte)0, "Stan Smith", "male" },
                    { "vdhgqvgj3", (byte)0, "Olga Popova", "female" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Citizens");
        }
    }
}
