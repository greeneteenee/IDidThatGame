using Microsoft.EntityFrameworkCore.Migrations;

namespace IDidThatGame.Data.Migrations
{
    public partial class SeedPlaceItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "PlaceId", "Category", "PlaceName" },
                values: new object[,]
                {
                    { 1, "home", "to the fridge" },
                    { 23, "home", "to a closet" },
                    { 24, "home", "to a window and back" },
                    { 25, "home", "to something red" },
                    { 26, "home", "to something blue" },
                    { 27, "home", "to something yellow" },
                    { 28, "home", "to something green" },
                    { 29, "home", "to something purple" },
                    { 22, "home", "to a toilet" },
                    { 30, "home", "to something orange" },
                    { 32, "home", "behind a curtain and back" },
                    { 33, "home", "to a toy and back" },
                    { 34, "home", "to a picture and back" },
                    { 35, "home", "to a laundry basket" },
                    { 36, "home", "to a computer" },
                    { 37, "home", "to two lamps" },
                    { 38, "home", "to a shoe and back" },
                    { 31, "home", "to something pink" },
                    { 21, "home", "to two doors" },
                    { 20, "home", "to two rugs" },
                    { 19, "home", "over a sofa and back" },
                    { 2, "home", "to a sink" },
                    { 3, "home", "to the front door" },
                    { 4, "home", "to four walls" },
                    { 5, "home", "to two lightswitches" },
                    { 6, "home", "to a tv" },
                    { 7, "home", "to a mirror" },
                    { 8, "home", "to a plant" },
                    { 9, "home", "to a bathtub" },
                    { 10, "home", "to a shower" },
                    { 11, "home", "to a bookcase" },
                    { 12, "home", "to a trashcan" },
                    { 13, "home", "around a chair" },
                    { 14, "home", "to a bedroom" },
                    { 15, "home", "to three rooms" },
                    { 16, "home", "around a table" },
                    { 17, "home", "under a table and back" },
                    { 18, "home", "over a bed" },
                    { 39, "home", "over a pillow and back" },
                    { 40, "home", "to your favorite thing" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 40);
        }
    }
}
