using Microsoft.EntityFrameworkCore.Migrations;

namespace IDidThatGame.Data.Migrations
{
    public partial class SeedActionItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Actions",
                columns: new[] { "ActionId", "ActionName", "Advanced", "Category" },
                values: new object[,]
                {
                    { 1, "Crab walk", false, "default" },
                    { 18, "Hop on one leg", false, "default" },
                    { 17, "Tightrope", false, "default" },
                    { 16, "Lunge", false, "default" },
                    { 15, "Jumping jack", false, "default" },
                    { 14, "Frog hop", false, "default" },
                    { 13, "Run", false, "default" },
                    { 12, "Roll", false, "default" },
                    { 11, "Gallop", false, "default" },
                    { 10, "Spin", false, "default" },
                    { 9, "Walk backwards", false, "default" },
                    { 8, "Hop", false, "default" },
                    { 7, "Tip toe", false, "default" },
                    { 6, "Penguin walk", false, "default" },
                    { 5, "Skip", false, "default" },
                    { 4, "Dance", false, "default" },
                    { 3, "Crawl", false, "default" },
                    { 2, "Take giant steps", false, "default" },
                    { 19, "March", false, "default" },
                    { 20, "Skate", false, "default" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Actions",
                keyColumn: "ActionId",
                keyValue: 20);
        }
    }
}
