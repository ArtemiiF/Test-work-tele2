using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test_work.Migrations
{
    public partial class addAge : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Citizens",
                keyColumn: "Id",
                keyValue: "acmwojeiwqe9",
                column: "Age",
                value: (byte)19);

            migrationBuilder.UpdateData(
                table: "Citizens",
                keyColumn: "Id",
                keyValue: "ajkvdnLdj22po11",
                column: "Age",
                value: (byte)27);

            migrationBuilder.UpdateData(
                table: "Citizens",
                keyColumn: "Id",
                keyValue: "cnoqjpIdjkqpo11",
                column: "Age",
                value: (byte)11);

            migrationBuilder.UpdateData(
                table: "Citizens",
                keyColumn: "Id",
                keyValue: "djkqpo11cnoqjpI",
                column: "Age",
                value: (byte)31);

            migrationBuilder.UpdateData(
                table: "Citizens",
                keyColumn: "Id",
                keyValue: "guyqwhoij6",
                column: "Age",
                value: (byte)78);

            migrationBuilder.UpdateData(
                table: "Citizens",
                keyColumn: "Id",
                keyValue: "hqwuiehquikxhc5",
                column: "Age",
                value: (byte)42);

            migrationBuilder.UpdateData(
                table: "Citizens",
                keyColumn: "Id",
                keyValue: "kjlqwoijeo7",
                column: "Age",
                value: (byte)41);

            migrationBuilder.UpdateData(
                table: "Citizens",
                keyColumn: "Id",
                keyValue: "lkkpokqw8",
                column: "Age",
                value: (byte)45);

            migrationBuilder.UpdateData(
                table: "Citizens",
                keyColumn: "Id",
                keyValue: "lkqjweiojqiow4",
                column: "Age",
                value: (byte)31);

            migrationBuilder.UpdateData(
                table: "Citizens",
                keyColumn: "Id",
                keyValue: "qjIdwojqiowj10",
                column: "Age",
                value: (byte)63);

            migrationBuilder.UpdateData(
                table: "Citizens",
                keyColumn: "Id",
                keyValue: "qmvqqwrqsds2",
                column: "Age",
                value: (byte)14);

            migrationBuilder.UpdateData(
                table: "Citizens",
                keyColumn: "Id",
                keyValue: "qyfgqiyhwfoq1",
                column: "Age",
                value: (byte)30);

            migrationBuilder.UpdateData(
                table: "Citizens",
                keyColumn: "Id",
                keyValue: "vdhgqvgj3",
                column: "Age",
                value: (byte)24);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Citizens",
                keyColumn: "Id",
                keyValue: "acmwojeiwqe9",
                column: "Age",
                value: (byte)0);

            migrationBuilder.UpdateData(
                table: "Citizens",
                keyColumn: "Id",
                keyValue: "ajkvdnLdj22po11",
                column: "Age",
                value: (byte)0);

            migrationBuilder.UpdateData(
                table: "Citizens",
                keyColumn: "Id",
                keyValue: "cnoqjpIdjkqpo11",
                column: "Age",
                value: (byte)0);

            migrationBuilder.UpdateData(
                table: "Citizens",
                keyColumn: "Id",
                keyValue: "djkqpo11cnoqjpI",
                column: "Age",
                value: (byte)0);

            migrationBuilder.UpdateData(
                table: "Citizens",
                keyColumn: "Id",
                keyValue: "guyqwhoij6",
                column: "Age",
                value: (byte)0);

            migrationBuilder.UpdateData(
                table: "Citizens",
                keyColumn: "Id",
                keyValue: "hqwuiehquikxhc5",
                column: "Age",
                value: (byte)0);

            migrationBuilder.UpdateData(
                table: "Citizens",
                keyColumn: "Id",
                keyValue: "kjlqwoijeo7",
                column: "Age",
                value: (byte)0);

            migrationBuilder.UpdateData(
                table: "Citizens",
                keyColumn: "Id",
                keyValue: "lkkpokqw8",
                column: "Age",
                value: (byte)0);

            migrationBuilder.UpdateData(
                table: "Citizens",
                keyColumn: "Id",
                keyValue: "lkqjweiojqiow4",
                column: "Age",
                value: (byte)0);

            migrationBuilder.UpdateData(
                table: "Citizens",
                keyColumn: "Id",
                keyValue: "qjIdwojqiowj10",
                column: "Age",
                value: (byte)0);

            migrationBuilder.UpdateData(
                table: "Citizens",
                keyColumn: "Id",
                keyValue: "qmvqqwrqsds2",
                column: "Age",
                value: (byte)0);

            migrationBuilder.UpdateData(
                table: "Citizens",
                keyColumn: "Id",
                keyValue: "qyfgqiyhwfoq1",
                column: "Age",
                value: (byte)0);

            migrationBuilder.UpdateData(
                table: "Citizens",
                keyColumn: "Id",
                keyValue: "vdhgqvgj3",
                column: "Age",
                value: (byte)0);
        }
    }
}
