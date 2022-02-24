using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CastleTours.Server.Migrations
{
    public partial class LocationCountryCodesUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 24, 14, 32, 47, 423, DateTimeKind.Local).AddTicks(9810));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 24, 14, 32, 47, 423, DateTimeKind.Local).AddTicks(9815));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 24, 14, 32, 47, 423, DateTimeKind.Local).AddTicks(9817));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 24, 14, 32, 47, 423, DateTimeKind.Local).AddTicks(9820));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 24, 14, 32, 47, 423, DateTimeKind.Local).AddTicks(9822));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 24, 14, 32, 47, 423, DateTimeKind.Local).AddTicks(9825));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 24, 14, 32, 47, 423, DateTimeKind.Local).AddTicks(9861));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 24, 14, 32, 47, 423, DateTimeKind.Local).AddTicks(9864));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 2, 24, 14, 32, 47, 423, DateTimeKind.Local).AddTicks(9748));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 2, 24, 14, 32, 47, 423, DateTimeKind.Local).AddTicks(9755));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 2, 24, 14, 32, 47, 423, DateTimeKind.Local).AddTicks(9758));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 2, 24, 14, 32, 47, 423, DateTimeKind.Local).AddTicks(9761));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 2, 24, 14, 32, 47, 423, DateTimeKind.Local).AddTicks(9764));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 2, 24, 14, 32, 47, 423, DateTimeKind.Local).AddTicks(9768));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CountryIsoCode",
                value: "gb");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CountryIsoCode",
                value: "gb");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CountryIsoCode",
                value: "gb");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CountryIsoCode",
                value: "gb");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CountryIsoCode",
                value: "gb");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CountryIsoCode",
                value: "gb");

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 24, 14, 32, 47, 423, DateTimeKind.Local).AddTicks(9885));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 24, 14, 32, 47, 423, DateTimeKind.Local).AddTicks(9889));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 24, 14, 32, 47, 423, DateTimeKind.Local).AddTicks(9892));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 24, 14, 32, 47, 423, DateTimeKind.Local).AddTicks(9895));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 24, 14, 32, 47, 423, DateTimeKind.Local).AddTicks(9897));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 24, 14, 32, 47, 423, DateTimeKind.Local).AddTicks(9899));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 24, 14, 32, 47, 423, DateTimeKind.Local).AddTicks(9902));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 24, 14, 32, 47, 423, DateTimeKind.Local).AddTicks(9904));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 24, 14, 32, 47, 423, DateTimeKind.Local).AddTicks(9907));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 24, 14, 32, 47, 423, DateTimeKind.Local).AddTicks(9909));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 24, 14, 32, 47, 423, DateTimeKind.Local).AddTicks(9911));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 24, 14, 32, 47, 423, DateTimeKind.Local).AddTicks(9914));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 2, 24, 14, 32, 47, 423, DateTimeKind.Local).AddTicks(9667));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 2, 24, 14, 32, 47, 423, DateTimeKind.Local).AddTicks(9704));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 2, 24, 14, 32, 47, 423, DateTimeKind.Local).AddTicks(9708));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 2, 24, 14, 32, 47, 423, DateTimeKind.Local).AddTicks(9712));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 2, 24, 14, 32, 47, 423, DateTimeKind.Local).AddTicks(9715));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 2, 24, 14, 32, 47, 423, DateTimeKind.Local).AddTicks(9718));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 2, 24, 14, 32, 47, 423, DateTimeKind.Local).AddTicks(9721));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 2, 24, 14, 32, 47, 423, DateTimeKind.Local).AddTicks(9725));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 24, 14, 26, 44, 546, DateTimeKind.Local).AddTicks(7425));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 24, 14, 26, 44, 546, DateTimeKind.Local).AddTicks(7429));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 24, 14, 26, 44, 546, DateTimeKind.Local).AddTicks(7432));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 24, 14, 26, 44, 546, DateTimeKind.Local).AddTicks(7434));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 24, 14, 26, 44, 546, DateTimeKind.Local).AddTicks(7436));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 24, 14, 26, 44, 546, DateTimeKind.Local).AddTicks(7439));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 24, 14, 26, 44, 546, DateTimeKind.Local).AddTicks(7441));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 24, 14, 26, 44, 546, DateTimeKind.Local).AddTicks(7444));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 2, 24, 14, 26, 44, 546, DateTimeKind.Local).AddTicks(7361));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 2, 24, 14, 26, 44, 546, DateTimeKind.Local).AddTicks(7368));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 2, 24, 14, 26, 44, 546, DateTimeKind.Local).AddTicks(7371));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 2, 24, 14, 26, 44, 546, DateTimeKind.Local).AddTicks(7375));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 2, 24, 14, 26, 44, 546, DateTimeKind.Local).AddTicks(7378));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 2, 24, 14, 26, 44, 546, DateTimeKind.Local).AddTicks(7381));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CountryIsoCode",
                value: "GB");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CountryIsoCode",
                value: "GB");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CountryIsoCode",
                value: "GB");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CountryIsoCode",
                value: "GB");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CountryIsoCode",
                value: "GB");

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CountryIsoCode",
                value: "GB");

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 24, 14, 26, 44, 546, DateTimeKind.Local).AddTicks(7462));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 24, 14, 26, 44, 546, DateTimeKind.Local).AddTicks(7466));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 24, 14, 26, 44, 546, DateTimeKind.Local).AddTicks(7468));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 24, 14, 26, 44, 546, DateTimeKind.Local).AddTicks(7471));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 24, 14, 26, 44, 546, DateTimeKind.Local).AddTicks(7473));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 24, 14, 26, 44, 546, DateTimeKind.Local).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 24, 14, 26, 44, 546, DateTimeKind.Local).AddTicks(7478));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 24, 14, 26, 44, 546, DateTimeKind.Local).AddTicks(7481));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 24, 14, 26, 44, 546, DateTimeKind.Local).AddTicks(7483));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 24, 14, 26, 44, 546, DateTimeKind.Local).AddTicks(7486));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 24, 14, 26, 44, 546, DateTimeKind.Local).AddTicks(7488));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 24, 14, 26, 44, 546, DateTimeKind.Local).AddTicks(7491));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 2, 24, 14, 26, 44, 546, DateTimeKind.Local).AddTicks(7203));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 2, 24, 14, 26, 44, 546, DateTimeKind.Local).AddTicks(7246));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 2, 24, 14, 26, 44, 546, DateTimeKind.Local).AddTicks(7251));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 2, 24, 14, 26, 44, 546, DateTimeKind.Local).AddTicks(7254));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 2, 24, 14, 26, 44, 546, DateTimeKind.Local).AddTicks(7257));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 2, 24, 14, 26, 44, 546, DateTimeKind.Local).AddTicks(7329));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 2, 24, 14, 26, 44, 546, DateTimeKind.Local).AddTicks(7333));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 2, 24, 14, 26, 44, 546, DateTimeKind.Local).AddTicks(7337));
        }
    }
}
