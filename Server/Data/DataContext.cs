using CastleTours.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace CastleTours.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Tour> Tours { get; set; }
        public DbSet<Castle> Castles { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<CastleComment> CastleComments { get; set; }
        public DbSet<TourComment> TourComments { get; set; }
        public DbSet<Facility> Facilities { get; set; }
        public DbSet<Amenity> Amenities { get; set; }
        public DbSet<OperatingTime> OperatingTimes { get; set; }
        public DbSet<Addon> Addons { get; set; }
        public DbSet<Stats> Stats { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Family tours",
                    Url = "familytours",
                    Icon = "puzzle-piece"
                },
                new Category
                {
                    Id = 2,
                    Name = "12+ age tours",
                    Url = "12agetours",
                    Icon = "people"
                }
            );

            modelBuilder.Entity<Tour>().HasData(
                new Tour()
                {
                    Id = 1,
                    CastleId = 1,
                    Name = "Beeston Castle Kids Tour",
                    ImgUrl = "https://www.getoutwiththekids.co.uk/wp-content/uploads/2019/10/Approaching-the-draw-bridge-castle-Day-Out.jpg",
                    Description = "This tour is part of the National Heritage English History Tour. Its aimed at children 12 to 17 but adult are welcome to learn with us.",
                    Price = 4.50M,
                    SpecialPrice = 3.50m,
                    CategoryId = 1,
                },
                new Tour()
                {
                    Id = 2,
                    CastleId = 1,
                    Name = "Beeston Castle Garden Tour",
                    ImgUrl = "https://www.getoutwiththekids.co.uk/wp-content/uploads/2019/10/Approaching-the-draw-bridge-castle-Day-Out.jpg",
                    Description = "This tour is part of the Wild Flowers Tour ",
                    Price = 2M,
                    CategoryId = 2,
                },
                new Tour()
                {
                    Id = 3,
                    CastleId = 2,
                    Name = "Chester Castle",
                    ImgUrl = "https://eu-assets.simpleview-europe.com/chester/imageresizer/?image=%2Fdmsimgs%2Fcastle_1980095267.png&action=ProductDetail",
                    Description = "This tour is part of the National Heritage English History Tour. Learn about the keep and bailey",
                    Price = 9.00M,
                    SpecialPrice = 3.50m,
                    CategoryId = 2,
                },
                new Tour()
                {
                    Id = 4,
                    CastleId = 3,
                    Name = "Cholmondeley Tour",
                    ImgUrl = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/13/0e/df/8a/cholmondeley-castle.jpg?w=1200&h=1200&s=1",
                    Description = "Come and join us for a romantic roam around one of Englands finest Neo-romantic castles.",
                    Price = 10M,
                    SpecialPrice = 7.50m,
                    CategoryId = 2,
                },
                new Tour()
                {
                    Id = 5,
                    CastleId = 4,
                    Name = "Doddington Tower Tour",
                    ImgUrl = "https://www.webbaviation.co.uk/aerial/_data/i/galleries/cheshire/doddington/Doddington_Castle_fb32098-me.jpg",
                    Description = "This tour is currently unavalible as the structure is currently deemed as unsafe.",
                    Price = 3M,
                    CategoryId = 2,
                },
                new Tour()
                {
                    Id = 6,
                    CastleId = 4,
                    Name = "Doddington Tower Kids Tour",
                    ImgUrl = "https://www.webbaviation.co.uk/aerial/_data/i/galleries/cheshire/doddington/Doddington_Castle_fb32098-me.jpg",
                    Description = "This tour is currently unavalible as the structure is currently deemed as unsafe.",
                    Price = 3M,
                    CategoryId = 1,
                },
                new Tour()
                {
                    Id = 7,
                    CastleId = 5,
                    Name = "Halton Castle",
                    ImgUrl = "https://www.webbaviation.co.uk/aerial/galleries/cheshire/runcorn/Halton_Castle_Runcorn_jd28047.jpg",
                    Description = "This tour is part of the National Heritage English History Tour. Its aimed at children 12 to 17 but adult are welcome to learn with us.",
                    Price = 4.50M,
                    SpecialPrice = 3.50m,
                    CategoryId = 2,
                },
                new Tour()
                {
                    Id = 8,
                    CastleId = 6,
                    Name = "Peckforton Castle Tour",
                    ImgUrl = "https://cdn0.hitched.co.uk/vendor/3537/3_2/960/jpg/dji-0389-low-res_4_183537-163664362614439.jpeg",
                    Description = "This tour is part of the National Heritage English History Tour. Its aimed at children 12 to 17 but adult are welcome to learn with us.",
                    Price = 13M,
                    SpecialPrice = 10.50m,
                    CategoryId = 2,
                },
                new Tour()
                {
                    Id = 9,
                    CastleId = 7,
                    Name = "The Besieged Tour",
                    ImgUrl = "https://th.bing.com/th/id/R.bb550545afd48d8ae77307363370a55d?rik=ZzKNsIDOcO3tPg&riu=http%3a%2f%2fwallup.net%2fwp-content%2fuploads%2f2016%2f01%2f207095-landscape-castle-Edinburgh-Scotland-UK.jpg&ehk=8eM1O612fOuUrOp1Aa9KhN03%2flt1%2fx6YcdNHavii6DA%3d&risl=&pid=ImgRaw&r=0",
                    Description = "This tour is part of the National Heritage English History Tour. Its aimed at children 12 to 17 but adult are welcome to learn with us.",
                    IsFeatured = true,
                    Blurb = "Explore the most besieged castle in Eorupe!",
                    Price = 32M,
                    SpecialPrice = 25m,
                    CategoryId = 2,
                }
            );

            modelBuilder.Entity<Castle>().HasData(
                new Castle
                {
                    Id = 1,
                    Name = "Beeston Castle",
                    Type = "Enclosure castle",
                    Date = "13–14th century",
                    Condition = "Ruins",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer pharetra viverra mattis. Maecenas at venenatis velit, nec sagittis felis. Proin ac ultricies justo, id vestibulum sem. Etiam sed diam quis dolor iaculis iaculis. Nullam augue ipsum, pharetra pharetra ex ac, molestie dignissim est. Duis in nulla ut odio scelerisque laoreet. Proin id suscipit diam. Vestibulum ullamcorper in ante suscipit iaculis.",
                    Summary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer pharetra viverra mattis.",
                    ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/d/d8/Beeston_Castle_Gate.jpg",
                    WikiUrl = "https://en.wikipedia.org/wiki/Beeston_Castle",
                    EnteranceFee = 12.00M,
                    CategoryId = 1,
                    LocationId = 1,
                },
                new Castle
                {
                    Id = 2,
                    Name = "Chester Castle",
                    Type = "Keep and bailey",
                    Date = "12th century",
                    Condition = "Fragment",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer pharetra viverra mattis. Maecenas at venenatis velit, nec sagittis felis. Proin ac ultricies justo, id vestibulum sem. Etiam sed diam quis dolor iaculis iaculis. Nullam augue ipsum, pharetra pharetra ex ac, molestie dignissim est. Duis in nulla ut odio scelerisque laoreet. Proin id suscipit diam. Vestibulum ullamcorper in ante suscipit iaculis.",
                    Summary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer pharetra viverra mattis.",
                    ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/c/c0/Agricola_Tower%2C_Chester_Castle_-_geograph.org.uk_-_675807.jpg",
                    WikiUrl = "https://en.wikipedia.org/wiki/Chester_Castle",
                    EnteranceFee = 13.00M,
                    CategoryId = 1,
                    LocationId = 2,
                },
                new Castle
                {
                    Id = 3,
                    Name = "Cholmondeley Castle",
                    Type = "Neo-romantic castle",
                    Date = "1801–19th Century",
                    Condition = "Intact",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer pharetra viverra mattis. Maecenas at venenatis velit, nec sagittis felis. Proin ac ultricies justo, id vestibulum sem. Etiam sed diam quis dolor iaculis iaculis. Nullam augue ipsum, pharetra pharetra ex ac, molestie dignissim est. Duis in nulla ut odio scelerisque laoreet. Proin id suscipit diam. Vestibulum ullamcorper in ante suscipit iaculis.",
                    Summary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer pharetra viverra mattis.",
                    ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/5/51/Cholmondeley_-_Cholmondeley_Castle.jpg",
                    WikiUrl = "https://en.wikipedia.org/wiki/Cholmondeley_Castle",
                    CategoryId = 1,
                    LocationId = 3,
                },
                new Castle
                {
                    Id = 4,
                    Name = "Doddington Castle",
                    Type = "Tower house",
                    Date = "c. 1403",
                    Condition = "Substantially intact",
                    Summary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer pharetra viverra mattis.",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer pharetra viverra mattis. Maecenas at venenatis velit, nec sagittis felis. Proin ac ultricies justo, id vestibulum sem. Etiam sed diam quis dolor iaculis iaculis. Nullam augue ipsum, pharetra pharetra ex ac, molestie dignissim est. Duis in nulla ut odio scelerisque laoreet. Proin id suscipit diam. Vestibulum ullamcorper in ante suscipit iaculis.",
                    ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/d/d1/%22Castle%22_in_the_park_%28cropped%29.jpg",
                    WikiUrl = "https://en.wikipedia.org/wiki/Delves_Hall",
                    CategoryId = 1,
                    LocationId = 4,
                },
                new Castle
                {
                    Id = 5,
                    Name = "Halton Castle",
                    Type = "Castle",
                    Date = "13th century",
                    Condition = "Fragmentary remains",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer pharetra viverra mattis. Maecenas at venenatis velit, nec sagittis felis. Proin ac ultricies justo, id vestibulum sem. Etiam sed diam quis dolor iaculis iaculis. Nullam augue ipsum, pharetra pharetra ex ac, molestie dignissim est. Duis in nulla ut odio scelerisque laoreet. Proin id suscipit diam. Vestibulum ullamcorper in ante suscipit iaculis.",
                    Summary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer pharetra viverra mattis.",
                    ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/8/8a/Halton_Castle_-_geograph.org.uk_-_311820.jpg",
                    WikiUrl = "https://en.wikipedia.org/wiki/Halton_Castle",
                    EnteranceFee = 13.50M,
                    CategoryId = 1,
                    LocationId = 5,
                },
                new Castle
                {
                    Id = 6,
                    Name = "Peckforton Castle",
                    Type = "Neo-romantic castle",
                    Date = "1844–50",
                    Condition = "Intact",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer pharetra viverra mattis. Maecenas at venenatis velit, nec sagittis felis. Proin ac ultricies justo, id vestibulum sem. Etiam sed diam quis dolor iaculis iaculis. Nullam augue ipsum, pharetra pharetra ex ac, molestie dignissim est. Duis in nulla ut odio scelerisque laoreet. Proin id suscipit diam. Vestibulum ullamcorper in ante suscipit iaculis.",
                    Summary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer pharetra viverra mattis.",
                    ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/4/4b/Peckforton_Castle_1.jpg",
                    WikiUrl = "https://en.wikipedia.org/wiki/Peckforton_Castle",
                    EnteranceFee = 15.00M,
                    CategoryId = 1,
                    LocationId = 6,
                },
                new Castle
                {
                    Id = 7,
                    Name = "Edinburgh Castle",
                    Type = "Royal fortress",
                    Date = "11th - 21st Centuries",
                    Condition = "Intact",
                    Description = "Site of a castle since the 12th century, Edinburgh Castle contains buildings of multiple periods and functions, including the royal palace, great hall, and 19th-century barracks.",
                    Summary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer pharetra viverra mattis.",
                    ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/4/4b/Peckforton_Castle_1.jpg",
                    WikiUrl = "https://en.wikipedia.org/wiki/Peckforton_Castle",
                    EnteranceFee = 18.00M,
                    CategoryId = 1,
                    LocationId = 7,
                }
            );

            modelBuilder.Entity<Location>().HasData(
                new Location
                {
                    Id = 1,
                    OpenStreetMapUrl = "https://www.openstreetmap.org/?mlat=53.0572&mlon=-2.6932&zoom=15#map=15/53.0572/-2.6932",
                    GoogleMapsUrl = "https://www.google.com/maps?ll=53.1277,-2.6913&q=53.1277,-2.6913&hl=en&t=m&z=15",
                    Coordinates = "53.127700, -2.691300",
                    Street = "Chapel Ln.",
                    Area = "Beeston",
                    Region = "Cheshire",
                    Country = "England",
                    Postcode = "CW6 9TX",
                    CountryIsoCode = "gb"
                },
                new Location
                {
                    Id = 2,
                    OpenStreetMapUrl = "https://www.openstreetmap.org/?mlat=53.1853&mlon=-2.8923&zoom=15#map=15/53.1853/-2.8923",
                    GoogleMapsUrl = "https://www.google.com/maps/place/53%C2%B011'07.1%22N+2%C2%B053'32.3%22W/@53.1853,-2.8923,15z/data=!4m5!3m4!1s0x0:0x174f34ec1d99a0dc!8m2!3d53.1853!4d-2.8923?hl=en",
                    Coordinates = "53.185300, -2.892300",
                    Street = "Castle Dr.",
                    Area = "Chester",
                    Region = "Cheshire",
                    Country = "England",
                    Postcode = "CH1 2AN",
                    CountryIsoCode = "gb"
                },
                new Location
                {
                    Id = 3,
                    OpenStreetMapUrl = "https://www.openstreetmap.org/?mlat=53.0572&mlon=-2.6932&zoom=15#map=15/53.0572/-2.6932",
                    GoogleMapsUrl = "https://www.google.com/maps/place/53%C2%B003'25.9%22N+2%C2%B041'35.5%22W/@53.0572,-2.6932,15z/data=!4m5!3m4!1s0x0:0x3c0d89813010f4b1!8m2!3d53.0572!4d-2.6932?hl=en",
                    Coordinates = "53.057200, -2.693200",
                    Area = "Malpas",
                    Region = "Cheshire",
                    Country = "England",
                    Postcode = "SY14 8AH",
                    CountryIsoCode = "gb"
                },
                new Location
                {
                    Id = 4,
                    OpenStreetMapUrl = "https://www.openstreetmap.org/?mlat=53.0197&mlon=-2.4356&zoom=15#map=15/53.0197/-2.4356",
                    GoogleMapsUrl = "https://www.google.com/maps/place/53%C2%B001'10.9%22N+2%C2%B026'08.2%22W/@53.0197,-2.4356,15z/data=!4m5!3m4!1s0x0:0x5d26ee0c75f80aa!8m2!3d53.0197!4d-2.4356?hl=en",
                    Coordinates = "53.019700, -2.435600",
                    Street = "Castle Str.",
                    Area = "Deddington",
                    Region = "Oxford",
                    Country = "England",
                    Postcode = "CW5 7NJ",
                    CountryIsoCode = "gb"
                },
                new Location
                {
                    Id = 5,
                    OpenStreetMapUrl = "https://www.openstreetmap.org/?mlat=53.3331&mlon=-2.6957&zoom=15#map=15/53.3331/-2.6957",
                    GoogleMapsUrl = "https://www.google.com/maps/place/53%C2%B019'59.2%22N+2%C2%B041'44.5%22W/@53.3331,-2.6957,15z/data=!4m5!3m4!1s0x0:0xe8c1e4f7df5edf6!8m2!3d53.3331!4d-2.6957?hl=en",
                    Coordinates = "53.333100, -2.695700",
                    Street = "Castle Rd.",
                    Area = "Halton",
                    Region = "Chesire",
                    Country = "England",
                    Postcode = "WA7 2BE",
                    CountryIsoCode = "gb"
                },
                new Location
                {
                    Id = 6,
                    OpenStreetMapUrl = "https://www.openstreetmap.org/?mlat=53.1175&mlon=-2.699&zoom=15#map=15/53.1175/-2.6990",
                    GoogleMapsUrl = "https://www.google.com/maps/place/53%C2%B007'03.0%22N+2%C2%B041'56.4%22W/@53.1175,-2.699,15z/data=!4m5!3m4!1s0x0:0xf703599521b49084!8m2!3d53.1175!4d-2.699?hl=en",
                    Coordinates = "53.117500, -2.699000",
                    Street = "Stone House Ln.",
                    Area = "Peckford",
                    Region = "Chesire",
                    Country = "England",
                    Postcode = "CW6 9TN",
                    CountryIsoCode = "gb"
                },
                new Location
                {
                    Id = 7,
                    OpenStreetMapUrl = "https://www.openstreetmap.org/?mlat=55.948611&mlon=-3.200833&zoom=15#map=15/55.9486/-3.2008",
                    GoogleMapsUrl = "https://www.google.com/maps/place/55%C2%B056'55.0%22N+3%C2%B012'03.0%22W/@55.948611,-3.200833,15z/data=!4m5!3m4!1s0x0:0x5eaa0460843a6e07!8m2!3d55.948611!4d-3.200833?hl=en",
                    Coordinates = "55.948611, -3.200833",
                    Street = "Castlehill",
                    Area = "Edinburgh",
                    Region = "",
                    Country = "Scotland",
                    Postcode = "EH1 2YT",
                    CountryIsoCode = "gb"
                }
            );

            modelBuilder.Entity<CastleComment>().HasData(
                new CastleComment
                {
                    Id = 1,
                    Author = "Sit Amet",
                    Heading = "Lorem ipsum dolor sit amet",
                    CommentText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus.",
                    CastleId = 1,
                },
                new CastleComment
                {
                    Id = 2,
                    Author = "Sit Amet",
                    Heading = "Lorem ipsum dolor sit amet",
                    CommentText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus.",
                    CastleId = 2,
                },
                new CastleComment
                {
                    Id = 3,
                    Author = "Sit Amet",
                    Heading = "Lorem ipsum dolor sit amet",
                    CommentText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus.",
                    CastleId = 2,
                },
                new CastleComment
                {
                    Id = 4,
                    Author = "Sit Amet",
                    Heading = "Lorem ipsum dolor sit amet",
                    CommentText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus.",
                    CastleId = 3,
                },
                new CastleComment
                {
                    Id = 5,
                    Author = "Sit Amet",
                    Heading = "Lorem ipsum dolor sit amet",
                    CommentText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus.",
                    CastleId = 4,
                },
                new CastleComment
                {
                    Id = 6,
                    Author = "Sit Amet",
                    Heading = "Lorem ipsum dolor sit amet",
                    CommentText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus.",
                    CastleId = 4,
                },
                new CastleComment
                {
                    Id = 7,
                    Author = "Sit Amet",
                    Heading = "Lorem ipsum dolor sit amet",
                    CommentText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus.",
                    CastleId = 4,
                },
                new CastleComment
                {
                    Id = 8,
                    Author = "Sit Amet",
                    Heading = "Lorem ipsum dolor sit amet",
                    CommentText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus.",
                    CastleId = 5,
                }
            );

            modelBuilder.Entity<TourComment>().HasData(
                new TourComment
                {
                    Id = 1,
                    Author = "Sit Amet",
                    Heading = "Lorem ipsum dolor sit amet",
                    CommentText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus.",
                    TourId = 1,
                    Rating = 3
                },
                new TourComment
                {
                    Id = 2,
                    Author = "Sit Amet",
                    Heading = "Lorem ipsum dolor sit amet",
                    CommentText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus.",
                    TourId = 1,
                    Rating = 4
                },
                new TourComment
                {
                    Id = 3,
                    Author = "Sit Amet",
                    Heading = "Lorem ipsum dolor sit amet",
                    CommentText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus.",
                    TourId = 2,
                    Rating = 5
                },
                new TourComment
                {
                    Id = 4,
                    Author = "Sit Amet",
                    Heading = "Lorem ipsum dolor sit amet",
                    CommentText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus.",
                    TourId = 3,
                    Rating = 2
                },
                new TourComment
                {
                    Id = 5,
                    Author = "Sit Amet",
                    Heading = "Lorem ipsum dolor sit amet",
                    CommentText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus.",
                    TourId = 3,
                    Rating = 5
                },
                new TourComment
                {
                    Id = 6,
                    Author = "Sit Amet",
                    Heading = "Lorem ipsum dolor sit amet",
                    CommentText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus.",
                    TourId = 3,
                    Rating = 4
                },
                new TourComment
                {
                    Id = 7,
                    Author = "Sit Amet",
                    Heading = "Lorem ipsum dolor sit amet",
                    CommentText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus.",
                    TourId = 4,
                    Rating = 4
                },
                new TourComment
                {
                    Id = 8,
                    Author = "Sit Amet",
                    Heading = "Lorem ipsum dolor sit amet",
                    CommentText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus.",
                    TourId = 4,
                    Rating = 3
                },
                new TourComment
                {
                    Id = 9,
                    Author = "Sit Amet",
                    Heading = "Lorem ipsum dolor sit amet",
                    CommentText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus.",
                    TourId = 5,
                    Rating = 5
                },
                new TourComment
                {
                    Id = 10,
                    Author = "Sit Amet",
                    Heading = "Lorem ipsum dolor sit amet",
                    CommentText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus.",
                    TourId = 5,
                    Rating = 4
                },
                new TourComment
                {
                    Id = 11,
                    Author = "Sit Amet",
                    Heading = "Lorem ipsum dolor sit amet",
                    CommentText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus.",
                    TourId = 6,
                    Rating = 3
                },
                new TourComment
                {
                    Id = 12,
                    Author = "Sit Amet",
                    Heading = "Lorem ipsum dolor sit amet",
                    CommentText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus.",
                    TourId = 7,
                    Rating = 3
                }
            );

            modelBuilder.Entity<OperatingTime>().HasData(
                new OperatingTime
                {
                    Id = 1,
                    CastleId = 1,
                    Time = "27 Mar - 30 Sep (Daily): 10am - 5pm"
                },
                new OperatingTime
                {
                    Id = 2,
                    CastleId = 1,
                    Time = "1 Oct - 31 Oct (Daily): 10am - 4pm"
                },
                new OperatingTime
                {
                    Id = 3,
                    CastleId = 1,
                    Time = "1 Nov - 31 Mar (Sat - Sun): 10am - 4pm"
                },
                new OperatingTime
                {
                    Id = 4,
                    CastleId = 1,
                    Time = "24 Dec - 26 Dec & 1 Jan: Cloased"
                },
                new OperatingTime
                {
                    Id = 5,
                    CastleId = 2,
                    Time = "27 Mar - 30 Sep (Daily): 10am - 5pm"
                },
                new OperatingTime
                {
                    Id = 6,
                    CastleId = 2,
                    Time = "1 Oct - 31 Oct (Daily): 10am - 4pm"
                },
                new OperatingTime
                {
                    Id = 7,
                    CastleId = 2,
                    Time = "1 Nov - 31 Mar (Sat - Sun): 10am - 4pm"
                },
                new OperatingTime
                {
                    Id = 8,
                    CastleId = 2,
                    Time = "24 Dec - 26 Dec & 1 Jan: Cloased"
                },
                new OperatingTime
                {
                    Id = 9,
                    CastleId = 3,
                    Time = "27 Mar - 30 Sep (Daily): 10am - 5pm"
                },
                new OperatingTime
                {
                    Id = 10,
                    CastleId = 3,
                    Time = "1 Oct - 31 Oct (Daily): 10am - 4pm"
                },
                new OperatingTime
                {
                    Id = 11,
                    CastleId = 3,
                    Time = "1 Nov - 31 Mar (Sat - Sun): 10am - 4pm"
                },
                new OperatingTime
                {
                    Id = 12,
                    CastleId = 3,
                    Time = "24 Dec - 26 Dec & 1 Jan: Cloased"
                },
                new OperatingTime
                {
                    Id = 13,
                    CastleId = 4,
                    Time = "27 Mar - 30 Sep (Daily): 10am - 5pm"
                },
                new OperatingTime
                {
                    Id = 14,
                    CastleId = 4,
                    Time = "1 Oct - 31 Oct (Daily): 10am - 4pm"
                },
                new OperatingTime
                {
                    Id = 15,
                    CastleId = 4,
                    Time = "1 Nov - 31 Mar (Sat - Sun): 10am - 4pm"
                },
                new OperatingTime
                {
                    Id = 16,
                    CastleId = 4,
                    Time = "24 Dec - 26 Dec & 1 Jan: Cloased"
                },
                new OperatingTime
                {
                    Id = 17,
                    CastleId = 5,
                    Time = "27 Mar - 30 Sep (Daily): 10am - 5pm"
                },
                new OperatingTime
                {
                    Id = 18,
                    CastleId = 5,
                    Time = "1 Oct - 31 Oct (Daily): 10am - 4pm"
                },
                new OperatingTime
                {
                    Id = 19,
                    CastleId = 5,
                    Time = "1 Nov - 31 Mar (Sat - Sun): 10am - 4pm"
                },
                new OperatingTime
                {
                    Id = 20,
                    CastleId = 5,
                    Time = "24 Dec - 26 Dec & 1 Jan: Cloased"
                },
                new OperatingTime
                {
                    Id = 21,
                    CastleId = 6,
                    Time = "27 Mar - 30 Sep (Daily): 10am - 5pm"
                },
                new OperatingTime
                {
                    Id = 22,
                    CastleId = 6,
                    Time = "1 Oct - 31 Oct (Daily): 10am - 4pm"
                },
                new OperatingTime
                {
                    Id = 23,
                    CastleId = 6,
                    Time = "1 Nov - 31 Mar (Sat - Sun): 10am - 4pm"
                },
                new OperatingTime
                {
                    Id = 24,
                    CastleId = 6,
                    Time = "24 Dec - 26 Dec & 1 Jan: Cloased"
                },
                new OperatingTime
                {
                    Id = 25,
                    TourId = 1,
                    Time = "Saturdays 10am - 3pm"
                },
                new OperatingTime
                {
                    Id = 26,
                    TourId = 2,
                    Time = "Saturdays 10am - 3pm"
                },
                new OperatingTime
                {
                    Id = 27,
                    TourId = 3,
                    Time = "Saturdays 10am - 3pm"
                },
                new OperatingTime
                {
                    Id = 28,
                    TourId = 4,
                    Time = "Saturdays 10am - 3pm"
                },
                new OperatingTime
                {
                    Id = 29,
                    TourId = 5,
                    Time = "Saturdays 10am - 3pm"
                },
                new OperatingTime
                {
                    Id = 30,
                    TourId = 6,
                    Time = "Saturdays 10am - 3pm"
                },
                new OperatingTime
                {
                    Id = 31,
                    TourId = 7,
                    Time = "Saturdays 10am - 3pm"
                },
                new OperatingTime
                {
                    Id = 32,
                    TourId = 8,
                    Time = "Saturdays 10am - 3pm"
                },
                new OperatingTime
                {
                    Id = 33,
                    TourId = 9,
                    Time = "Mondays - Saturdays 9am - 4pm"
                },
                new OperatingTime
                {
                    Id = 34,
                    TourId = 9,
                    Time = "Sundays 9am - 3pm"
                }
            );

            modelBuilder.Entity<Addon>().HasData(
                new Addon
                {
                    Id = 1,
                    TourId = 1,
                    Name = "Lorem ipsum dolor",
                    ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus. Vitae ultricies leo integer malesuada. Dui id ornare arcu odio. Sit amet purus gravida quis blandit turpis. Interdum posuere lorem ipsum dolor sit amet consectetur adipiscing elit. Arcu dictum varius duis at. Et malesuada fames ac turpis egestas maecenas. Mi bibendum neque egestas congue quisque egestas. Sagittis orci a scelerisque purus semper. Leo vel orci porta non pulvinar neque. Tortor pretium viverra suspendisse potenti nullam ac.",
                    Price = 2.00M
                },
                new Addon
                {
                    Id = 2,
                    TourId = 2,
                    Name = "Lorem ipsum dolor",
                    ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus. Vitae ultricies leo integer malesuada. Dui id ornare arcu odio. Sit amet purus gravida quis blandit turpis. Interdum posuere lorem ipsum dolor sit amet consectetur adipiscing elit. Arcu dictum varius duis at. Et malesuada fames ac turpis egestas maecenas. Mi bibendum neque egestas congue quisque egestas. Sagittis orci a scelerisque purus semper. Leo vel orci porta non pulvinar neque. Tortor pretium viverra suspendisse potenti nullam ac.",
                    Price = 2.00M
                },
                new Addon
                {
                    Id = 3,
                    TourId = 2,
                    Name = "Lorem ipsum dolor",
                    ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus. Vitae ultricies leo integer malesuada. Dui id ornare arcu odio. Sit amet purus gravida quis blandit turpis. Interdum posuere lorem ipsum dolor sit amet consectetur adipiscing elit. Arcu dictum varius duis at. Et malesuada fames ac turpis egestas maecenas. Mi bibendum neque egestas congue quisque egestas. Sagittis orci a scelerisque purus semper. Leo vel orci porta non pulvinar neque. Tortor pretium viverra suspendisse potenti nullam ac.",
                    Price = 4.00M
                },
                new Addon
                {
                    Id = 4,
                    TourId = 3,
                    Name = "Lorem ipsum dolor",
                    ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus. Vitae ultricies leo integer malesuada. Dui id ornare arcu odio. Sit amet purus gravida quis blandit turpis. Interdum posuere lorem ipsum dolor sit amet consectetur adipiscing elit. Arcu dictum varius duis at. Et malesuada fames ac turpis egestas maecenas. Mi bibendum neque egestas congue quisque egestas. Sagittis orci a scelerisque purus semper. Leo vel orci porta non pulvinar neque. Tortor pretium viverra suspendisse potenti nullam ac.",
                    Price = 2.50M
                },
                new Addon
                {
                    Id = 5,
                    TourId = 4,
                    Name = "Lorem ipsum dolor",
                    ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus. Vitae ultricies leo integer malesuada. Dui id ornare arcu odio. Sit amet purus gravida quis blandit turpis. Interdum posuere lorem ipsum dolor sit amet consectetur adipiscing elit. Arcu dictum varius duis at. Et malesuada fames ac turpis egestas maecenas. Mi bibendum neque egestas congue quisque egestas. Sagittis orci a scelerisque purus semper. Leo vel orci porta non pulvinar neque. Tortor pretium viverra suspendisse potenti nullam ac.",
                    Price = 12.00M
                },
                new Addon
                {
                    Id = 6,
                    TourId = 5,
                    Name = "Lorem ipsum dolor",
                    ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus. Vitae ultricies leo integer malesuada. Dui id ornare arcu odio. Sit amet purus gravida quis blandit turpis. Interdum posuere lorem ipsum dolor sit amet consectetur adipiscing elit. Arcu dictum varius duis at. Et malesuada fames ac turpis egestas maecenas. Mi bibendum neque egestas congue quisque egestas. Sagittis orci a scelerisque purus semper. Leo vel orci porta non pulvinar neque. Tortor pretium viverra suspendisse potenti nullam ac.",
                    Price = 1.00M
                },
                new Addon
                {
                    Id = 7,
                    TourId = 5,
                    Name = "Lorem ipsum dolor",
                    ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus. Vitae ultricies leo integer malesuada. Dui id ornare arcu odio. Sit amet purus gravida quis blandit turpis. Interdum posuere lorem ipsum dolor sit amet consectetur adipiscing elit. Arcu dictum varius duis at. Et malesuada fames ac turpis egestas maecenas. Mi bibendum neque egestas congue quisque egestas. Sagittis orci a scelerisque purus semper. Leo vel orci porta non pulvinar neque. Tortor pretium viverra suspendisse potenti nullam ac.",
                    Price = 4.00M
                },
                new Addon
                {
                    Id = 8,
                    TourId = 6,
                    Name = "Lorem ipsum dolor",
                    ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Elementum facilisis leo vel fringilla est ullamcorper. Integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus. Vitae ultricies leo integer malesuada. Dui id ornare arcu odio. Sit amet purus gravida quis blandit turpis. Interdum posuere lorem ipsum dolor sit amet consectetur adipiscing elit. Arcu dictum varius duis at. Et malesuada fames ac turpis egestas maecenas. Mi bibendum neque egestas congue quisque egestas. Sagittis orci a scelerisque purus semper. Leo vel orci porta non pulvinar neque. Tortor pretium viverra suspendisse potenti nullam ac.",
                    Price = 3.50M
                }
            );

            modelBuilder.Entity<Amenity>().HasData(
                new Amenity
                {
                    Id = 1,
                    CastleId = 1,
                    LoactionId = 1,
                    FacilityId = 6,
                    Name = "Lorem ipsum",
                    Url = "https://tytech.io",
                    Phone = "0456978722345",
                    Email = "info@tytech.io",
                    Note = "Vitae ultricies leo integer malesuada. Dui id ornare arcu odio.",
                },
                new Amenity
                {
                    Id = 2,
                    CastleId = 2,
                    LoactionId = 2,
                    FacilityId = 6,
                    Name = "Lorem ipsum",
                    Url = "https://tytech.io",
                    Phone = "0456978722345",
                    Email = "info@tytech.io",
                    Note = "Vitae ultricies leo integer malesuada. Dui id ornare arcu odio.",
                },
                new Amenity
                {
                    Id = 3,
                    CastleId = 3,
                    LoactionId = 3,
                    FacilityId = 3,
                    Name = "Lorem ipsum",
                    Url = "https://tytech.io",
                    Phone = "0456978722345",
                    Email = "info@tytech.io",
                    Note = "Vitae ultricies leo integer malesuada. Dui id ornare arcu odio.",
                }
            );

            modelBuilder.Entity<Facility>().HasData(
                new Facility
                {
                    Id = 1,
                    Type = "WiFi",
                    Icon = "oi oi-wifi",
                    Note = "Sit amet purus gravida quis blandit turpis."
                },
                new Facility
                {
                    Id = 2,
                    Type = "View Points",
                    Icon = "oi oi-aperture",
                    Note = "Sit amet purus gravida quis blandit turpis."
                },
                new Facility
                {
                    Id = 3,
                    Type = "Hearing Aided",
                    Icon = "oi oi-audio",
                    Note = "Sit amet purus gravida quis blandit turpis."
                },
                new Facility
                {
                    Id = 4,
                    Type = "Gift Shop",
                    Icon = "oi oi-basket",
                    Note = "Sit amet purus gravida quis blandit turpis."
                },
                new Facility
                {
                    Id = 5,
                    Type = "ATM",
                    Icon = "oi oi-british-pound",
                    Note = "Sit amet purus gravida quis blandit turpis."
                },
                new Facility
                {
                    Id = 6,
                    Type = "Resturant",
                    Icon = "oi oi-home",
                    Note = "Sit amet purus gravida quis blandit turpis."
                }
            );

            modelBuilder.SharedTypeEntity<Dictionary<string, object>>("CastleFacility")
                .HasData(
                    new { CastlesId = 1, FacilitiesId = 1 },
                    new { CastlesId = 1, FacilitiesId = 2 },
                    new { CastlesId = 1, FacilitiesId = 3 },
                    new { CastlesId = 2, FacilitiesId = 4 },
                    new { CastlesId = 2, FacilitiesId = 5 },
                    new { CastlesId = 2, FacilitiesId = 1 },
                    new { CastlesId = 3, FacilitiesId = 2 },
                    new { CastlesId = 3, FacilitiesId = 3 },
                    new { CastlesId = 4, FacilitiesId = 4 },
                    new { CastlesId = 4, FacilitiesId = 5 },
                    new { CastlesId = 4, FacilitiesId = 1 },
                    new { CastlesId = 4, FacilitiesId = 2 },
                    new { CastlesId = 5, FacilitiesId = 3 },
                    new { CastlesId = 5, FacilitiesId = 4 }
                );

            modelBuilder.SharedTypeEntity<Dictionary<string, object>>("FacilityTour")
                .HasData(
                    new { ToursId = 1, FacilitiesId = 1 },
                    new { ToursId = 1, FacilitiesId = 2 },
                    new { ToursId = 1, FacilitiesId = 3 },
                    new { ToursId = 2, FacilitiesId = 4 },
                    new { ToursId = 2, FacilitiesId = 5 },
                    new { ToursId = 2, FacilitiesId = 1 },
                    new { ToursId = 3, FacilitiesId = 2 },
                    new { ToursId = 3, FacilitiesId = 3 },
                    new { ToursId = 4, FacilitiesId = 4 },
                    new { ToursId = 4, FacilitiesId = 5 },
                    new { ToursId = 4, FacilitiesId = 1 },
                    new { ToursId = 4, FacilitiesId = 2 },
                    new { ToursId = 5, FacilitiesId = 3 },
                    new { ToursId = 6, FacilitiesId = 4 }
                );
        }
    }
}
