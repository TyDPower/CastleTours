using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CastleTours.Server.Migrations
{
    public partial class EdinbrughTourTimes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 1, 10, 1, 57, 521, DateTimeKind.Local).AddTicks(6550));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 1, 10, 1, 57, 521, DateTimeKind.Local).AddTicks(6556));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 1, 10, 1, 57, 521, DateTimeKind.Local).AddTicks(6558));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 1, 10, 1, 57, 521, DateTimeKind.Local).AddTicks(6561));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 1, 10, 1, 57, 521, DateTimeKind.Local).AddTicks(6564));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 1, 10, 1, 57, 521, DateTimeKind.Local).AddTicks(6567));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 1, 10, 1, 57, 521, DateTimeKind.Local).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 1, 10, 1, 57, 521, DateTimeKind.Local).AddTicks(6573));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 1, 10, 1, 57, 521, DateTimeKind.Local).AddTicks(6405));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 1, 10, 1, 57, 521, DateTimeKind.Local).AddTicks(6416));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 1, 10, 1, 57, 521, DateTimeKind.Local).AddTicks(6480));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 3, 1, 10, 1, 57, 521, DateTimeKind.Local).AddTicks(6485));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 3, 1, 10, 1, 57, 521, DateTimeKind.Local).AddTicks(6488));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 3, 1, 10, 1, 57, 521, DateTimeKind.Local).AddTicks(6492));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 3, 1, 10, 1, 57, 521, DateTimeKind.Local).AddTicks(6496));

            migrationBuilder.InsertData(
                table: "OperatingTimes",
                columns: new[] { "Id", "CastleId", "Time", "TourId" },
                values: new object[,]
                {
                    { 33, null, "Mondays - Saturdays 9am - 4pm", 9 },
                    { 34, null, "Sundays 9am - 3pm", 9 }
                });

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 1, 10, 1, 57, 521, DateTimeKind.Local).AddTicks(6595));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 1, 10, 1, 57, 521, DateTimeKind.Local).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 1, 10, 1, 57, 521, DateTimeKind.Local).AddTicks(6603));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 1, 10, 1, 57, 521, DateTimeKind.Local).AddTicks(6606));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 1, 10, 1, 57, 521, DateTimeKind.Local).AddTicks(6609));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 1, 10, 1, 57, 521, DateTimeKind.Local).AddTicks(6612));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 1, 10, 1, 57, 521, DateTimeKind.Local).AddTicks(6615));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 1, 10, 1, 57, 521, DateTimeKind.Local).AddTicks(6618));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 1, 10, 1, 57, 521, DateTimeKind.Local).AddTicks(6621));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 1, 10, 1, 57, 521, DateTimeKind.Local).AddTicks(6624));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 1, 10, 1, 57, 521, DateTimeKind.Local).AddTicks(6627));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 3, 1, 10, 1, 57, 521, DateTimeKind.Local).AddTicks(6629));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 1, 10, 1, 57, 521, DateTimeKind.Local).AddTicks(6305));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 3, 1, 10, 1, 57, 521, DateTimeKind.Local).AddTicks(6348));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 3, 1, 10, 1, 57, 521, DateTimeKind.Local).AddTicks(6353));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 3, 1, 10, 1, 57, 521, DateTimeKind.Local).AddTicks(6357));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 3, 1, 10, 1, 57, 521, DateTimeKind.Local).AddTicks(6361));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 3, 1, 10, 1, 57, 521, DateTimeKind.Local).AddTicks(6364));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 3, 1, 10, 1, 57, 521, DateTimeKind.Local).AddTicks(6368));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 3, 1, 10, 1, 57, 521, DateTimeKind.Local).AddTicks(6372));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 3, 1, 10, 1, 57, 521, DateTimeKind.Local).AddTicks(6376));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OperatingTimes",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "OperatingTimes",
                keyColumn: "Id",
                keyValue: 34);

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

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 3, 1, 9, 59, 28, 128, DateTimeKind.Local).AddTicks(917));

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

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateCreated",
                value: new DateTime(2022, 3, 1, 9, 59, 28, 128, DateTimeKind.Local).AddTicks(868));
        }
    }
}
