using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CastleTours.Server.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "Id", "Area", "Coordinates", "Country", "GoogleMapsUrl", "OpenStreetMapUrl", "Postcode", "Region", "Street" },
                values: new object[,]
                {
                    { 1, "Beeston", "53.127700, -2.691300", "England", "https://www.google.com/maps?ll=53.1277,-2.6913&q=53.1277,-2.6913&hl=en&t=m&z=15", "https://www.openstreetmap.org/?mlat=53.0572&mlon=-2.6932&zoom=15#map=15/53.0572/-2.6932", "CW6 9TX", "Cheshire", "Chapel Ln." },
                    { 2, "Chester", "53.185300, -2.892300", "England", "https://www.google.com/maps/place/53%C2%B011'07.1%22N+2%C2%B053'32.3%22W/@53.1853,-2.8923,15z/data=!4m5!3m4!1s0x0:0x174f34ec1d99a0dc!8m2!3d53.1853!4d-2.8923?hl=en", "https://www.openstreetmap.org/?mlat=53.1853&mlon=-2.8923&zoom=15#map=15/53.1853/-2.8923", "CH1 2AN", "Cheshire", "Castle Dr." },
                    { 3, "Malpas", "53.057200, -2.693200", "England", "https://www.google.com/maps/place/53%C2%B003'25.9%22N+2%C2%B041'35.5%22W/@53.0572,-2.6932,15z/data=!4m5!3m4!1s0x0:0x3c0d89813010f4b1!8m2!3d53.0572!4d-2.6932?hl=en", "https://www.openstreetmap.org/?mlat=53.0572&mlon=-2.6932&zoom=15#map=15/53.0572/-2.6932", "SY14 8AH", "Cheshire", null },
                    { 4, "Deddington", "53.019700, -2.435600", "England", "https://www.google.com/maps/place/53%C2%B001'10.9%22N+2%C2%B026'08.2%22W/@53.0197,-2.4356,15z/data=!4m5!3m4!1s0x0:0x5d26ee0c75f80aa!8m2!3d53.0197!4d-2.4356?hl=en", "https://www.openstreetmap.org/?mlat=53.0197&mlon=-2.4356&zoom=15#map=15/53.0197/-2.4356", "CW5 7NJ", "Oxford", "Castle Str." },
                    { 5, "Halton", "53.333100, -2.695700", "England", "https://www.google.com/maps/place/53%C2%B019'59.2%22N+2%C2%B041'44.5%22W/@53.3331,-2.6957,15z/data=!4m5!3m4!1s0x0:0xe8c1e4f7df5edf6!8m2!3d53.3331!4d-2.6957?hl=en", "https://www.openstreetmap.org/?mlat=53.3331&mlon=-2.6957&zoom=15#map=15/53.3331/-2.6957", "WA7 2BE", "Chesire", "Castle Rd." },
                    { 6, "Peckford", "53.117500, -2.699000", "England", "https://www.google.com/maps/place/53%C2%B007'03.0%22N+2%C2%B041'56.4%22W/@53.1175,-2.699,15z/data=!4m5!3m4!1s0x0:0xf703599521b49084!8m2!3d53.1175!4d-2.699?hl=en", "https://www.openstreetmap.org/?mlat=53.1175&mlon=-2.699&zoom=15#map=15/53.1175/-2.6990", "CW6 9TN", "Chesire", "Stone House Ln." }
                });

            migrationBuilder.InsertData(
                table: "Castles",
                columns: new[] { "Id", "CategoryId", "Condition", "Date", "DateCreated", "DateUpdated", "Description", "EnteranceFee", "EnteranceFeeSpecial", "ImgUrl", "IsDeleted", "IsOpenToPublic", "IsPublic", "LocationId", "Name", "Summary", "Type", "WikiUrl" },
                values: new object[,]
                {
                    { 1, 1, "Ruins", "13–14th century", new DateTime(2022, 2, 15, 12, 36, 57, 5, DateTimeKind.Local).AddTicks(3487), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer pharetra viverra mattis. Maecenas at venenatis velit, nec sagittis felis. Proin ac ultricies justo, id vestibulum sem. Etiam sed diam quis dolor iaculis iaculis. Nullam augue ipsum, pharetra pharetra ex ac, molestie dignissim est. Duis in nulla ut odio scelerisque laoreet. Proin id suscipit diam. Vestibulum ullamcorper in ante suscipit iaculis.", 12.00m, 0m, "https://upload.wikimedia.org/wikipedia/commons/d/d8/Beeston_Castle_Gate.jpg", false, false, false, 1, "Beeston Castle", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer pharetra viverra mattis.", "Enclosure castle", "https://en.wikipedia.org/wiki/Beeston_Castle" },
                    { 2, 1, "Fragment", "12th century", new DateTime(2022, 2, 15, 12, 36, 57, 5, DateTimeKind.Local).AddTicks(3493), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer pharetra viverra mattis. Maecenas at venenatis velit, nec sagittis felis. Proin ac ultricies justo, id vestibulum sem. Etiam sed diam quis dolor iaculis iaculis. Nullam augue ipsum, pharetra pharetra ex ac, molestie dignissim est. Duis in nulla ut odio scelerisque laoreet. Proin id suscipit diam. Vestibulum ullamcorper in ante suscipit iaculis.", 13.00m, 0m, "https://upload.wikimedia.org/wikipedia/commons/c/c0/Agricola_Tower%2C_Chester_Castle_-_geograph.org.uk_-_675807.jpg", false, false, false, 2, "Chester Castle", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer pharetra viverra mattis.", "Keep and bailey", "https://en.wikipedia.org/wiki/Chester_Castle" },
                    { 3, 1, "Intact", "1801–19th Century", new DateTime(2022, 2, 15, 12, 36, 57, 5, DateTimeKind.Local).AddTicks(3496), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer pharetra viverra mattis. Maecenas at venenatis velit, nec sagittis felis. Proin ac ultricies justo, id vestibulum sem. Etiam sed diam quis dolor iaculis iaculis. Nullam augue ipsum, pharetra pharetra ex ac, molestie dignissim est. Duis in nulla ut odio scelerisque laoreet. Proin id suscipit diam. Vestibulum ullamcorper in ante suscipit iaculis.", 0m, 0m, "https://upload.wikimedia.org/wikipedia/commons/5/51/Cholmondeley_-_Cholmondeley_Castle.jpg", false, false, false, 3, "Cholmondeley Castle", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer pharetra viverra mattis.", "Neo-romantic castle", "https://en.wikipedia.org/wiki/Cholmondeley_Castle" },
                    { 4, 1, "Substantially intact", "c. 1403", new DateTime(2022, 2, 15, 12, 36, 57, 5, DateTimeKind.Local).AddTicks(3499), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer pharetra viverra mattis. Maecenas at venenatis velit, nec sagittis felis. Proin ac ultricies justo, id vestibulum sem. Etiam sed diam quis dolor iaculis iaculis. Nullam augue ipsum, pharetra pharetra ex ac, molestie dignissim est. Duis in nulla ut odio scelerisque laoreet. Proin id suscipit diam. Vestibulum ullamcorper in ante suscipit iaculis.", 0m, 0m, "https://upload.wikimedia.org/wikipedia/commons/d/d1/%22Castle%22_in_the_park_%28cropped%29.jpg", false, false, false, 4, "Doddington Castle", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer pharetra viverra mattis.", "Tower house", "https://en.wikipedia.org/wiki/Delves_Hall" },
                    { 5, 1, "Fragmentary remains", "13th century", new DateTime(2022, 2, 15, 12, 36, 57, 5, DateTimeKind.Local).AddTicks(3502), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer pharetra viverra mattis. Maecenas at venenatis velit, nec sagittis felis. Proin ac ultricies justo, id vestibulum sem. Etiam sed diam quis dolor iaculis iaculis. Nullam augue ipsum, pharetra pharetra ex ac, molestie dignissim est. Duis in nulla ut odio scelerisque laoreet. Proin id suscipit diam. Vestibulum ullamcorper in ante suscipit iaculis.", 13.50m, 0m, "https://upload.wikimedia.org/wikipedia/commons/8/8a/Halton_Castle_-_geograph.org.uk_-_311820.jpg", false, false, false, 5, "Halton Castle", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer pharetra viverra mattis.", "Castle", "https://en.wikipedia.org/wiki/Halton_Castle" },
                    { 6, 1, "Intact", "1844–50", new DateTime(2022, 2, 15, 12, 36, 57, 5, DateTimeKind.Local).AddTicks(3505), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer pharetra viverra mattis. Maecenas at venenatis velit, nec sagittis felis. Proin ac ultricies justo, id vestibulum sem. Etiam sed diam quis dolor iaculis iaculis. Nullam augue ipsum, pharetra pharetra ex ac, molestie dignissim est. Duis in nulla ut odio scelerisque laoreet. Proin id suscipit diam. Vestibulum ullamcorper in ante suscipit iaculis.", 15.00m, 0m, "https://upload.wikimedia.org/wikipedia/commons/4/4b/Peckforton_Castle_1.jpg", false, false, false, 6, "Peckforton Castle", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer pharetra viverra mattis.", "Neo-romantic castle", "https://en.wikipedia.org/wiki/Peckforton_Castle" }
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
                    { 1, "Sit Amet", 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus.", null, new DateTime(2022, 2, 15, 12, 36, 57, 5, DateTimeKind.Local).AddTicks(3543), "Lorem ipsum dolor sit amet", false },
                    { 2, "Sit Amet", 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus.", null, new DateTime(2022, 2, 15, 12, 36, 57, 5, DateTimeKind.Local).AddTicks(3548), "Lorem ipsum dolor sit amet", false },
                    { 3, "Sit Amet", 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus.", null, new DateTime(2022, 2, 15, 12, 36, 57, 5, DateTimeKind.Local).AddTicks(3550), "Lorem ipsum dolor sit amet", false },
                    { 4, "Sit Amet", 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus.", null, new DateTime(2022, 2, 15, 12, 36, 57, 5, DateTimeKind.Local).AddTicks(3552), "Lorem ipsum dolor sit amet", false },
                    { 5, "Sit Amet", 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus.", null, new DateTime(2022, 2, 15, 12, 36, 57, 5, DateTimeKind.Local).AddTicks(3555), "Lorem ipsum dolor sit amet", false },
                    { 6, "Sit Amet", 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus.", null, new DateTime(2022, 2, 15, 12, 36, 57, 5, DateTimeKind.Local).AddTicks(3557), "Lorem ipsum dolor sit amet", false },
                    { 7, "Sit Amet", 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus.", null, new DateTime(2022, 2, 15, 12, 36, 57, 5, DateTimeKind.Local).AddTicks(3560), "Lorem ipsum dolor sit amet", false },
                    { 8, "Sit Amet", 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus.", null, new DateTime(2022, 2, 15, 12, 36, 57, 5, DateTimeKind.Local).AddTicks(3562), "Lorem ipsum dolor sit amet", false }
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
                    { 17, 5, "27 Mar - 30 Sep (Daily): 10am - 5pm", null },
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
                columns: new[] { "Id", "CastleId", "CategoryId", "DateCreated", "DateUpdated", "Description", "ImgUrl", "IsDeleted", "IsOperating", "IsPublic", "Name", "Price", "SpecialPrice" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2022, 2, 15, 12, 36, 57, 5, DateTimeKind.Local).AddTicks(3410), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This tour is part of the National Heritage English History Tour. Its aimed at children 12 to 17 but adult are welcome to learn with us.", "https://www.getoutwiththekids.co.uk/wp-content/uploads/2019/10/Approaching-the-draw-bridge-castle-Day-Out.jpg", false, true, true, "Beeston Castle Kids Tour", 4.50m, 3.50m },
                    { 2, 1, 2, new DateTime(2022, 2, 15, 12, 36, 57, 5, DateTimeKind.Local).AddTicks(3445), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This tour is part of the Wild Flowers Tour ", "https://www.getoutwiththekids.co.uk/wp-content/uploads/2019/10/Approaching-the-draw-bridge-castle-Day-Out.jpg", false, true, true, "Beeston Castle Garden Tour", 2m, 0m },
                    { 3, 2, 2, new DateTime(2022, 2, 15, 12, 36, 57, 5, DateTimeKind.Local).AddTicks(3449), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This tour is part of the National Heritage English History Tour. Learn about the keep and bailey", "https://eu-assets.simpleview-europe.com/chester/imageresizer/?image=%2Fdmsimgs%2Fcastle_1980095267.png&action=ProductDetail", false, true, true, "Chester Castle", 9.00m, 3.50m },
                    { 4, 3, 2, new DateTime(2022, 2, 15, 12, 36, 57, 5, DateTimeKind.Local).AddTicks(3452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Come and join us for a romantic roam around one of Englands finest Neo-romantic castles.", "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/13/0e/df/8a/cholmondeley-castle.jpg?w=1200&h=1200&s=1", false, true, true, "Cholmondeley Tour", 10m, 7.50m },
                    { 5, 4, 2, new DateTime(2022, 2, 15, 12, 36, 57, 5, DateTimeKind.Local).AddTicks(3455), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This tour is currently unavalible as the structure is currently deemed as unsafe.", "https://www.webbaviation.co.uk/aerial/_data/i/galleries/cheshire/doddington/Doddington_Castle_fb32098-me.jpg", false, true, true, "Doddington Tower Tour", 3m, 0m },
                    { 6, 4, 1, new DateTime(2022, 2, 15, 12, 36, 57, 5, DateTimeKind.Local).AddTicks(3458), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This tour is currently unavalible as the structure is currently deemed as unsafe.", "https://www.webbaviation.co.uk/aerial/_data/i/galleries/cheshire/doddington/Doddington_Castle_fb32098-me.jpg", false, true, true, "Doddington Tower Kids Tour", 3m, 0m },
                    { 7, 5, 2, new DateTime(2022, 2, 15, 12, 36, 57, 5, DateTimeKind.Local).AddTicks(3460), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This tour is part of the National Heritage English History Tour. Its aimed at children 12 to 17 but adult are welcome to learn with us.", "https://www.webbaviation.co.uk/aerial/galleries/cheshire/runcorn/Halton_Castle_Runcorn_jd28047.jpg", false, true, true, "Halton Castle", 4.50m, 3.50m }
                });

            migrationBuilder.InsertData(
                table: "Tours",
                columns: new[] { "Id", "CastleId", "CategoryId", "DateCreated", "DateUpdated", "Description", "ImgUrl", "IsDeleted", "IsOperating", "IsPublic", "Name", "Price", "SpecialPrice" },
                values: new object[] { 8, 6, 2, new DateTime(2022, 2, 15, 12, 36, 57, 5, DateTimeKind.Local).AddTicks(3463), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This tour is part of the National Heritage English History Tour. Its aimed at children 12 to 17 but adult are welcome to learn with us.", "https://cdn0.hitched.co.uk/vendor/3537/3_2/960/jpg/dji-0389-low-res_4_183537-163664362614439.jpeg", false, true, true, "Peckforton Castle Tour", 13m, 10.50m });

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
                    { 32, null, "Saturdays 10am - 3pm", 8 }
                });

            migrationBuilder.InsertData(
                table: "TourComments",
                columns: new[] { "Id", "Author", "CommentText", "CreatedApproved", "CreatedDate", "Heading", "IsPublic", "Rating", "TourId" },
                values: new object[,]
                {
                    { 1, "Sit Amet", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus.", null, new DateTime(2022, 2, 15, 12, 36, 57, 5, DateTimeKind.Local).AddTicks(3579), "Lorem ipsum dolor sit amet", false, 3, 1 },
                    { 2, "Sit Amet", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus.", null, new DateTime(2022, 2, 15, 12, 36, 57, 5, DateTimeKind.Local).AddTicks(3583), "Lorem ipsum dolor sit amet", false, 4, 1 },
                    { 3, "Sit Amet", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus.", null, new DateTime(2022, 2, 15, 12, 36, 57, 5, DateTimeKind.Local).AddTicks(3586), "Lorem ipsum dolor sit amet", false, 5, 2 },
                    { 4, "Sit Amet", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus.", null, new DateTime(2022, 2, 15, 12, 36, 57, 5, DateTimeKind.Local).AddTicks(3588), "Lorem ipsum dolor sit amet", false, 2, 3 },
                    { 5, "Sit Amet", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus.", null, new DateTime(2022, 2, 15, 12, 36, 57, 5, DateTimeKind.Local).AddTicks(3591), "Lorem ipsum dolor sit amet", false, 5, 3 },
                    { 6, "Sit Amet", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus.", null, new DateTime(2022, 2, 15, 12, 36, 57, 5, DateTimeKind.Local).AddTicks(3593), "Lorem ipsum dolor sit amet", false, 4, 3 },
                    { 7, "Sit Amet", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus.", null, new DateTime(2022, 2, 15, 12, 36, 57, 5, DateTimeKind.Local).AddTicks(3596), "Lorem ipsum dolor sit amet", false, 4, 4 },
                    { 8, "Sit Amet", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus.", null, new DateTime(2022, 2, 15, 12, 36, 57, 5, DateTimeKind.Local).AddTicks(3598), "Lorem ipsum dolor sit amet", false, 3, 4 },
                    { 9, "Sit Amet", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus.", null, new DateTime(2022, 2, 15, 12, 36, 57, 5, DateTimeKind.Local).AddTicks(3601), "Lorem ipsum dolor sit amet", false, 5, 5 },
                    { 10, "Sit Amet", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus.", null, new DateTime(2022, 2, 15, 12, 36, 57, 5, DateTimeKind.Local).AddTicks(3603), "Lorem ipsum dolor sit amet", false, 4, 5 },
                    { 11, "Sit Amet", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus.", null, new DateTime(2022, 2, 15, 12, 36, 57, 5, DateTimeKind.Local).AddTicks(3606), "Lorem ipsum dolor sit amet", false, 3, 6 },
                    { 12, "Sit Amet", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus.", null, new DateTime(2022, 2, 15, 12, 36, 57, 5, DateTimeKind.Local).AddTicks(3608), "Lorem ipsum dolor sit amet", false, 3, 7 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Addons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Addons",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Addons",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Addons",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Addons",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Addons",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Addons",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CastleComments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "OperatingTimes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OperatingTimes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OperatingTimes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OperatingTimes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OperatingTimes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OperatingTimes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "OperatingTimes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "OperatingTimes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "OperatingTimes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "OperatingTimes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "OperatingTimes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "OperatingTimes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "OperatingTimes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "OperatingTimes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "OperatingTimes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "OperatingTimes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "OperatingTimes",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "OperatingTimes",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "OperatingTimes",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "OperatingTimes",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "OperatingTimes",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "OperatingTimes",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "OperatingTimes",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "OperatingTimes",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "OperatingTimes",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "OperatingTimes",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "OperatingTimes",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "OperatingTimes",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "OperatingTimes",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "OperatingTimes",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "OperatingTimes",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "OperatingTimes",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TourComments",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Castles",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
