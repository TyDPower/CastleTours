using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CastleTours.Server.Migrations
{
    public partial class LocationCountryCodes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CountryIsoCode",
                table: "Locations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CountryIsoCode",
                table: "Locations");

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 22, 21, 38, 36, 864, DateTimeKind.Local).AddTicks(5905));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 22, 21, 38, 36, 864, DateTimeKind.Local).AddTicks(5909));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 22, 21, 38, 36, 864, DateTimeKind.Local).AddTicks(5912));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 22, 21, 38, 36, 864, DateTimeKind.Local).AddTicks(5914));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 22, 21, 38, 36, 864, DateTimeKind.Local).AddTicks(5916));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 22, 21, 38, 36, 864, DateTimeKind.Local).AddTicks(5918));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 22, 21, 38, 36, 864, DateTimeKind.Local).AddTicks(5921));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 22, 21, 38, 36, 864, DateTimeKind.Local).AddTicks(5923));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 2, 22, 21, 38, 36, 864, DateTimeKind.Local).AddTicks(5839));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 2, 22, 21, 38, 36, 864, DateTimeKind.Local).AddTicks(5845));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 2, 22, 21, 38, 36, 864, DateTimeKind.Local).AddTicks(5849));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 2, 22, 21, 38, 36, 864, DateTimeKind.Local).AddTicks(5852));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 2, 22, 21, 38, 36, 864, DateTimeKind.Local).AddTicks(5855));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 2, 22, 21, 38, 36, 864, DateTimeKind.Local).AddTicks(5858));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 22, 21, 38, 36, 864, DateTimeKind.Local).AddTicks(5979));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 22, 21, 38, 36, 864, DateTimeKind.Local).AddTicks(5982));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 22, 21, 38, 36, 864, DateTimeKind.Local).AddTicks(5984));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 22, 21, 38, 36, 864, DateTimeKind.Local).AddTicks(5987));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 22, 21, 38, 36, 864, DateTimeKind.Local).AddTicks(5989));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 22, 21, 38, 36, 864, DateTimeKind.Local).AddTicks(5992));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 22, 21, 38, 36, 864, DateTimeKind.Local).AddTicks(5994));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 22, 21, 38, 36, 864, DateTimeKind.Local).AddTicks(5997));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 22, 21, 38, 36, 864, DateTimeKind.Local).AddTicks(5999));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 22, 21, 38, 36, 864, DateTimeKind.Local).AddTicks(6001));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 22, 21, 38, 36, 864, DateTimeKind.Local).AddTicks(6004));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 22, 21, 38, 36, 864, DateTimeKind.Local).AddTicks(6006));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 2, 22, 21, 38, 36, 864, DateTimeKind.Local).AddTicks(5754));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 2, 22, 21, 38, 36, 864, DateTimeKind.Local).AddTicks(5795));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 2, 22, 21, 38, 36, 864, DateTimeKind.Local).AddTicks(5799));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 2, 22, 21, 38, 36, 864, DateTimeKind.Local).AddTicks(5803));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 2, 22, 21, 38, 36, 864, DateTimeKind.Local).AddTicks(5806));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 2, 22, 21, 38, 36, 864, DateTimeKind.Local).AddTicks(5809));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 2, 22, 21, 38, 36, 864, DateTimeKind.Local).AddTicks(5812));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 2, 22, 21, 38, 36, 864, DateTimeKind.Local).AddTicks(5815));
        }
    }
}
