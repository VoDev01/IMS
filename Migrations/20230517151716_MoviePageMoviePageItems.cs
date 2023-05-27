using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IMS.Migrations
{
    /// <inheritdoc />
    public partial class MoviePageMoviePageItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_Movies_MovieId",
                table: "Ratings");

            migrationBuilder.DropTable(
                name: "CountryMovie");

            migrationBuilder.DropTable(
                name: "GenreMovie");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3545269);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3781461);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3985922);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4336645);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 7801402);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 10842163);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 32518739);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 47738117);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "США" },
                    { 2, "Швейцария" },
                    { 3, "Франция" },
                    { 4, "Польша" },
                    { 5, "Великобритания" },
                    { 6, "Швеция" },
                    { 7, "Индия" },
                    { 8, "Испания" },
                    { 9, "Германия" },
                    { 10, "Италия" },
                    { 11, "Гонконг" },
                    { 12, "Германия (ФРГ)" },
                    { 13, "Австралия" },
                    { 14, "Канада" },
                    { 15, "Мексика" },
                    { 16, "Япония" },
                    { 17, "Дания" },
                    { 18, "Чехия" },
                    { 19, "Ирландия" },
                    { 20, "Люксембург" },
                    { 21, "Китай" },
                    { 22, "Норвегия" },
                    { 23, "Нидерланды" },
                    { 24, "Аргентина" },
                    { 25, "Финляндия" },
                    { 26, "Босния и Герцеговина" },
                    { 27, "Австрия" },
                    { 28, "Тайвань" },
                    { 29, "Новая Зеландия" },
                    { 30, "Бразилия" },
                    { 31, "Чехословакия" },
                    { 32, "Мальта" },
                    { 33, "СССР" },
                    { 34, "Россия" },
                    { 35, "Югославия" },
                    { 36, "Португалия" },
                    { 37, "Румыния" },
                    { 38, "Хорватия" },
                    { 39, "ЮАР" },
                    { 40, "Куба" },
                    { 41, "Колумбия" },
                    { 42, "Израиль" },
                    { 43, "Намибия" },
                    { 44, "Турция" },
                    { 45, "Бельгия" },
                    { 46, "Сальвадор" },
                    { 47, "Исландия" },
                    { 48, "Венгрия" },
                    { 49, "Корея Южная" },
                    { 50, "Лихтенштейн" },
                    { 51, "Болгария" },
                    { 52, "Филиппины" },
                    { 53, "Доминикана" },
                    { 54, "" },
                    { 55, "Марокко" },
                    { 56, "Таиланд" },
                    { 57, "Кения" },
                    { 58, "Пакистан" },
                    { 59, "Иран" },
                    { 60, "Панама" },
                    { 61, "Аруба" },
                    { 62, "Ямайка" },
                    { 63, "Греция" },
                    { 64, "Тунис" },
                    { 65, "Кыргызстан" },
                    { 66, "Пуэрто Рико" },
                    { 67, "Казахстан" },
                    { 68, "Югославия (ФР)" },
                    { 69, "Алжир" },
                    { 70, "Германия (ГДР)" },
                    { 71, "Сингапур" },
                    { 72, "Словакия" },
                    { 73, "Афганистан" },
                    { 74, "Индонезия" },
                    { 75, "Перу" },
                    { 76, "Бермуды" },
                    { 77, "Монако" },
                    { 78, "Зимбабве" },
                    { 79, "Вьетнам" },
                    { 80, "Антильские Острова" },
                    { 81, "Саудовская Аравия" },
                    { 82, "Танзания" },
                    { 83, "Ливия" },
                    { 84, "Ливан" },
                    { 85, "Кувейт" },
                    { 86, "Египет" },
                    { 87, "Литва" },
                    { 88, "Венесуэла" },
                    { 89, "Словения" },
                    { 90, "Чили" },
                    { 91, "Багамы" },
                    { 92, "Эквадор" },
                    { 93, "Коста-Рика" },
                    { 94, "Кипр" },
                    { 95, "Уругвай" },
                    { 96, "Ирак" },
                    { 97, "Мартиника" },
                    { 98, "Эстония" },
                    { 99, "ОАЭ" },
                    { 100, "Бангладеш" },
                    { 101, "Македония" },
                    { 102, "Гвинея" },
                    { 103, "Иордания" },
                    { 104, "Латвия" },
                    { 105, "Армения" },
                    { 106, "Украина" },
                    { 107, "Сирия" },
                    { 108, "Шри-Ланка" },
                    { 109, "Нигерия" },
                    { 110, "Берег Слоновой кости" },
                    { 111, "Грузия" },
                    { 112, "Сенегал" },
                    { 113, "Монголия" },
                    { 114, "Габон" },
                    { 115, "Замбия" },
                    { 116, "Албания" },
                    { 117, "Камерун" },
                    { 118, "Буркина-Фасо" },
                    { 119, "Узбекистан" },
                    { 120, "Малайзия" },
                    { 121, "Сербия" },
                    { 122, "Гана" },
                    { 123, "Таджикистан" },
                    { 124, "Гаити" },
                    { 125, "Конго (ДРК)" },
                    { 126, "Гватемала" },
                    { 127, "Российская империя" },
                    { 128, "Беларусь" },
                    { 129, "Молдова" },
                    { 130, "Азербайджан" },
                    { 131, "Палестина" },
                    { 132, "Оккупированная Палестинская территория" },
                    { 133, "Корея Северная" },
                    { 134, "Никарагуа" },
                    { 135, "Камбоджа" },
                    { 136, "Ангола" },
                    { 137, "Сербия и Черногория" },
                    { 138, "Непал" },
                    { 139, "Бенин" },
                    { 140, "Гваделупа" },
                    { 141, "Гренландия" },
                    { 142, "Гвинея-Бисау" },
                    { 143, "Макао" },
                    { 144, "Парагвай" },
                    { 145, "Мавритания" },
                    { 146, "Руанда" },
                    { 147, "Фарерские острова" },
                    { 148, "Кот-д’Ивуар" },
                    { 149, "Гибралтар" },
                    { 150, "Ботсвана" },
                    { 151, "Боливия" },
                    { 152, "Мадагаскар" },
                    { 153, "Кабо-Верде" },
                    { 154, "Чад" },
                    { 155, "Мали" },
                    { 156, "Фиджи" },
                    { 157, "Бутан" },
                    { 158, "Барбадос" },
                    { 159, "Тринидад и Тобаго" },
                    { 160, "Мозамбик" },
                    { 161, "Заир" },
                    { 162, "Андорра" },
                    { 163, "Туркменистан" },
                    { 164, "Гайана" },
                    { 165, "Корея" },
                    { 166, "Нигер" },
                    { 167, "Конго" },
                    { 168, "Того" },
                    { 169, "Ватикан" },
                    { 170, "Черногория" },
                    { 171, "Бурунди" },
                    { 172, "Папуа - Новая Гвинея" },
                    { 173, "Бахрейн" },
                    { 174, "Гондурас" },
                    { 175, "Судан" },
                    { 176, "Эфиопия" },
                    { 177, "Йемен" },
                    { 178, "Вьетнам Северный" },
                    { 179, "Суринам" },
                    { 180, "Маврикий" },
                    { 181, "Белиз" },
                    { 182, "Либерия" },
                    { 183, "Лесото" },
                    { 184, "Уганда" },
                    { 185, "Каймановы острова" },
                    { 186, "Антигуа и Барбуда" },
                    { 187, "Западная Сахара" },
                    { 188, "Сан-Марино" },
                    { 189, "Гуам" },
                    { 190, "Косово" },
                    { 191, "Лаос" },
                    { 192, "Катар" },
                    { 193, "Оман" },
                    { 194, "Американские Виргинские острова" },
                    { 195, "Сиам" },
                    { 196, "Сьерра-Леоне" },
                    { 197, "Эритрея" },
                    { 198, "Сомали" },
                    { 199, "Доминика" },
                    { 200, "Бирма" },
                    { 201, "Реюньон" },
                    { 202, "Федеративные Штаты Микронезии" },
                    { 203, "Самоа" },
                    { 204, "Американское Самоа" },
                    { 205, "Свазиленд" },
                    { 206, "Французская Полинезия" },
                    { 207, "Мьянма" },
                    { 208, "Новая Каледония" },
                    { 209, "Французская Гвиана" },
                    { 210, "Сент-Винсент и Гренадины" },
                    { 211, "Малави" },
                    { 212, "Экваториальная Гвинея" },
                    { 213, "Коморы" },
                    { 214, "Кирибати" },
                    { 215, "Тувалу" },
                    { 216, "Тимор-Лесте" },
                    { 217, "ЦАР" },
                    { 218, "Тонга" },
                    { 219, "Гренада" },
                    { 220, "Гамбия" },
                    { 221, "Антарктида" },
                    { 222, "Острова Кука" },
                    { 223, "Остров Мэн" },
                    { 224, "Внешние малые острова США" },
                    { 225, "Монтсеррат" },
                    { 226, "Маршалловы острова" },
                    { 227, "Бруней-Даруссалам" },
                    { 228, "Сейшельские острова" },
                    { 229, "Палау" },
                    { 230, "Сент-Люсия" },
                    { 231, "Вануату" },
                    { 232, "Мальдивы" },
                    { 233, "Босния" },
                    { 234, "Уоллис и Футуна" },
                    { 235, "Белоруссия" },
                    { 236, "Киргизия" },
                    { 239, "Джибути" },
                    { 240, "Виргинские Острова (США)" },
                    { 241, "Северная Македония" },
                    { 242, "Виргинские Острова (Великобритания)" },
                    { 3545269, "Сент-Люсия " },
                    { 3781461, "Сент-Китс и Невис" },
                    { 3985922, "Соломоновы Острова" },
                    { 4336645, "Виргинские Острова" },
                    { 7801402, "Фолклендские острова" },
                    { 10842163, "Остров Святой Елены" },
                    { 32518739, "острова Теркс и Кайкос" },
                    { 47738117, "Мелкие отдаленные острова США" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "триллер" },
                    { 2, "драма" },
                    { 3, "криминал" },
                    { 4, "мелодрама" },
                    { 5, "детектив" },
                    { 6, "фантастика" },
                    { 7, "приключения" },
                    { 8, "биография" },
                    { 9, "фильм-нуар" },
                    { 10, "вестерн" },
                    { 11, "боевик" },
                    { 12, "фэнтези" },
                    { 13, "комедия" },
                    { 14, "военный" },
                    { 15, "история" },
                    { 16, "музыка" },
                    { 17, "ужасы" },
                    { 18, "мультфильм" },
                    { 19, "семейный" },
                    { 20, "мюзикл" },
                    { 21, "спорт" },
                    { 22, "документальный" },
                    { 23, "короткометражка" },
                    { 24, "аниме" },
                    { 25, "" },
                    { 26, "новости" },
                    { 27, "концерт" },
                    { 28, "для взрослых" },
                    { 29, "церемония" },
                    { 30, "реальное ТВ" },
                    { 31, "игра" },
                    { 32, "ток-шоу" },
                    { 33, "детский" }
                });

            migrationBuilder.CreateTable(
                name: "MoviePageItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KinopoiskId = table.Column<int>(type: "int", nullable: false),
                    ImdbId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    NameRu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NameEn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NameOriginal = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RatingKinopoisk = table.Column<float>(type: "real", nullable: true),
                    RatingImdb = table.Column<float>(type: "real", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    PosterUrl = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    PosterUrlPreview = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoviePageItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MoviesPages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameRu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NameEn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    KinopoiskId = table.Column<int>(type: "int", nullable: false),
                    ImdbId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Slogan = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    ShortDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    PosterUrl = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    RatingKinopoisk = table.Column<float>(type: "real", nullable: true),
                    RatingImdb = table.Column<float>(type: "real", nullable: true),
                    WebUrl = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Year = table.Column<int>(type: "int", nullable: true),
                    FilmLenght = table.Column<int>(type: "int", nullable: true),
                    EditorAnnotation = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    RatingAgeLimits = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoviesPages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CountryMoviePageItem",
                columns: table => new
                {
                    CountriesId = table.Column<int>(type: "int", nullable: false),
                    MoviePageItemsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryMoviePageItem", x => new { x.CountriesId, x.MoviePageItemsId });
                    table.ForeignKey(
                        name: "FK_CountryMoviePageItem_Countries_CountriesId",
                        column: x => x.CountriesId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CountryMoviePageItem_MoviePageItems_MoviePageItemsId",
                        column: x => x.MoviePageItemsId,
                        principalTable: "MoviePageItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GenreMoviePageItem",
                columns: table => new
                {
                    GenresId = table.Column<int>(type: "int", nullable: false),
                    MoviePageItemsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenreMoviePageItem", x => new { x.GenresId, x.MoviePageItemsId });
                    table.ForeignKey(
                        name: "FK_GenreMoviePageItem_Genres_GenresId",
                        column: x => x.GenresId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenreMoviePageItem_MoviePageItems_MoviePageItemsId",
                        column: x => x.MoviePageItemsId,
                        principalTable: "MoviePageItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CountryMoviePage",
                columns: table => new
                {
                    CountriesId = table.Column<int>(type: "int", nullable: false),
                    MoviesPagesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryMoviePage", x => new { x.CountriesId, x.MoviesPagesId });
                    table.ForeignKey(
                        name: "FK_CountryMoviePage_Countries_CountriesId",
                        column: x => x.CountriesId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CountryMoviePage_MoviesPages_MoviesPagesId",
                        column: x => x.MoviesPagesId,
                        principalTable: "MoviesPages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GenreMoviePage",
                columns: table => new
                {
                    GenresId = table.Column<int>(type: "int", nullable: false),
                    MoviesPagesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenreMoviePage", x => new { x.GenresId, x.MoviesPagesId });
                    table.ForeignKey(
                        name: "FK_GenreMoviePage_Genres_GenresId",
                        column: x => x.GenresId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenreMoviePage_MoviesPages_MoviesPagesId",
                        column: x => x.MoviesPagesId,
                        principalTable: "MoviesPages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CountryMoviePage_MoviesPagesId",
                table: "CountryMoviePage",
                column: "MoviesPagesId");

            migrationBuilder.CreateIndex(
                name: "IX_CountryMoviePageItem_MoviePageItemsId",
                table: "CountryMoviePageItem",
                column: "MoviePageItemsId");

            migrationBuilder.CreateIndex(
                name: "IX_GenreMoviePage_MoviesPagesId",
                table: "GenreMoviePage",
                column: "MoviesPagesId");

            migrationBuilder.CreateIndex(
                name: "IX_GenreMoviePageItem_MoviePageItemsId",
                table: "GenreMoviePageItem",
                column: "MoviePageItemsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_MoviesPages_MovieId",
                table: "Ratings",
                column: "MovieId",
                principalTable: "MoviesPages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_MoviesPages_MovieId",
                table: "Ratings");

            migrationBuilder.DropTable(
                name: "CountryMoviePage");

            migrationBuilder.DropTable(
                name: "CountryMoviePageItem");

            migrationBuilder.DropTable(
                name: "GenreMoviePage");

            migrationBuilder.DropTable(
                name: "GenreMoviePageItem");

            migrationBuilder.DropTable(
                name: "MoviesPages");

            migrationBuilder.DropTable(
                name: "MoviePageItems");

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    EditorAnnotation = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    FilmLenght = table.Column<int>(type: "int", nullable: true),
                    ImdbId = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    KinopoiskId = table.Column<int>(type: "int", nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NameRu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PosterUrl = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    RatingAgeLimits = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    RatingImdb = table.Column<float>(type: "real", nullable: true),
                    RatingKinopoisk = table.Column<float>(type: "real", nullable: true),
                    ShortDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Slogan = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    WebUrl = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Year = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CountryMovie",
                columns: table => new
                {
                    CountriesId = table.Column<int>(type: "int", nullable: false),
                    MoviesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryMovie", x => new { x.CountriesId, x.MoviesId });
                    table.ForeignKey(
                        name: "FK_CountryMovie_Countries_CountriesId",
                        column: x => x.CountriesId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CountryMovie_Movies_MoviesId",
                        column: x => x.MoviesId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GenreMovie",
                columns: table => new
                {
                    GenresId = table.Column<int>(type: "int", nullable: false),
                    MoviesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenreMovie", x => new { x.GenresId, x.MoviesId });
                    table.ForeignKey(
                        name: "FK_GenreMovie_Genres_GenresId",
                        column: x => x.GenresId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenreMovie_Movies_MoviesId",
                        column: x => x.MoviesId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "США" },
                    { 2, "Швейцария" },
                    { 3, "Франция" },
                    { 4, "Польша" },
                    { 5, "Великобритания" },
                    { 6, "Швеция" },
                    { 7, "Индия" },
                    { 8, "Испания" },
                    { 9, "Германия" },
                    { 10, "Италия" },
                    { 11, "Гонконг" },
                    { 12, "Германия (ФРГ)" },
                    { 13, "Австралия" },
                    { 14, "Канада" },
                    { 15, "Мексика" },
                    { 16, "Япония" },
                    { 17, "Дания" },
                    { 18, "Чехия" },
                    { 19, "Ирландия" },
                    { 20, "Люксембург" },
                    { 21, "Китай" },
                    { 22, "Норвегия" },
                    { 23, "Нидерланды" },
                    { 24, "Аргентина" },
                    { 25, "Финляндия" },
                    { 26, "Босния и Герцеговина" },
                    { 27, "Австрия" },
                    { 28, "Тайвань" },
                    { 29, "Новая Зеландия" },
                    { 30, "Бразилия" },
                    { 31, "Чехословакия" },
                    { 32, "Мальта" },
                    { 33, "СССР" },
                    { 34, "Россия" },
                    { 35, "Югославия" },
                    { 36, "Португалия" },
                    { 37, "Румыния" },
                    { 38, "Хорватия" },
                    { 39, "ЮАР" },
                    { 40, "Куба" },
                    { 41, "Колумбия" },
                    { 42, "Израиль" },
                    { 43, "Намибия" },
                    { 44, "Турция" },
                    { 45, "Бельгия" },
                    { 46, "Сальвадор" },
                    { 47, "Исландия" },
                    { 48, "Венгрия" },
                    { 49, "Корея Южная" },
                    { 50, "Лихтенштейн" },
                    { 51, "Болгария" },
                    { 52, "Филиппины" },
                    { 53, "Доминикана" },
                    { 54, "" },
                    { 55, "Марокко" },
                    { 56, "Таиланд" },
                    { 57, "Кения" },
                    { 58, "Пакистан" },
                    { 59, "Иран" },
                    { 60, "Панама" },
                    { 61, "Аруба" },
                    { 62, "Ямайка" },
                    { 63, "Греция" },
                    { 64, "Тунис" },
                    { 65, "Кыргызстан" },
                    { 66, "Пуэрто Рико" },
                    { 67, "Казахстан" },
                    { 68, "Югославия (ФР)" },
                    { 69, "Алжир" },
                    { 70, "Германия (ГДР)" },
                    { 71, "Сингапур" },
                    { 72, "Словакия" },
                    { 73, "Афганистан" },
                    { 74, "Индонезия" },
                    { 75, "Перу" },
                    { 76, "Бермуды" },
                    { 77, "Монако" },
                    { 78, "Зимбабве" },
                    { 79, "Вьетнам" },
                    { 80, "Антильские Острова" },
                    { 81, "Саудовская Аравия" },
                    { 82, "Танзания" },
                    { 83, "Ливия" },
                    { 84, "Ливан" },
                    { 85, "Кувейт" },
                    { 86, "Египет" },
                    { 87, "Литва" },
                    { 88, "Венесуэла" },
                    { 89, "Словения" },
                    { 90, "Чили" },
                    { 91, "Багамы" },
                    { 92, "Эквадор" },
                    { 93, "Коста-Рика" },
                    { 94, "Кипр" },
                    { 95, "Уругвай" },
                    { 96, "Ирак" },
                    { 97, "Мартиника" },
                    { 98, "Эстония" },
                    { 99, "ОАЭ" },
                    { 100, "Бангладеш" },
                    { 101, "Македония" },
                    { 102, "Гвинея" },
                    { 103, "Иордания" },
                    { 104, "Латвия" },
                    { 105, "Армения" },
                    { 106, "Украина" },
                    { 107, "Сирия" },
                    { 108, "Шри-Ланка" },
                    { 109, "Нигерия" },
                    { 110, "Берег Слоновой кости" },
                    { 111, "Грузия" },
                    { 112, "Сенегал" },
                    { 113, "Монголия" },
                    { 114, "Габон" },
                    { 115, "Замбия" },
                    { 116, "Албания" },
                    { 117, "Камерун" },
                    { 118, "Буркина-Фасо" },
                    { 119, "Узбекистан" },
                    { 120, "Малайзия" },
                    { 121, "Сербия" },
                    { 122, "Гана" },
                    { 123, "Таджикистан" },
                    { 124, "Гаити" },
                    { 125, "Конго (ДРК)" },
                    { 126, "Гватемала" },
                    { 127, "Российская империя" },
                    { 128, "Беларусь" },
                    { 129, "Молдова" },
                    { 130, "Азербайджан" },
                    { 131, "Палестина" },
                    { 132, "Оккупированная Палестинская территория" },
                    { 133, "Корея Северная" },
                    { 134, "Никарагуа" },
                    { 135, "Камбоджа" },
                    { 136, "Ангола" },
                    { 137, "Сербия и Черногория" },
                    { 138, "Непал" },
                    { 139, "Бенин" },
                    { 140, "Гваделупа" },
                    { 141, "Гренландия" },
                    { 142, "Гвинея-Бисау" },
                    { 143, "Макао" },
                    { 144, "Парагвай" },
                    { 145, "Мавритания" },
                    { 146, "Руанда" },
                    { 147, "Фарерские острова" },
                    { 148, "Кот-д’Ивуар" },
                    { 149, "Гибралтар" },
                    { 150, "Ботсвана" },
                    { 151, "Боливия" },
                    { 152, "Мадагаскар" },
                    { 153, "Кабо-Верде" },
                    { 154, "Чад" },
                    { 155, "Мали" },
                    { 156, "Фиджи" },
                    { 157, "Бутан" },
                    { 158, "Барбадос" },
                    { 159, "Тринидад и Тобаго" },
                    { 160, "Мозамбик" },
                    { 161, "Заир" },
                    { 162, "Андорра" },
                    { 163, "Туркменистан" },
                    { 164, "Гайана" },
                    { 165, "Корея" },
                    { 166, "Нигер" },
                    { 167, "Конго" },
                    { 168, "Того" },
                    { 169, "Ватикан" },
                    { 170, "Черногория" },
                    { 171, "Бурунди" },
                    { 172, "Папуа - Новая Гвинея" },
                    { 173, "Бахрейн" },
                    { 174, "Гондурас" },
                    { 175, "Судан" },
                    { 176, "Эфиопия" },
                    { 177, "Йемен" },
                    { 178, "Вьетнам Северный" },
                    { 179, "Суринам" },
                    { 180, "Маврикий" },
                    { 181, "Белиз" },
                    { 182, "Либерия" },
                    { 183, "Лесото" },
                    { 184, "Уганда" },
                    { 185, "Каймановы острова" },
                    { 186, "Антигуа и Барбуда" },
                    { 187, "Западная Сахара" },
                    { 188, "Сан-Марино" },
                    { 189, "Гуам" },
                    { 190, "Косово" },
                    { 191, "Лаос" },
                    { 192, "Катар" },
                    { 193, "Оман" },
                    { 194, "Американские Виргинские острова" },
                    { 195, "Сиам" },
                    { 196, "Сьерра-Леоне" },
                    { 197, "Эритрея" },
                    { 198, "Сомали" },
                    { 199, "Доминика" },
                    { 200, "Бирма" },
                    { 201, "Реюньон" },
                    { 202, "Федеративные Штаты Микронезии" },
                    { 203, "Самоа" },
                    { 204, "Американское Самоа" },
                    { 205, "Свазиленд" },
                    { 206, "Французская Полинезия" },
                    { 207, "Мьянма" },
                    { 208, "Новая Каледония" },
                    { 209, "Французская Гвиана" },
                    { 210, "Сент-Винсент и Гренадины" },
                    { 211, "Малави" },
                    { 212, "Экваториальная Гвинея" },
                    { 213, "Коморы" },
                    { 214, "Кирибати" },
                    { 215, "Тувалу" },
                    { 216, "Тимор-Лесте" },
                    { 217, "ЦАР" },
                    { 218, "Тонга" },
                    { 219, "Гренада" },
                    { 220, "Гамбия" },
                    { 221, "Антарктида" },
                    { 222, "Острова Кука" },
                    { 223, "Остров Мэн" },
                    { 224, "Внешние малые острова США" },
                    { 225, "Монтсеррат" },
                    { 226, "Маршалловы острова" },
                    { 227, "Бруней-Даруссалам" },
                    { 228, "Сейшельские острова" },
                    { 229, "Палау" },
                    { 230, "Сент-Люсия" },
                    { 231, "Вануату" },
                    { 232, "Мальдивы" },
                    { 233, "Босния" },
                    { 234, "Уоллис и Футуна" },
                    { 235, "Белоруссия" },
                    { 236, "Киргизия" },
                    { 239, "Джибути" },
                    { 240, "Виргинские Острова (США)" },
                    { 241, "Северная Македония" },
                    { 242, "Виргинские Острова (Великобритания)" },
                    { 3545269, "Сент-Люсия " },
                    { 3781461, "Сент-Китс и Невис" },
                    { 3985922, "Соломоновы Острова" },
                    { 4336645, "Виргинские Острова" },
                    { 7801402, "Фолклендские острова" },
                    { 10842163, "Остров Святой Елены" },
                    { 32518739, "острова Теркс и Кайкос" },
                    { 47738117, "Мелкие отдаленные острова США" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "триллер" },
                    { 2, "драма" },
                    { 3, "криминал" },
                    { 4, "мелодрама" },
                    { 5, "детектив" },
                    { 6, "фантастика" },
                    { 7, "приключения" },
                    { 8, "биография" },
                    { 9, "фильм-нуар" },
                    { 10, "вестерн" },
                    { 11, "боевик" },
                    { 12, "фэнтези" },
                    { 13, "комедия" },
                    { 14, "военный" },
                    { 15, "история" },
                    { 16, "музыка" },
                    { 17, "ужасы" },
                    { 18, "мультфильм" },
                    { 19, "семейный" },
                    { 20, "мюзикл" },
                    { 21, "спорт" },
                    { 22, "документальный" },
                    { 23, "короткометражка" },
                    { 24, "аниме" },
                    { 25, "" },
                    { 26, "новости" },
                    { 27, "концерт" },
                    { 28, "для взрослых" },
                    { 29, "церемония" },
                    { 30, "реальное ТВ" },
                    { 31, "игра" },
                    { 32, "ток-шоу" },
                    { 33, "детский" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CountryMovie_MoviesId",
                table: "CountryMovie",
                column: "MoviesId");

            migrationBuilder.CreateIndex(
                name: "IX_GenreMovie_MoviesId",
                table: "GenreMovie",
                column: "MoviesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_Movies_MovieId",
                table: "Ratings",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
