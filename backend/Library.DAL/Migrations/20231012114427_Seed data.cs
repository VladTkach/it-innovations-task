using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.DAL.Migrations
{
    public partial class Seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "PageCount", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 3, 10, 14, 10, 52, 763, DateTimeKind.Local).AddTicks(3970), "Ipsam dolores ad possimus cumque autem adipisci quas.", "quia", 469, new DateTime(2023, 3, 10, 14, 10, 52, 763, DateTimeKind.Local).AddTicks(3970) },
                    { 2, new DateTime(2022, 7, 13, 10, 12, 24, 339, DateTimeKind.Local).AddTicks(7047), "Dolor aliquid molestiae ipsam quasi aut.", "quod", 256, new DateTime(2022, 7, 13, 10, 12, 24, 339, DateTimeKind.Local).AddTicks(7047) },
                    { 3, new DateTime(2022, 6, 10, 20, 22, 49, 783, DateTimeKind.Local).AddTicks(8361), "Voluptas error qui aut sed quo.", "minus", 287, new DateTime(2022, 6, 10, 20, 22, 49, 783, DateTimeKind.Local).AddTicks(8361) },
                    { 4, new DateTime(2022, 8, 3, 15, 9, 56, 632, DateTimeKind.Local).AddTicks(676), "Animi voluptate corrupti perspiciatis.", "doloribus", 500, new DateTime(2022, 8, 3, 15, 9, 56, 632, DateTimeKind.Local).AddTicks(676) },
                    { 5, new DateTime(2022, 5, 5, 11, 15, 16, 294, DateTimeKind.Local).AddTicks(8391), "Nisi itaque et soluta qui illo quia.", "expedita", 121, new DateTime(2022, 5, 5, 11, 15, 16, 294, DateTimeKind.Local).AddTicks(8391) },
                    { 6, new DateTime(2021, 10, 29, 10, 53, 9, 87, DateTimeKind.Local).AddTicks(2368), "Tempora eaque optio a et expedita impedit corporis est quo.", "illo", 266, new DateTime(2021, 10, 29, 10, 53, 9, 87, DateTimeKind.Local).AddTicks(2368) },
                    { 7, new DateTime(2022, 10, 31, 15, 36, 36, 61, DateTimeKind.Local).AddTicks(2259), "Animi dolorem assumenda eos vel.", "quaerat", 192, new DateTime(2022, 10, 31, 15, 36, 36, 61, DateTimeKind.Local).AddTicks(2259) },
                    { 8, new DateTime(2022, 4, 1, 20, 37, 41, 505, DateTimeKind.Local).AddTicks(345), "Minima quibusdam omnis neque aut in et autem asperiores rem.", "ipsam", 378, new DateTime(2022, 4, 1, 20, 37, 41, 505, DateTimeKind.Local).AddTicks(345) },
                    { 9, new DateTime(2022, 1, 27, 12, 55, 13, 194, DateTimeKind.Local).AddTicks(3807), "Ducimus qui necessitatibus nostrum exercitationem non cum et a consequatur.", "aspernatur", 219, new DateTime(2022, 1, 27, 12, 55, 13, 194, DateTimeKind.Local).AddTicks(3807) },
                    { 10, new DateTime(2023, 6, 15, 11, 45, 36, 696, DateTimeKind.Local).AddTicks(946), "Ullam laboriosam id totam voluptates aspernatur.", "tempora", 238, new DateTime(2023, 6, 15, 11, 45, 36, 696, DateTimeKind.Local).AddTicks(946) },
                    { 11, new DateTime(2022, 9, 14, 8, 6, 15, 128, DateTimeKind.Local).AddTicks(2948), "Mollitia ut molestiae laudantium atque quas.", "consequuntur", 290, new DateTime(2022, 9, 14, 8, 6, 15, 128, DateTimeKind.Local).AddTicks(2948) },
                    { 12, new DateTime(2023, 4, 7, 3, 58, 54, 806, DateTimeKind.Local).AddTicks(2528), "Quia minima quos accusantium dolor eum ut esse quo velit.", "et", 404, new DateTime(2023, 4, 7, 3, 58, 54, 806, DateTimeKind.Local).AddTicks(2528) },
                    { 13, new DateTime(2023, 3, 18, 11, 13, 11, 168, DateTimeKind.Local).AddTicks(6592), "Beatae expedita minus quaerat vero alias.", "ipsum", 269, new DateTime(2023, 3, 18, 11, 13, 11, 168, DateTimeKind.Local).AddTicks(6592) },
                    { 14, new DateTime(2022, 2, 8, 16, 19, 48, 22, DateTimeKind.Local).AddTicks(8591), "Eligendi reprehenderit consequatur numquam vel blanditiis.", "praesentium", 427, new DateTime(2022, 2, 8, 16, 19, 48, 22, DateTimeKind.Local).AddTicks(8591) },
                    { 15, new DateTime(2022, 2, 12, 17, 16, 56, 61, DateTimeKind.Local).AddTicks(8845), "Dicta voluptatem pariatur quo quis.", "ex", 286, new DateTime(2022, 2, 12, 17, 16, 56, 61, DateTimeKind.Local).AddTicks(8845) },
                    { 16, new DateTime(2022, 2, 14, 8, 19, 6, 452, DateTimeKind.Local).AddTicks(7971), "Porro nihil laboriosam minus provident.", "alias", 222, new DateTime(2022, 2, 14, 8, 19, 6, 452, DateTimeKind.Local).AddTicks(7971) },
                    { 17, new DateTime(2023, 2, 13, 0, 22, 16, 714, DateTimeKind.Local).AddTicks(6670), "Nobis dolores iusto eaque illum.", "assumenda", 92, new DateTime(2023, 2, 13, 0, 22, 16, 714, DateTimeKind.Local).AddTicks(6670) },
                    { 18, new DateTime(2023, 2, 28, 20, 33, 37, 672, DateTimeKind.Local).AddTicks(5215), "Ab eaque vel sunt hic et.", "temporibus", 440, new DateTime(2023, 2, 28, 20, 33, 37, 672, DateTimeKind.Local).AddTicks(5215) },
                    { 19, new DateTime(2022, 11, 1, 13, 50, 58, 461, DateTimeKind.Local).AddTicks(4923), "Voluptatem aut sit ipsum atque a quod est ex.", "inventore", 347, new DateTime(2022, 11, 1, 13, 50, 58, 461, DateTimeKind.Local).AddTicks(4923) },
                    { 20, new DateTime(2023, 1, 5, 23, 50, 8, 296, DateTimeKind.Local).AddTicks(8956), "Nobis error sequi vero et quae sed.", "fugiat", 390, new DateTime(2023, 1, 5, 23, 50, 8, 296, DateTimeKind.Local).AddTicks(8956) },
                    { 21, new DateTime(2022, 11, 29, 13, 4, 34, 967, DateTimeKind.Local).AddTicks(2018), "Dolor sapiente rerum qui.", "dolores", 391, new DateTime(2022, 11, 29, 13, 4, 34, 967, DateTimeKind.Local).AddTicks(2018) },
                    { 22, new DateTime(2023, 2, 16, 17, 13, 56, 722, DateTimeKind.Local).AddTicks(1883), "Quia voluptatem placeat ullam.", "et", 208, new DateTime(2023, 2, 16, 17, 13, 56, 722, DateTimeKind.Local).AddTicks(1883) },
                    { 23, new DateTime(2021, 12, 19, 3, 34, 27, 511, DateTimeKind.Local).AddTicks(131), "Beatae ea reiciendis.", "tenetur", 108, new DateTime(2021, 12, 19, 3, 34, 27, 511, DateTimeKind.Local).AddTicks(131) },
                    { 24, new DateTime(2023, 9, 3, 3, 52, 42, 666, DateTimeKind.Local).AddTicks(5738), "Optio aut quibusdam quae repellat voluptatem.", "eius", 436, new DateTime(2023, 9, 3, 3, 52, 42, 666, DateTimeKind.Local).AddTicks(5738) },
                    { 25, new DateTime(2022, 3, 11, 13, 12, 59, 153, DateTimeKind.Local).AddTicks(6182), "Amet reprehenderit occaecati aut animi recusandae.", "quidem", 465, new DateTime(2022, 3, 11, 13, 12, 59, 153, DateTimeKind.Local).AddTicks(6182) },
                    { 26, new DateTime(2023, 1, 29, 5, 17, 47, 653, DateTimeKind.Local).AddTicks(5395), "Non recusandae ut aut provident repudiandae ut.", "magnam", 106, new DateTime(2023, 1, 29, 5, 17, 47, 653, DateTimeKind.Local).AddTicks(5395) },
                    { 27, new DateTime(2023, 1, 3, 14, 20, 39, 190, DateTimeKind.Local).AddTicks(9098), "Ut natus voluptatum magnam dolores.", "voluptate", 483, new DateTime(2023, 1, 3, 14, 20, 39, 190, DateTimeKind.Local).AddTicks(9098) },
                    { 28, new DateTime(2023, 2, 9, 4, 22, 9, 536, DateTimeKind.Local).AddTicks(9922), "Totam delectus fugit qui neque recusandae et et voluptatum rem.", "et", 74, new DateTime(2023, 2, 9, 4, 22, 9, 536, DateTimeKind.Local).AddTicks(9922) },
                    { 29, new DateTime(2023, 4, 27, 17, 54, 20, 454, DateTimeKind.Local).AddTicks(7962), "A omnis quod doloribus sint dicta nostrum minus.", "expedita", 366, new DateTime(2023, 4, 27, 17, 54, 20, 454, DateTimeKind.Local).AddTicks(7962) },
                    { 30, new DateTime(2022, 11, 22, 16, 5, 21, 435, DateTimeKind.Local).AddTicks(256), "Fugiat quae possimus totam ut sed non quis ipsa natus.", "aut", 421, new DateTime(2022, 11, 22, 16, 5, 21, 435, DateTimeKind.Local).AddTicks(256) },
                    { 31, new DateTime(2022, 10, 1, 12, 9, 49, 348, DateTimeKind.Local).AddTicks(876), "Atque ut est aut aliquid doloremque in.", "rerum", 431, new DateTime(2022, 10, 1, 12, 9, 49, 348, DateTimeKind.Local).AddTicks(876) },
                    { 32, new DateTime(2022, 5, 10, 8, 10, 16, 152, DateTimeKind.Local).AddTicks(1771), "Ut accusamus dolor libero minus voluptatem.", "quos", 448, new DateTime(2022, 5, 10, 8, 10, 16, 152, DateTimeKind.Local).AddTicks(1771) },
                    { 33, new DateTime(2022, 9, 27, 8, 35, 0, 583, DateTimeKind.Local).AddTicks(8797), "Eum enim aut.", "non", 274, new DateTime(2022, 9, 27, 8, 35, 0, 583, DateTimeKind.Local).AddTicks(8797) },
                    { 34, new DateTime(2022, 7, 29, 18, 19, 55, 381, DateTimeKind.Local).AddTicks(6746), "Tempore in itaque ullam aliquid.", "voluptate", 465, new DateTime(2022, 7, 29, 18, 19, 55, 381, DateTimeKind.Local).AddTicks(6746) },
                    { 35, new DateTime(2021, 10, 21, 21, 52, 13, 443, DateTimeKind.Local).AddTicks(2292), "Qui debitis beatae.", "reprehenderit", 218, new DateTime(2021, 10, 21, 21, 52, 13, 443, DateTimeKind.Local).AddTicks(2292) },
                    { 36, new DateTime(2023, 3, 8, 23, 44, 38, 261, DateTimeKind.Local).AddTicks(9733), "Architecto alias nam voluptatem et.", "provident", 188, new DateTime(2023, 3, 8, 23, 44, 38, 261, DateTimeKind.Local).AddTicks(9733) },
                    { 37, new DateTime(2023, 6, 7, 4, 30, 10, 543, DateTimeKind.Local).AddTicks(6317), "Molestiae dolores aspernatur deserunt quidem eum eum fuga.", "earum", 143, new DateTime(2023, 6, 7, 4, 30, 10, 543, DateTimeKind.Local).AddTicks(6317) },
                    { 38, new DateTime(2022, 7, 7, 10, 34, 0, 256, DateTimeKind.Local).AddTicks(595), "Explicabo dolorum hic quia minima est dignissimos.", "sed", 52, new DateTime(2022, 7, 7, 10, 34, 0, 256, DateTimeKind.Local).AddTicks(595) },
                    { 39, new DateTime(2022, 1, 26, 3, 33, 38, 727, DateTimeKind.Local).AddTicks(7560), "At quae itaque.", "quo", 274, new DateTime(2022, 1, 26, 3, 33, 38, 727, DateTimeKind.Local).AddTicks(7560) },
                    { 40, new DateTime(2023, 9, 8, 4, 37, 37, 584, DateTimeKind.Local).AddTicks(272), "Commodi aspernatur asperiores similique et nihil quas et ducimus.", "aliquam", 247, new DateTime(2023, 9, 8, 4, 37, 37, 584, DateTimeKind.Local).AddTicks(272) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 40);
        }
    }
}
