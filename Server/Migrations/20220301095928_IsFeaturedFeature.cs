using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CastleTours.Server.Migrations
{
    public partial class IsFeaturedFeature : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Blurb",
                table: "Tours",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsFeatured",
                table: "Tours",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 1, 9, 59, 28, 128, DateTimeKind.Local).AddTicks(965));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 1, 9, 59, 28, 128, DateTimeKind.Local).AddTicks(969));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 1, 9, 59, 28, 128, DateTimeKind.Local).AddTicks(971));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 1, 9, 59, 28, 128, DateTimeKind.Local).AddTicks(974));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 1, 9, 59, 28, 128, DateTimeKind.Local).AddTicks(976));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 1, 9, 59, 28, 128, DateTimeKind.Local).AddTicks(978));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 1, 9, 59, 28, 128, DateTimeKind.Local).AddTicks(981));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 1, 9, 59, 28, 128, DateTimeKind.Local).AddTicks(983));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 1, 9, 59, 28, 128, DateTimeKind.Local).AddTicks(895));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 1, 9, 59, 28, 128, DateTimeKind.Local).AddTicks(902));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 1, 9, 59, 28, 128, DateTimeKind.Local).AddTicks(905));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 3, 1, 9, 59, 28, 128, DateTimeKind.Local).AddTicks(908));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 3, 1, 9, 59, 28, 128, DateTimeKind.Local).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 3, 1, 9, 59, 28, 128, DateTimeKind.Local).AddTicks(914));

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Area", "Coordinates", "Country", "CountryIsoCode", "GoogleMapsUrl", "OpenStreetMapUrl", "Postcode", "Region", "Street" },
                values: new object[] { 7, "Edinburgh", "55.948611, -3.200833", "Scotland", "gb", "https://www.google.com/maps/place/55%C2%B056'55.0%22N+3%C2%B012'03.0%22W/@55.948611,-3.200833,15z/data=!4m5!3m4!1s0x0:0x5eaa0460843a6e07!8m2!3d55.948611!4d-3.200833?hl=en", "https://www.openstreetmap.org/?mlat=55.948611&mlon=-3.200833&zoom=15#map=15/55.9486/-3.2008", "EH1 2YT", "", "Castlehill" });

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 1, 9, 59, 28, 128, DateTimeKind.Local).AddTicks(1001));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 1, 9, 59, 28, 128, DateTimeKind.Local).AddTicks(1005));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 1, 9, 59, 28, 128, DateTimeKind.Local).AddTicks(1007));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 1, 9, 59, 28, 128, DateTimeKind.Local).AddTicks(1010));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 1, 9, 59, 28, 128, DateTimeKind.Local).AddTicks(1014));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 1, 9, 59, 28, 128, DateTimeKind.Local).AddTicks(1018));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 1, 9, 59, 28, 128, DateTimeKind.Local).AddTicks(1021));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 1, 9, 59, 28, 128, DateTimeKind.Local).AddTicks(1024));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 1, 9, 59, 28, 128, DateTimeKind.Local).AddTicks(1026));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 1, 9, 59, 28, 128, DateTimeKind.Local).AddTicks(1029));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 1, 9, 59, 28, 128, DateTimeKind.Local).AddTicks(1031));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 1, 9, 59, 28, 128, DateTimeKind.Local).AddTicks(1034));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 1, 9, 59, 28, 128, DateTimeKind.Local).AddTicks(773));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 1, 9, 59, 28, 128, DateTimeKind.Local).AddTicks(812));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 1, 9, 59, 28, 128, DateTimeKind.Local).AddTicks(816));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 3, 1, 9, 59, 28, 128, DateTimeKind.Local).AddTicks(852));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 3, 1, 9, 59, 28, 128, DateTimeKind.Local).AddTicks(856));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 3, 1, 9, 59, 28, 128, DateTimeKind.Local).AddTicks(859));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 3, 1, 9, 59, 28, 128, DateTimeKind.Local).AddTicks(862));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 3, 1, 9, 59, 28, 128, DateTimeKind.Local).AddTicks(865));

            migrationBuilder.InsertData(
                table: "Castles",
                columns: new[] { "Id", "CategoryId", "Condition", "Date", "DateCreated", "DateUpdated", "Description", "EnteranceFee", "EnteranceFeeSpecial", "ImgUrl", "IsDeleted", "IsOpenToPublic", "IsPublic", "LocationId", "Name", "Summary", "Type", "WikiUrl" },
                values: new object[] { 7, 1, "Intact", "11th - 21st Centuries", new DateTime(2022, 3, 1, 9, 59, 28, 128, DateTimeKind.Local).AddTicks(917), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site of a castle since the 12th century, Edinburgh Castle contains buildings of multiple periods and functions, including the royal palace, great hall, and 19th-century barracks.", 18.00m, 0m, "https://upload.wikimedia.org/wikipedia/commons/4/4b/Peckforton_Castle_1.jpg", false, false, false, 7, "Edinburgh Castle", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer pharetra viverra mattis.", "Royal fortress", "https://en.wikipedia.org/wiki/Peckforton_Castle" });

            migrationBuilder.InsertData(
                table: "Tours",
                columns: new[] { "Id", "Blurb", "CastleId", "CategoryId", "DateCreated", "DateUpdated", "Description", "ImgUrl", "IsDeleted", "IsFeatured", "IsOperating", "IsPublic", "Name", "Price", "SpecialPrice" },
                values: new object[] { 9, "Explore the most besieged castle in Eorupe!", 7, 2, new DateTime(2022, 3, 1, 9, 59, 28, 128, DateTimeKind.Local).AddTicks(868), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This tour is part of the National Heritage English History Tour. Its aimed at children 12 to 17 but adult are welcome to learn with us.", "https://th.bing.com/th/id/R.bb550545afd48d8ae77307363370a55d?rik=ZzKNsIDOcO3tPg&riu=http%3a%2f%2fwallup.net%2fwp-content%2fuploads%2f2016%2f01%2f207095-landscape-castle-Edinburgh-Scotland-UK.jpg&ehk=8eM1O612fOuUrOp1Aa9KhN03%2flt1%2fx6YcdNHavii6DA%3d&risl=&pid=ImgRaw&r=0", false, true, true, true, "The Besieged Tour", 32m, 25m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DropColumn(
                name: "Blurb",
                table: "Tours");

            migrationBuilder.DropColumn(
                name: "IsFeatured",
                table: "Tours");

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
    }
}
