using Microsoft.EntityFrameworkCore.Migrations;

namespace IDidThatGame.Data.Migrations
{
    public partial class SeedChallengeItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Challenges",
                columns: new[] { "ChallengeId", "Advanced", "Category", "ChallengeName" },
                values: new object[,]
                {
                    { 1, false, "default", "with a book in your left hand!" },
                    { 38, false, "default", "with a pillow between your elbows!" },
                    { 39, false, "default", "with a pillow between your knees!" },
                    { 40, false, "default", "with a pillow under your chin!" },
                    { 41, false, "default", "with a pillow behind your back!" },
                    { 42, false, "default", "with a broom in your left hand!" },
                    { 43, false, "default", "with a broom in your right hand!" },
                    { 44, false, "default", "with a broom over your head!" },
                    { 45, false, "default", "with a broom behind your back!" },
                    { 46, false, "default", "with a broom under your arm!" },
                    { 47, false, "default", "with a broom between your elbows!" },
                    { 48, false, "default", "with a broom between your knees!" },
                    { 49, false, "default", "with a broom under your chin!" },
                    { 50, false, "default", "with a blanket over your head!" },
                    { 51, false, "default", "with a blanket behind your back!" },
                    { 52, false, "default", "with a spoon between your teeth!" },
                    { 53, false, "default", "with a spoon on your nose!" },
                    { 54, false, "default", "with a cup in your left hand!" },
                    { 68, false, "default", "sideways!" },
                    { 67, false, "default", "backwards!" },
                    { 66, false, "default", "in a pillow case!" },
                    { 65, false, "default", "while bouncing a ball!" },
                    { 64, false, "default", "with a paper between your knees!" },
                    { 63, false, "default", "with a paper between your elbows!" },
                    { 37, false, "default", "with a pillow under your arm!" },
                    { 62, false, "default", "with a paper on your head!" },
                    { 60, false, "default", "with a cup under your chin!" },
                    { 59, false, "default", "with a cup between your knees!" },
                    { 58, false, "default", "with a cup between your elbows!" },
                    { 57, false, "default", "with a cup inside your clothes!" },
                    { 56, false, "default", "with a cup on your head!" },
                    { 55, false, "default", "with a cup in your right hand!" },
                    { 61, false, "default", "with a cup on your shoulder!" },
                    { 36, false, "default", "with a pillow inside your clothes!" },
                    { 35, false, "default", "with a pillow on your head!" },
                    { 34, false, "default", "with a pillow in your right hand!" },
                    { 15, false, "default", "with a ball between your knees!" },
                    { 14, false, "default", "with a ball between your elbows!" },
                    { 13, false, "default", "with a ball under your arm!" },
                    { 12, false, "default", "with a ball inside your clothes!" },
                    { 11, false, "default", "with a ball in your right hand!" },
                    { 10, false, "default", "with a ball in your left hand!" },
                    { 16, false, "default", "with a ball under your chin!" },
                    { 9, false, "default", "with a book behind your back!" },
                    { 7, false, "default", "with a book between your knees!" },
                    { 6, false, "default", "with a book between your elbows!" },
                    { 5, false, "default", "with a book under your arm!" },
                    { 4, false, "default", "with a book inside your clothes!" },
                    { 3, false, "default", "with a book on your head!" },
                    { 2, false, "default", "with a book in your right hand!" },
                    { 8, false, "default", "with a book under your chin!" },
                    { 69, false, "default", "with your hands behind your back!" },
                    { 17, false, "default", "with a bottle in your left hand!" },
                    { 19, false, "default", "with a bottle inside your clothes!" },
                    { 33, false, "default", "with a pillow in your left hand!" },
                    { 32, false, "default", "with a stuffed animal behind your back!" },
                    { 31, false, "default", "with a stuffed animal under your chin!" },
                    { 30, false, "default", "with a stuffed animal between your knees!" },
                    { 29, false, "default", "with a stuffed animal between your elbows!" },
                    { 28, false, "default", "with a stuffed animal under your arm!" },
                    { 18, false, "default", "with a bottle in your right hand!" },
                    { 27, false, "default", "with a stuffed animal inside your clothes!" },
                    { 25, false, "default", "with a stuffed animal in your right hand!" },
                    { 24, false, "default", "with a stuffed animal in your left hand!" },
                    { 23, false, "default", "with a bottle under your chin!" },
                    { 22, false, "default", "with a bottle between your knees!" },
                    { 21, false, "default", "with a bottle between your elbows!" },
                    { 20, false, "default", "with a bottle under your arm!" },
                    { 26, false, "default", "with a stuffed animal on your head!" },
                    { 70, false, "default", "with your hands on your head!" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Challenges",
                keyColumn: "ChallengeId",
                keyValue: 70);
        }
    }
}
