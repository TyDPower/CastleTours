using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CastleTours.Server.Migrations
{
    public partial class FacilitySeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "CastleFacility",
                columns: new[] { "CastlesId", "FacilitiesId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 2, 1 },
                    { 2, 4 },
                    { 2, 5 },
                    { 3, 2 },
                    { 3, 3 },
                    { 4, 1 },
                    { 4, 2 },
                    { 4, 4 },
                    { 4, 5 },
                    { 5, 3 },
                    { 5, 4 }
                });

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

            migrationBuilder.InsertData(
                table: "FacilityTour",
                columns: new[] { "FacilitiesId", "ToursId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 4 },
                    { 2, 1 },
                    { 2, 3 },
                    { 2, 4 },
                    { 3, 1 },
                    { 3, 3 },
                    { 3, 5 },
                    { 4, 2 },
                    { 4, 4 },
                    { 4, 6 },
                    { 5, 2 },
                    { 5, 4 }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CastleFacility",
                keyColumns: new[] { "CastlesId", "FacilitiesId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "CastleFacility",
                keyColumns: new[] { "CastlesId", "FacilitiesId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "CastleFacility",
                keyColumns: new[] { "CastlesId", "FacilitiesId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "CastleFacility",
                keyColumns: new[] { "CastlesId", "FacilitiesId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "CastleFacility",
                keyColumns: new[] { "CastlesId", "FacilitiesId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "CastleFacility",
                keyColumns: new[] { "CastlesId", "FacilitiesId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "CastleFacility",
                keyColumns: new[] { "CastlesId", "FacilitiesId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "CastleFacility",
                keyColumns: new[] { "CastlesId", "FacilitiesId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "CastleFacility",
                keyColumns: new[] { "CastlesId", "FacilitiesId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "CastleFacility",
                keyColumns: new[] { "CastlesId", "FacilitiesId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "CastleFacility",
                keyColumns: new[] { "CastlesId", "FacilitiesId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "CastleFacility",
                keyColumns: new[] { "CastlesId", "FacilitiesId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "CastleFacility",
                keyColumns: new[] { "CastlesId", "FacilitiesId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "CastleFacility",
                keyColumns: new[] { "CastlesId", "FacilitiesId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "FacilityTour",
                keyColumns: new[] { "FacilitiesId", "ToursId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "FacilityTour",
                keyColumns: new[] { "FacilitiesId", "ToursId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "FacilityTour",
                keyColumns: new[] { "FacilitiesId", "ToursId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "FacilityTour",
                keyColumns: new[] { "FacilitiesId", "ToursId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "FacilityTour",
                keyColumns: new[] { "FacilitiesId", "ToursId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "FacilityTour",
                keyColumns: new[] { "FacilitiesId", "ToursId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "FacilityTour",
                keyColumns: new[] { "FacilitiesId", "ToursId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "FacilityTour",
                keyColumns: new[] { "FacilitiesId", "ToursId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "FacilityTour",
                keyColumns: new[] { "FacilitiesId", "ToursId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "FacilityTour",
                keyColumns: new[] { "FacilitiesId", "ToursId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "FacilityTour",
                keyColumns: new[] { "FacilitiesId", "ToursId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "FacilityTour",
                keyColumns: new[] { "FacilitiesId", "ToursId" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "FacilityTour",
                keyColumns: new[] { "FacilitiesId", "ToursId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "FacilityTour",
                keyColumns: new[] { "FacilitiesId", "ToursId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 15, 20, 39, 30, 786, DateTimeKind.Local).AddTicks(9051));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 15, 20, 39, 30, 786, DateTimeKind.Local).AddTicks(9056));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 15, 20, 39, 30, 786, DateTimeKind.Local).AddTicks(9059));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 15, 20, 39, 30, 786, DateTimeKind.Local).AddTicks(9061));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 15, 20, 39, 30, 786, DateTimeKind.Local).AddTicks(9064));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 15, 20, 39, 30, 786, DateTimeKind.Local).AddTicks(9066));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 15, 20, 39, 30, 786, DateTimeKind.Local).AddTicks(9069));

            migrationBuilder.UpdateData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 15, 20, 39, 30, 786, DateTimeKind.Local).AddTicks(9071));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 2, 15, 20, 39, 30, 786, DateTimeKind.Local).AddTicks(8984));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 2, 15, 20, 39, 30, 786, DateTimeKind.Local).AddTicks(8991));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 2, 15, 20, 39, 30, 786, DateTimeKind.Local).AddTicks(8995));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 2, 15, 20, 39, 30, 786, DateTimeKind.Local).AddTicks(8998));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 2, 15, 20, 39, 30, 786, DateTimeKind.Local).AddTicks(9001));

            migrationBuilder.UpdateData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 2, 15, 20, 39, 30, 786, DateTimeKind.Local).AddTicks(9004));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 15, 20, 39, 30, 786, DateTimeKind.Local).AddTicks(9087));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 15, 20, 39, 30, 786, DateTimeKind.Local).AddTicks(9091));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 15, 20, 39, 30, 786, DateTimeKind.Local).AddTicks(9094));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 15, 20, 39, 30, 786, DateTimeKind.Local).AddTicks(9096));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 15, 20, 39, 30, 786, DateTimeKind.Local).AddTicks(9099));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 15, 20, 39, 30, 786, DateTimeKind.Local).AddTicks(9102));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 15, 20, 39, 30, 786, DateTimeKind.Local).AddTicks(9104));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 15, 20, 39, 30, 786, DateTimeKind.Local).AddTicks(9107));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 15, 20, 39, 30, 786, DateTimeKind.Local).AddTicks(9109));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 15, 20, 39, 30, 786, DateTimeKind.Local).AddTicks(9112));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 15, 20, 39, 30, 786, DateTimeKind.Local).AddTicks(9114));

            migrationBuilder.UpdateData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 2, 15, 20, 39, 30, 786, DateTimeKind.Local).AddTicks(9117));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 2, 15, 20, 39, 30, 786, DateTimeKind.Local).AddTicks(8908));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2022, 2, 15, 20, 39, 30, 786, DateTimeKind.Local).AddTicks(8942));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2022, 2, 15, 20, 39, 30, 786, DateTimeKind.Local).AddTicks(8945));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2022, 2, 15, 20, 39, 30, 786, DateTimeKind.Local).AddTicks(8948));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2022, 2, 15, 20, 39, 30, 786, DateTimeKind.Local).AddTicks(8951));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2022, 2, 15, 20, 39, 30, 786, DateTimeKind.Local).AddTicks(8955));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2022, 2, 15, 20, 39, 30, 786, DateTimeKind.Local).AddTicks(8958));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2022, 2, 15, 20, 39, 30, 786, DateTimeKind.Local).AddTicks(8961));
        }
    }
}
