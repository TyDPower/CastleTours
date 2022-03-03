using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CastleTours.Server.Migrations
{
    public partial class Initialv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Facilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facilities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Area = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Postcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Coordinates = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GoogleMapsUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpenStreetMapUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryIsoCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "StoreTransactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TicketCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TicketId = table.Column<int>(type: "int", nullable: false),
                    TourId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreTransactions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    RecieveNewsletters = table.Column<bool>(type: "bit", nullable: false),
                    ReadTsAndCs = table.Column<bool>(type: "bit", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsConfirmed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Castles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Condition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WikiUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnteranceFee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EnteranceFeeSpecial = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsOpenToPublic = table.Column<bool>(type: "bit", nullable: false),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Castles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Castles_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Castles_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Favorites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TourId = table.Column<int>(type: "int", nullable: false),
                    DateFavorited = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favorites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Favorites_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Amenities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CastleId = table.Column<int>(type: "int", nullable: false),
                    LoactionId = table.Column<int>(type: "int", nullable: false),
                    FacilityId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amenities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Amenities_Castles_CastleId",
                        column: x => x.CastleId,
                        principalTable: "Castles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CastleComments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CastleId = table.Column<int>(type: "int", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedApproved = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Heading = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommentText = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CastleComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CastleComments_Castles_CastleId",
                        column: x => x.CastleId,
                        principalTable: "Castles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CastleFacility",
                columns: table => new
                {
                    CastlesId = table.Column<int>(type: "int", nullable: false),
                    FacilitiesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CastleFacility", x => new { x.CastlesId, x.FacilitiesId });
                    table.ForeignKey(
                        name: "FK_CastleFacility_Castles_CastlesId",
                        column: x => x.CastlesId,
                        principalTable: "Castles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CastleFacility_Facilities_FacilitiesId",
                        column: x => x.FacilitiesId,
                        principalTable: "Facilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsOperating = table.Column<bool>(type: "bit", nullable: false),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsFeatured = table.Column<bool>(type: "bit", nullable: false),
                    Blurb = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SpecialPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CastleId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tours", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tours_Castles_CastleId",
                        column: x => x.CastleId,
                        principalTable: "Castles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tours_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Addons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TourId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addons_Tours_TourId",
                        column: x => x.TourId,
                        principalTable: "Tours",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FacilityTour",
                columns: table => new
                {
                    FacilitiesId = table.Column<int>(type: "int", nullable: false),
                    ToursId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacilityTour", x => new { x.FacilitiesId, x.ToursId });
                    table.ForeignKey(
                        name: "FK_FacilityTour_Facilities_FacilitiesId",
                        column: x => x.FacilitiesId,
                        principalTable: "Facilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FacilityTour_Tours_ToursId",
                        column: x => x.ToursId,
                        principalTable: "Tours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OperatingTimes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TourId = table.Column<int>(type: "int", nullable: true),
                    CastleId = table.Column<int>(type: "int", nullable: true),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperatingTimes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OperatingTimes_Castles_CastleId",
                        column: x => x.CastleId,
                        principalTable: "Castles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OperatingTimes_Tours_TourId",
                        column: x => x.TourId,
                        principalTable: "Tours",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TourComments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TourId = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedApproved = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Heading = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommentText = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TourComments_Tours_TourId",
                        column: x => x.TourId,
                        principalTable: "Tours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "puzzle-piece", "Family tours", "familytours" },
                    { 2, "people", "12+ age tours", "12agetours" }
                });

            migrationBuilder.InsertData(
                table: "Facilities",
                columns: new[] { "Id", "Icon", "Note", "Type" },
                values: new object[,]
                {
                    { 1, "oi oi-wifi", "Sit amet purus gravida quis blandit turpis.", "WiFi" },
                    { 2, "oi oi-aperture", "Sit amet purus gravida quis blandit turpis.", "View Points" },
                    { 3, "oi oi-audio", "Sit amet purus gravida quis blandit turpis.", "Hearing Aided" },
                    { 4, "oi oi-basket", "Sit amet purus gravida quis blandit turpis.", "Gift Shop" },
                    { 5, "oi oi-british-pound", "Sit amet purus gravida quis blandit turpis.", "ATM" },
                    { 6, "oi oi-home", "Sit amet purus gravida quis blandit turpis.", "Resturant" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Area", "Coordinates", "Country", "CountryIsoCode", "GoogleMapsUrl", "OpenStreetMapUrl", "Postcode", "Region", "Street" },
                values: new object[,]
                {
                    { 1, "Beeston", "53.127700, -2.691300", "England", "gb", "https://www.google.com/maps?ll=53.1277,-2.6913&q=53.1277,-2.6913&hl=en&t=m&z=15", "https://www.openstreetmap.org/?mlat=53.0572&mlon=-2.6932&zoom=15#map=15/53.0572/-2.6932", "CW6 9TX", "Cheshire", "Chapel Ln." },
                    { 2, "Chester", "53.185300, -2.892300", "England", "gb", "https://www.google.com/maps/place/53%C2%B011'07.1%22N+2%C2%B053'32.3%22W/@53.1853,-2.8923,15z/data=!4m5!3m4!1s0x0:0x174f34ec1d99a0dc!8m2!3d53.1853!4d-2.8923?hl=en", "https://www.openstreetmap.org/?mlat=53.1853&mlon=-2.8923&zoom=15#map=15/53.1853/-2.8923", "CH1 2AN", "Cheshire", "Castle Dr." },
                    { 3, "Malpas", "53.057200, -2.693200", "England", "gb", "https://www.google.com/maps/place/53%C2%B003'25.9%22N+2%C2%B041'35.5%22W/@53.0572,-2.6932,15z/data=!4m5!3m4!1s0x0:0x3c0d89813010f4b1!8m2!3d53.0572!4d-2.6932?hl=en", "https://www.openstreetmap.org/?mlat=53.0572&mlon=-2.6932&zoom=15#map=15/53.0572/-2.6932", "SY14 8AH", "Cheshire", null },
                    { 4, "Deddington", "53.019700, -2.435600", "England", "gb", "https://www.google.com/maps/place/53%C2%B001'10.9%22N+2%C2%B026'08.2%22W/@53.0197,-2.4356,15z/data=!4m5!3m4!1s0x0:0x5d26ee0c75f80aa!8m2!3d53.0197!4d-2.4356?hl=en", "https://www.openstreetmap.org/?mlat=53.0197&mlon=-2.4356&zoom=15#map=15/53.0197/-2.4356", "CW5 7NJ", "Oxford", "Castle Str." },
                    { 5, "Halton", "53.333100, -2.695700", "England", "gb", "https://www.google.com/maps/place/53%C2%B019'59.2%22N+2%C2%B041'44.5%22W/@53.3331,-2.6957,15z/data=!4m5!3m4!1s0x0:0xe8c1e4f7df5edf6!8m2!3d53.3331!4d-2.6957?hl=en", "https://www.openstreetmap.org/?mlat=53.3331&mlon=-2.6957&zoom=15#map=15/53.3331/-2.6957", "WA7 2BE", "Chesire", "Castle Rd." },
                    { 6, "Peckford", "53.117500, -2.699000", "England", "gb", "https://www.google.com/maps/place/53%C2%B007'03.0%22N+2%C2%B041'56.4%22W/@53.1175,-2.699,15z/data=!4m5!3m4!1s0x0:0xf703599521b49084!8m2!3d53.1175!4d-2.699?hl=en", "https://www.openstreetmap.org/?mlat=53.1175&mlon=-2.699&zoom=15#map=15/53.1175/-2.6990", "CW6 9TN", "Chesire", "Stone House Ln." },
                    { 7, "Edinburgh", "55.948611, -3.200833", "Scotland", "gb", "https://www.google.com/maps/place/55%C2%B056'55.0%22N+3%C2%B012'03.0%22W/@55.948611,-3.200833,15z/data=!4m5!3m4!1s0x0:0x5eaa0460843a6e07!8m2!3d55.948611!4d-3.200833?hl=en", "https://www.openstreetmap.org/?mlat=55.948611&mlon=-3.200833&zoom=15#map=15/55.9486/-3.2008", "EH1 2YT", "", "Castlehill" }
                });

            migrationBuilder.InsertData(
                table: "Castles",
                columns: new[] { "Id", "CategoryId", "Condition", "Date", "DateCreated", "DateUpdated", "Description", "EnteranceFee", "EnteranceFeeSpecial", "ImgUrl", "IsDeleted", "IsOpenToPublic", "IsPublic", "LocationId", "Name", "Summary", "Type", "WikiUrl" },
                values: new object[,]
                {
                    { 1, 1, "Ruins", "13–14th century", new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9313), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer pharetra viverra mattis. Maecenas at venenatis velit, nec sagittis felis. Proin ac ultricies justo, id vestibulum sem. Etiam sed diam quis dolor iaculis iaculis. Nullam augue ipsum, pharetra pharetra ex ac, molestie dignissim est. Duis in nulla ut odio scelerisque laoreet. Proin id suscipit diam. Vestibulum ullamcorper in ante suscipit iaculis.", 12.00m, 0m, "https://upload.wikimedia.org/wikipedia/commons/d/d8/Beeston_Castle_Gate.jpg", false, false, false, 1, "Beeston Castle", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer pharetra viverra mattis.", "Enclosure castle", "https://en.wikipedia.org/wiki/Beeston_Castle" },
                    { 2, 1, "Fragment", "12th century", new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9322), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer pharetra viverra mattis. Maecenas at venenatis velit, nec sagittis felis. Proin ac ultricies justo, id vestibulum sem. Etiam sed diam quis dolor iaculis iaculis. Nullam augue ipsum, pharetra pharetra ex ac, molestie dignissim est. Duis in nulla ut odio scelerisque laoreet. Proin id suscipit diam. Vestibulum ullamcorper in ante suscipit iaculis.", 13.00m, 0m, "https://upload.wikimedia.org/wikipedia/commons/c/c0/Agricola_Tower%2C_Chester_Castle_-_geograph.org.uk_-_675807.jpg", false, false, false, 2, "Chester Castle", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer pharetra viverra mattis.", "Keep and bailey", "https://en.wikipedia.org/wiki/Chester_Castle" },
                    { 3, 1, "Intact", "1801–19th Century", new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9325), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer pharetra viverra mattis. Maecenas at venenatis velit, nec sagittis felis. Proin ac ultricies justo, id vestibulum sem. Etiam sed diam quis dolor iaculis iaculis. Nullam augue ipsum, pharetra pharetra ex ac, molestie dignissim est. Duis in nulla ut odio scelerisque laoreet. Proin id suscipit diam. Vestibulum ullamcorper in ante suscipit iaculis.", 0m, 0m, "https://upload.wikimedia.org/wikipedia/commons/5/51/Cholmondeley_-_Cholmondeley_Castle.jpg", false, false, false, 3, "Cholmondeley Castle", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer pharetra viverra mattis.", "Neo-romantic castle", "https://en.wikipedia.org/wiki/Cholmondeley_Castle" },
                    { 4, 1, "Substantially intact", "c. 1403", new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9328), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer pharetra viverra mattis. Maecenas at venenatis velit, nec sagittis felis. Proin ac ultricies justo, id vestibulum sem. Etiam sed diam quis dolor iaculis iaculis. Nullam augue ipsum, pharetra pharetra ex ac, molestie dignissim est. Duis in nulla ut odio scelerisque laoreet. Proin id suscipit diam. Vestibulum ullamcorper in ante suscipit iaculis.", 0m, 0m, "https://upload.wikimedia.org/wikipedia/commons/d/d1/%22Castle%22_in_the_park_%28cropped%29.jpg", false, false, false, 4, "Doddington Castle", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer pharetra viverra mattis.", "Tower house", "https://en.wikipedia.org/wiki/Delves_Hall" },
                    { 5, 1, "Fragmentary remains", "13th century", new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9331), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer pharetra viverra mattis. Maecenas at venenatis velit, nec sagittis felis. Proin ac ultricies justo, id vestibulum sem. Etiam sed diam quis dolor iaculis iaculis. Nullam augue ipsum, pharetra pharetra ex ac, molestie dignissim est. Duis in nulla ut odio scelerisque laoreet. Proin id suscipit diam. Vestibulum ullamcorper in ante suscipit iaculis.", 13.50m, 0m, "https://upload.wikimedia.org/wikipedia/commons/8/8a/Halton_Castle_-_geograph.org.uk_-_311820.jpg", false, false, false, 5, "Halton Castle", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer pharetra viverra mattis.", "Castle", "https://en.wikipedia.org/wiki/Halton_Castle" },
                    { 6, 1, "Intact", "1844–50", new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9334), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer pharetra viverra mattis. Maecenas at venenatis velit, nec sagittis felis. Proin ac ultricies justo, id vestibulum sem. Etiam sed diam quis dolor iaculis iaculis. Nullam augue ipsum, pharetra pharetra ex ac, molestie dignissim est. Duis in nulla ut odio scelerisque laoreet. Proin id suscipit diam. Vestibulum ullamcorper in ante suscipit iaculis.", 15.00m, 0m, "https://upload.wikimedia.org/wikipedia/commons/4/4b/Peckforton_Castle_1.jpg", false, false, false, 6, "Peckforton Castle", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer pharetra viverra mattis.", "Neo-romantic castle", "https://en.wikipedia.org/wiki/Peckforton_Castle" },
                    { 7, 1, "Intact", "11th - 21st Centuries", new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9337), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site of a castle since the 12th century, Edinburgh Castle contains buildings of multiple periods and functions, including the royal palace, great hall, and 19th-century barracks.", 18.00m, 0m, "https://upload.wikimedia.org/wikipedia/commons/4/4b/Peckforton_Castle_1.jpg", false, false, false, 7, "Edinburgh Castle", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer pharetra viverra mattis.", "Royal fortress", "https://en.wikipedia.org/wiki/Peckforton_Castle" }
                });

            migrationBuilder.InsertData(
                table: "Amenities",
                columns: new[] { "Id", "CastleId", "Email", "FacilityId", "LoactionId", "Name", "Note", "Phone", "Url" },
                values: new object[,]
                {
                    { 1, 1, "info@tytech.io", 6, 1, "Lorem ipsum", "Vitae ultricies leo integer malesuada. Dui id ornare arcu odio.", "0456978722345", "https://tytech.io" },
                    { 2, 2, "info@tytech.io", 6, 2, "Lorem ipsum", "Vitae ultricies leo integer malesuada. Dui id ornare arcu odio.", "0456978722345", "https://tytech.io" },
                    { 3, 3, "info@tytech.io", 3, 3, "Lorem ipsum", "Vitae ultricies leo integer malesuada. Dui id ornare arcu odio.", "0456978722345", "https://tytech.io" }
                });

            migrationBuilder.InsertData(
                table: "CastleComments",
                columns: new[] { "Id", "Author", "CastleId", "CommentText", "CreatedApproved", "CreatedDate", "Heading", "IsPublic" },
                values: new object[,]
                {
                    { 1, "Sit Amet", 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus.", null, new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9390), "Lorem ipsum dolor sit amet", false },
                    { 2, "Sit Amet", 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus.", null, new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9395), "Lorem ipsum dolor sit amet", false },
                    { 3, "Sit Amet", 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus.", null, new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9398), "Lorem ipsum dolor sit amet", false },
                    { 4, "Sit Amet", 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus.", null, new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9400), "Lorem ipsum dolor sit amet", false },
                    { 5, "Sit Amet", 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus.", null, new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9402), "Lorem ipsum dolor sit amet", false },
                    { 6, "Sit Amet", 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus.", null, new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9404), "Lorem ipsum dolor sit amet", false },
                    { 7, "Sit Amet", 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus.", null, new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9407), "Lorem ipsum dolor sit amet", false },
                    { 8, "Sit Amet", 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus.", null, new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9409), "Lorem ipsum dolor sit amet", false }
                });

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

            migrationBuilder.InsertData(
                table: "OperatingTimes",
                columns: new[] { "Id", "CastleId", "Time", "TourId" },
                values: new object[,]
                {
                    { 1, 1, "27 Mar - 30 Sep (Daily): 10am - 5pm", null },
                    { 2, 1, "1 Oct - 31 Oct (Daily): 10am - 4pm", null },
                    { 3, 1, "1 Nov - 31 Mar (Sat - Sun): 10am - 4pm", null },
                    { 4, 1, "24 Dec - 26 Dec & 1 Jan: Cloased", null },
                    { 5, 2, "27 Mar - 30 Sep (Daily): 10am - 5pm", null },
                    { 6, 2, "1 Oct - 31 Oct (Daily): 10am - 4pm", null },
                    { 7, 2, "1 Nov - 31 Mar (Sat - Sun): 10am - 4pm", null },
                    { 8, 2, "24 Dec - 26 Dec & 1 Jan: Cloased", null },
                    { 9, 3, "27 Mar - 30 Sep (Daily): 10am - 5pm", null },
                    { 10, 3, "1 Oct - 31 Oct (Daily): 10am - 4pm", null },
                    { 11, 3, "1 Nov - 31 Mar (Sat - Sun): 10am - 4pm", null },
                    { 12, 3, "24 Dec - 26 Dec & 1 Jan: Cloased", null },
                    { 13, 4, "27 Mar - 30 Sep (Daily): 10am - 5pm", null },
                    { 14, 4, "1 Oct - 31 Oct (Daily): 10am - 4pm", null },
                    { 15, 4, "1 Nov - 31 Mar (Sat - Sun): 10am - 4pm", null },
                    { 16, 4, "24 Dec - 26 Dec & 1 Jan: Cloased", null },
                    { 17, 5, "27 Mar - 30 Sep (Daily): 10am - 5pm", null }
                });

            migrationBuilder.InsertData(
                table: "OperatingTimes",
                columns: new[] { "Id", "CastleId", "Time", "TourId" },
                values: new object[,]
                {
                    { 18, 5, "1 Oct - 31 Oct (Daily): 10am - 4pm", null },
                    { 19, 5, "1 Nov - 31 Mar (Sat - Sun): 10am - 4pm", null },
                    { 20, 5, "24 Dec - 26 Dec & 1 Jan: Cloased", null },
                    { 21, 6, "27 Mar - 30 Sep (Daily): 10am - 5pm", null },
                    { 22, 6, "1 Oct - 31 Oct (Daily): 10am - 4pm", null },
                    { 23, 6, "1 Nov - 31 Mar (Sat - Sun): 10am - 4pm", null },
                    { 24, 6, "24 Dec - 26 Dec & 1 Jan: Cloased", null }
                });

            migrationBuilder.InsertData(
                table: "Tours",
                columns: new[] { "Id", "Blurb", "CastleId", "CategoryId", "DateCreated", "DateUpdated", "Description", "ImgUrl", "IsDeleted", "IsFeatured", "IsOperating", "IsPublic", "Name", "Price", "SpecialPrice" },
                values: new object[,]
                {
                    { 1, null, 1, 1, new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9183), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This tour is part of the National Heritage English History Tour. Its aimed at children 12 to 17 but adult are welcome to learn with us.", "https://www.getoutwiththekids.co.uk/wp-content/uploads/2019/10/Approaching-the-draw-bridge-castle-Day-Out.jpg", false, false, true, true, "Beeston Castle Kids Tour", 4.50m, 3.50m },
                    { 2, null, 1, 2, new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9223), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This tour is part of the Wild Flowers Tour ", "https://www.getoutwiththekids.co.uk/wp-content/uploads/2019/10/Approaching-the-draw-bridge-castle-Day-Out.jpg", false, false, true, true, "Beeston Castle Garden Tour", 2m, 0m },
                    { 3, null, 2, 2, new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9227), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This tour is part of the National Heritage English History Tour. Learn about the keep and bailey", "https://eu-assets.simpleview-europe.com/chester/imageresizer/?image=%2Fdmsimgs%2Fcastle_1980095267.png&action=ProductDetail", false, false, true, true, "Chester Castle", 9.00m, 3.50m },
                    { 4, null, 3, 2, new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9230), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Come and join us for a romantic roam around one of Englands finest Neo-romantic castles.", "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/13/0e/df/8a/cholmondeley-castle.jpg?w=1200&h=1200&s=1", false, false, true, true, "Cholmondeley Tour", 10m, 7.50m },
                    { 5, null, 4, 2, new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9271), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This tour is currently unavalible as the structure is currently deemed as unsafe.", "https://www.webbaviation.co.uk/aerial/_data/i/galleries/cheshire/doddington/Doddington_Castle_fb32098-me.jpg", false, false, true, true, "Doddington Tower Tour", 3m, 0m },
                    { 6, null, 4, 1, new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9274), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This tour is currently unavalible as the structure is currently deemed as unsafe.", "https://www.webbaviation.co.uk/aerial/_data/i/galleries/cheshire/doddington/Doddington_Castle_fb32098-me.jpg", false, false, true, true, "Doddington Tower Kids Tour", 3m, 0m },
                    { 7, null, 5, 2, new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9277), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This tour is part of the National Heritage English History Tour. Its aimed at children 12 to 17 but adult are welcome to learn with us.", "https://www.webbaviation.co.uk/aerial/galleries/cheshire/runcorn/Halton_Castle_Runcorn_jd28047.jpg", false, false, true, true, "Halton Castle", 4.50m, 3.50m },
                    { 8, null, 6, 2, new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9281), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This tour is part of the National Heritage English History Tour. Its aimed at children 12 to 17 but adult are welcome to learn with us.", "https://cdn0.hitched.co.uk/vendor/3537/3_2/960/jpg/dji-0389-low-res_4_183537-163664362614439.jpeg", false, false, true, true, "Peckforton Castle Tour", 13m, 10.50m },
                    { 9, "Explore the most besieged castle in Eorupe!", 7, 2, new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9284), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This tour is part of the National Heritage English History Tour. Its aimed at children 12 to 17 but adult are welcome to learn with us.", "https://th.bing.com/th/id/R.bb550545afd48d8ae77307363370a55d?rik=ZzKNsIDOcO3tPg&riu=http%3a%2f%2fwallup.net%2fwp-content%2fuploads%2f2016%2f01%2f207095-landscape-castle-Edinburgh-Scotland-UK.jpg&ehk=8eM1O612fOuUrOp1Aa9KhN03%2flt1%2fx6YcdNHavii6DA%3d&risl=&pid=ImgRaw&r=0", false, true, true, true, "The Besieged Tour", 32m, 25m }
                });

            migrationBuilder.InsertData(
                table: "Addons",
                columns: new[] { "Id", "Description", "Name", "Price", "ShortDescription", "TourId" },
                values: new object[,]
                {
                    { 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus. Vitae ultricies leo integer malesuada. Dui id ornare arcu odio. Sit amet purus gravida quis blandit turpis. Interdum posuere lorem ipsum dolor sit amet consectetur adipiscing elit. Arcu dictum varius duis at. Et malesuada fames ac turpis egestas maecenas. Mi bibendum neque egestas congue quisque egestas. Sagittis orci a scelerisque purus semper. Leo vel orci porta non pulvinar neque. Tortor pretium viverra suspendisse potenti nullam ac.", "Lorem ipsum dolor", 2.00m, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 1 },
                    { 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus. Vitae ultricies leo integer malesuada. Dui id ornare arcu odio. Sit amet purus gravida quis blandit turpis. Interdum posuere lorem ipsum dolor sit amet consectetur adipiscing elit. Arcu dictum varius duis at. Et malesuada fames ac turpis egestas maecenas. Mi bibendum neque egestas congue quisque egestas. Sagittis orci a scelerisque purus semper. Leo vel orci porta non pulvinar neque. Tortor pretium viverra suspendisse potenti nullam ac.", "Lorem ipsum dolor", 2.00m, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 2 },
                    { 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus. Vitae ultricies leo integer malesuada. Dui id ornare arcu odio. Sit amet purus gravida quis blandit turpis. Interdum posuere lorem ipsum dolor sit amet consectetur adipiscing elit. Arcu dictum varius duis at. Et malesuada fames ac turpis egestas maecenas. Mi bibendum neque egestas congue quisque egestas. Sagittis orci a scelerisque purus semper. Leo vel orci porta non pulvinar neque. Tortor pretium viverra suspendisse potenti nullam ac.", "Lorem ipsum dolor", 4.00m, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 2 },
                    { 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus. Vitae ultricies leo integer malesuada. Dui id ornare arcu odio. Sit amet purus gravida quis blandit turpis. Interdum posuere lorem ipsum dolor sit amet consectetur adipiscing elit. Arcu dictum varius duis at. Et malesuada fames ac turpis egestas maecenas. Mi bibendum neque egestas congue quisque egestas. Sagittis orci a scelerisque purus semper. Leo vel orci porta non pulvinar neque. Tortor pretium viverra suspendisse potenti nullam ac.", "Lorem ipsum dolor", 2.50m, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 3 },
                    { 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus. Vitae ultricies leo integer malesuada. Dui id ornare arcu odio. Sit amet purus gravida quis blandit turpis. Interdum posuere lorem ipsum dolor sit amet consectetur adipiscing elit. Arcu dictum varius duis at. Et malesuada fames ac turpis egestas maecenas. Mi bibendum neque egestas congue quisque egestas. Sagittis orci a scelerisque purus semper. Leo vel orci porta non pulvinar neque. Tortor pretium viverra suspendisse potenti nullam ac.", "Lorem ipsum dolor", 12.00m, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 4 },
                    { 6, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus. Vitae ultricies leo integer malesuada. Dui id ornare arcu odio. Sit amet purus gravida quis blandit turpis. Interdum posuere lorem ipsum dolor sit amet consectetur adipiscing elit. Arcu dictum varius duis at. Et malesuada fames ac turpis egestas maecenas. Mi bibendum neque egestas congue quisque egestas. Sagittis orci a scelerisque purus semper. Leo vel orci porta non pulvinar neque. Tortor pretium viverra suspendisse potenti nullam ac.", "Lorem ipsum dolor", 1.00m, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 5 },
                    { 7, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus. Vitae ultricies leo integer malesuada. Dui id ornare arcu odio. Sit amet purus gravida quis blandit turpis. Interdum posuere lorem ipsum dolor sit amet consectetur adipiscing elit. Arcu dictum varius duis at. Et malesuada fames ac turpis egestas maecenas. Mi bibendum neque egestas congue quisque egestas. Sagittis orci a scelerisque purus semper. Leo vel orci porta non pulvinar neque. Tortor pretium viverra suspendisse potenti nullam ac.", "Lorem ipsum dolor", 4.00m, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 5 },
                    { 8, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus. Vitae ultricies leo integer malesuada. Dui id ornare arcu odio. Sit amet purus gravida quis blandit turpis. Interdum posuere lorem ipsum dolor sit amet consectetur adipiscing elit. Arcu dictum varius duis at. Et malesuada fames ac turpis egestas maecenas. Mi bibendum neque egestas congue quisque egestas. Sagittis orci a scelerisque purus semper. Leo vel orci porta non pulvinar neque. Tortor pretium viverra suspendisse potenti nullam ac.", "Lorem ipsum dolor", 3.50m, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 6 }
                });

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

            migrationBuilder.InsertData(
                table: "OperatingTimes",
                columns: new[] { "Id", "CastleId", "Time", "TourId" },
                values: new object[,]
                {
                    { 25, null, "Saturdays 10am - 3pm", 1 },
                    { 26, null, "Saturdays 10am - 3pm", 2 },
                    { 27, null, "Saturdays 10am - 3pm", 3 },
                    { 28, null, "Saturdays 10am - 3pm", 4 },
                    { 29, null, "Saturdays 10am - 3pm", 5 },
                    { 30, null, "Saturdays 10am - 3pm", 6 },
                    { 31, null, "Saturdays 10am - 3pm", 7 },
                    { 32, null, "Saturdays 10am - 3pm", 8 },
                    { 33, null, "Mondays - Saturdays 9am - 4pm", 9 },
                    { 34, null, "Sundays 9am - 3pm", 9 }
                });

            migrationBuilder.InsertData(
                table: "TourComments",
                columns: new[] { "Id", "Author", "CommentText", "CreatedApproved", "CreatedDate", "Heading", "IsPublic", "Rating", "TourId" },
                values: new object[,]
                {
                    { 1, "Sit Amet", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus.", null, new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9433), "Lorem ipsum dolor sit amet", false, 3, 1 },
                    { 2, "Sit Amet", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus.", null, new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9437), "Lorem ipsum dolor sit amet", false, 4, 1 },
                    { 3, "Sit Amet", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus.", null, new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9439), "Lorem ipsum dolor sit amet", false, 5, 2 },
                    { 4, "Sit Amet", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus.", null, new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9442), "Lorem ipsum dolor sit amet", false, 2, 3 },
                    { 5, "Sit Amet", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus.", null, new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9444), "Lorem ipsum dolor sit amet", false, 5, 3 },
                    { 6, "Sit Amet", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus.", null, new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9446), "Lorem ipsum dolor sit amet", false, 4, 3 },
                    { 7, "Sit Amet", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus.", null, new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9449), "Lorem ipsum dolor sit amet", false, 4, 4 },
                    { 8, "Sit Amet", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus.", null, new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9451), "Lorem ipsum dolor sit amet", false, 3, 4 },
                    { 9, "Sit Amet", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus.", null, new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9453), "Lorem ipsum dolor sit amet", false, 5, 5 },
                    { 10, "Sit Amet", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus.", null, new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9456), "Lorem ipsum dolor sit amet", false, 4, 5 }
                });

            migrationBuilder.InsertData(
                table: "TourComments",
                columns: new[] { "Id", "Author", "CommentText", "CreatedApproved", "CreatedDate", "Heading", "IsPublic", "Rating", "TourId" },
                values: new object[] { 11, "Sit Amet", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus.", null, new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9458), "Lorem ipsum dolor sit amet", false, 3, 6 });

            migrationBuilder.InsertData(
                table: "TourComments",
                columns: new[] { "Id", "Author", "CommentText", "CreatedApproved", "CreatedDate", "Heading", "IsPublic", "Rating", "TourId" },
                values: new object[] { 12, "Sit Amet", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus.", null, new DateTime(2022, 3, 3, 14, 38, 15, 259, DateTimeKind.Local).AddTicks(9460), "Lorem ipsum dolor sit amet", false, 3, 7 });

            migrationBuilder.CreateIndex(
                name: "IX_Addons_TourId",
                table: "Addons",
                column: "TourId");

            migrationBuilder.CreateIndex(
                name: "IX_Amenities_CastleId",
                table: "Amenities",
                column: "CastleId");

            migrationBuilder.CreateIndex(
                name: "IX_CastleComments_CastleId",
                table: "CastleComments",
                column: "CastleId");

            migrationBuilder.CreateIndex(
                name: "IX_CastleFacility_FacilitiesId",
                table: "CastleFacility",
                column: "FacilitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_Castles_CategoryId",
                table: "Castles",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Castles_LocationId",
                table: "Castles",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_FacilityTour_ToursId",
                table: "FacilityTour",
                column: "ToursId");

            migrationBuilder.CreateIndex(
                name: "IX_Favorites_UserId",
                table: "Favorites",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OperatingTimes_CastleId",
                table: "OperatingTimes",
                column: "CastleId");

            migrationBuilder.CreateIndex(
                name: "IX_OperatingTimes_TourId",
                table: "OperatingTimes",
                column: "TourId");

            migrationBuilder.CreateIndex(
                name: "IX_TourComments_TourId",
                table: "TourComments",
                column: "TourId");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_CastleId",
                table: "Tours",
                column: "CastleId");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_CategoryId",
                table: "Tours",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addons");

            migrationBuilder.DropTable(
                name: "Amenities");

            migrationBuilder.DropTable(
                name: "CastleComments");

            migrationBuilder.DropTable(
                name: "CastleFacility");

            migrationBuilder.DropTable(
                name: "FacilityTour");

            migrationBuilder.DropTable(
                name: "Favorites");

            migrationBuilder.DropTable(
                name: "OperatingTimes");

            migrationBuilder.DropTable(
                name: "Stats");

            migrationBuilder.DropTable(
                name: "StoreTransactions");

            migrationBuilder.DropTable(
                name: "TourComments");

            migrationBuilder.DropTable(
                name: "Facilities");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Tours");

            migrationBuilder.DropTable(
                name: "Castles");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Locations");
        }
    }
}
