using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CastleTours.Server.Migrations
{
    public partial class FavoritesUser1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 3, 23, 6, 8, 516, DateTimeKind.Local).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 3, 23, 6, 8, 516, DateTimeKind.Local).AddTicks(4515));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 3, 23, 6, 8, 516, DateTimeKind.Local).AddTicks(4518));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 3, 23, 6, 8, 516, DateTimeKind.Local).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 3, 23, 6, 8, 516, DateTimeKind.Local).AddTicks(4524));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 3, 23, 6, 8, 516, DateTimeKind.Local).AddTicks(4527));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 3, 23, 6, 8, 516, DateTimeKind.Local).AddTicks(4529));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 3, 23, 6, 8, 516, DateTimeKind.Local).AddTicks(4533));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 3, 23, 6, 8, 516, DateTimeKind.Local).AddTicks(4441));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 3, 23, 6, 8, 516, DateTimeKind.Local).AddTicks(4448));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 3, 23, 6, 8, 516, DateTimeKind.Local).AddTicks(4452));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 3, 3, 23, 6, 8, 516, DateTimeKind.Local).AddTicks(4455));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 3, 3, 23, 6, 8, 516, DateTimeKind.Local).AddTicks(4459));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 3, 3, 23, 6, 8, 516, DateTimeKind.Local).AddTicks(4463));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 3, 3, 23, 6, 8, 516, DateTimeKind.Local).AddTicks(4467));

            migrationBuilder.InsertData(
                table: "Favorites",
                columns: new[] { "Id", "DateFavorited", "TourId", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 3, 3, 23, 6, 8, 516, DateTimeKind.Local).AddTicks(4174), 1, 1 },
                    { 2, new DateTime(2022, 3, 3, 23, 6, 8, 516, DateTimeKind.Local).AddTicks(4207), 5, 1 },
                    { 3, new DateTime(2022, 3, 3, 23, 6, 8, 516, DateTimeKind.Local).AddTicks(4210), 6, 1 },
                    { 4, new DateTime(2022, 3, 3, 23, 6, 8, 516, DateTimeKind.Local).AddTicks(4213), 9, 1 }
                });

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 3, 23, 6, 8, 516, DateTimeKind.Local).AddTicks(4551));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 3, 23, 6, 8, 516, DateTimeKind.Local).AddTicks(4555));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 3, 23, 6, 8, 516, DateTimeKind.Local).AddTicks(4558));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 3, 23, 6, 8, 516, DateTimeKind.Local).AddTicks(4561));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 3, 23, 6, 8, 516, DateTimeKind.Local).AddTicks(4564));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 3, 23, 6, 8, 516, DateTimeKind.Local).AddTicks(4567));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 3, 23, 6, 8, 516, DateTimeKind.Local).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 3, 23, 6, 8, 516, DateTimeKind.Local).AddTicks(4573));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 3, 23, 6, 8, 516, DateTimeKind.Local).AddTicks(4576));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 3, 23, 6, 8, 516, DateTimeKind.Local).AddTicks(4579));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 3, 23, 6, 8, 516, DateTimeKind.Local).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 3, 23, 6, 8, 516, DateTimeKind.Local).AddTicks(4585));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 3, 23, 6, 8, 516, DateTimeKind.Local).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 3, 23, 6, 8, 516, DateTimeKind.Local).AddTicks(4351));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 3, 23, 6, 8, 516, DateTimeKind.Local).AddTicks(4356));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 3, 3, 23, 6, 8, 516, DateTimeKind.Local).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 3, 3, 23, 6, 8, 516, DateTimeKind.Local).AddTicks(4364));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 3, 3, 23, 6, 8, 516, DateTimeKind.Local).AddTicks(4404));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 3, 3, 23, 6, 8, 516, DateTimeKind.Local).AddTicks(4408));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 3, 3, 23, 6, 8, 516, DateTimeKind.Local).AddTicks(4411));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 3, 3, 23, 6, 8, 516, DateTimeKind.Local).AddTicks(4415));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9390));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9395));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9398));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9402));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9404));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9407));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9409));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9313));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9322));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9325));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9328));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9331));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9334));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9337));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9433));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9437));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9439));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9442));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9444));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9446));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9449));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9451));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9453));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9456));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9458));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9460));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9183));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9223));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9227));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9271));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9274));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9277));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9281));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9284));
        }
    }
}
