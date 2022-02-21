using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CastleTours.Server.Migrations
{
    public partial class Stats : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Visits = table.Column<int>(type: "int", nullable: false),
                    LastVisit = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stats", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 21, 9, 19, 12, 890, DateTimeKind.Local).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 21, 9, 19, 12, 890, DateTimeKind.Local).AddTicks(756));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 21, 9, 19, 12, 890, DateTimeKind.Local).AddTicks(759));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 21, 9, 19, 12, 890, DateTimeKind.Local).AddTicks(761));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 21, 9, 19, 12, 890, DateTimeKind.Local).AddTicks(763));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 21, 9, 19, 12, 890, DateTimeKind.Local).AddTicks(766));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 21, 9, 19, 12, 890, DateTimeKind.Local).AddTicks(768));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 21, 9, 19, 12, 890, DateTimeKind.Local).AddTicks(771));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 2, 21, 9, 19, 12, 890, DateTimeKind.Local).AddTicks(686));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 2, 21, 9, 19, 12, 890, DateTimeKind.Local).AddTicks(692));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 2, 21, 9, 19, 12, 890, DateTimeKind.Local).AddTicks(696));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 2, 21, 9, 19, 12, 890, DateTimeKind.Local).AddTicks(699));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 2, 21, 9, 19, 12, 890, DateTimeKind.Local).AddTicks(702));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 2, 21, 9, 19, 12, 890, DateTimeKind.Local).AddTicks(705));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 21, 9, 19, 12, 890, DateTimeKind.Local).AddTicks(790));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 21, 9, 19, 12, 890, DateTimeKind.Local).AddTicks(794));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 21, 9, 19, 12, 890, DateTimeKind.Local).AddTicks(797));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 21, 9, 19, 12, 890, DateTimeKind.Local).AddTicks(799));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 21, 9, 19, 12, 890, DateTimeKind.Local).AddTicks(802));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 21, 9, 19, 12, 890, DateTimeKind.Local).AddTicks(804));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 21, 9, 19, 12, 890, DateTimeKind.Local).AddTicks(807));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 21, 9, 19, 12, 890, DateTimeKind.Local).AddTicks(809));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 21, 9, 19, 12, 890, DateTimeKind.Local).AddTicks(812));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 21, 9, 19, 12, 890, DateTimeKind.Local).AddTicks(814));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 21, 9, 19, 12, 890, DateTimeKind.Local).AddTicks(817));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 21, 9, 19, 12, 890, DateTimeKind.Local).AddTicks(819));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 2, 21, 9, 19, 12, 890, DateTimeKind.Local).AddTicks(598));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 2, 21, 9, 19, 12, 890, DateTimeKind.Local).AddTicks(639));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 2, 21, 9, 19, 12, 890, DateTimeKind.Local).AddTicks(643));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 2, 21, 9, 19, 12, 890, DateTimeKind.Local).AddTicks(647));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 2, 21, 9, 19, 12, 890, DateTimeKind.Local).AddTicks(650));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 2, 21, 9, 19, 12, 890, DateTimeKind.Local).AddTicks(653));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 2, 21, 9, 19, 12, 890, DateTimeKind.Local).AddTicks(656));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 2, 21, 9, 19, 12, 890, DateTimeKind.Local).AddTicks(659));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stats");

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 15, 20, 44, 47, 701, DateTimeKind.Local).AddTicks(2059));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 15, 20, 44, 47, 701, DateTimeKind.Local).AddTicks(2063));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 15, 20, 44, 47, 701, DateTimeKind.Local).AddTicks(2066));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 15, 20, 44, 47, 701, DateTimeKind.Local).AddTicks(2069));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 15, 20, 44, 47, 701, DateTimeKind.Local).AddTicks(2071));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 15, 20, 44, 47, 701, DateTimeKind.Local).AddTicks(2074));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 15, 20, 44, 47, 701, DateTimeKind.Local).AddTicks(2076));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 15, 20, 44, 47, 701, DateTimeKind.Local).AddTicks(2079));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 2, 15, 20, 44, 47, 701, DateTimeKind.Local).AddTicks(1995));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 2, 15, 20, 44, 47, 701, DateTimeKind.Local).AddTicks(2001));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 2, 15, 20, 44, 47, 701, DateTimeKind.Local).AddTicks(2005));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 2, 15, 20, 44, 47, 701, DateTimeKind.Local).AddTicks(2008));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 2, 15, 20, 44, 47, 701, DateTimeKind.Local).AddTicks(2011));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 2, 15, 20, 44, 47, 701, DateTimeKind.Local).AddTicks(2014));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 15, 20, 44, 47, 701, DateTimeKind.Local).AddTicks(2098));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 15, 20, 44, 47, 701, DateTimeKind.Local).AddTicks(2102));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 15, 20, 44, 47, 701, DateTimeKind.Local).AddTicks(2104));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 15, 20, 44, 47, 701, DateTimeKind.Local).AddTicks(2107));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 15, 20, 44, 47, 701, DateTimeKind.Local).AddTicks(2110));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 15, 20, 44, 47, 701, DateTimeKind.Local).AddTicks(2112));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 15, 20, 44, 47, 701, DateTimeKind.Local).AddTicks(2115));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 15, 20, 44, 47, 701, DateTimeKind.Local).AddTicks(2117));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 15, 20, 44, 47, 701, DateTimeKind.Local).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 15, 20, 44, 47, 701, DateTimeKind.Local).AddTicks(2122));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 15, 20, 44, 47, 701, DateTimeKind.Local).AddTicks(2125));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 15, 20, 44, 47, 701, DateTimeKind.Local).AddTicks(2128));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 2, 15, 20, 44, 47, 701, DateTimeKind.Local).AddTicks(1901));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 2, 15, 20, 44, 47, 701, DateTimeKind.Local).AddTicks(1944));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 2, 15, 20, 44, 47, 701, DateTimeKind.Local).AddTicks(1947));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 2, 15, 20, 44, 47, 701, DateTimeKind.Local).AddTicks(1950));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 2, 15, 20, 44, 47, 701, DateTimeKind.Local).AddTicks(1953));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 2, 15, 20, 44, 47, 701, DateTimeKind.Local).AddTicks(1956));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 2, 15, 20, 44, 47, 701, DateTimeKind.Local).AddTicks(1959));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 2, 15, 20, 44, 47, 701, DateTimeKind.Local).AddTicks(1969));
        }
    }
}
