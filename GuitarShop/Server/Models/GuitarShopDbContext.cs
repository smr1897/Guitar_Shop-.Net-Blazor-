using GuitarShop.Shared;
using Microsoft.EntityFrameworkCore;

namespace GuitarShop.Server.Models
{
    public class GuitarShopDbContext : DbContext
    {
        public GuitarShopDbContext(DbContextOptions<GuitarShopDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Orangewood Americana OMD-22",
                    Description = "Unique 'mini dreadnought' body size provides portability and comfort while retaining a full-bodied sound.",
                    ImageUrl = "/Images/Guitars/orangewood-omd22.png",
                    Price = 500,
                    Quantity = 75,
                    CategoryId = 1,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 2,
                    Name = "Martin D-41 Special",
                    Description = "The pinnacle of acoustic guitar craftsmanship, a classic dreadnought shape with exquisite tonewoods and impeccable build quality.",
                    ImageUrl = "/Images/Guitars/martin-d41.png",
                    Price = 1500,
                    Quantity = 50,
                    CategoryId = 1,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 3,
                    Name = "Gibson J-45",
                    Description = "Warm and rich mahogany body delivers a timeless sound, favored by countless country and folk legends.",
                    ImageUrl = "/Images/Guitars/gibson-j45.png",
                    Price = 1200,
                    Quantity = 30,
                    CategoryId = 1,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 4,
                    Name = "Taylor 814ce",
                    Description = "Known for its crisp articulation and comfortable playability, this Grand Auditorium model features Taylor's innovative neck design and electronics.",
                    ImageUrl = "/Images/Guitars/taylor-814ce.png",
                    Price = 1800,
                    Quantity = 25,
                    CategoryId = 1,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 5,
                    Name = "Collings Traditional OM",
                    Description = "Renowned for their exceptional build quality and nuanced tone, these guitars are considered boutique works of art.",
                    ImageUrl = "/Images/Guitars/collings-om.png",
                    Price = 2500,
                    Quantity = 20,
                    CategoryId = 1,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 6,
                    Name = "Guild F-50 Jumbo",
                    Description = "Large body produces a booming voice, perfect for bluegrass strumming and flatpicking.",
                    ImageUrl = "/Images/Guitars/guild-f50.png",
                    Price = 1600,
                    Quantity = 35,
                    CategoryId = 1,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 7,
                    Name = "Santa Cruz D Indian Rosewood",
                    Description = "California-crafted masterpiece with a focus on sustain and tonal richness.",
                    ImageUrl = "/Images/Guitars/santa-cruz.png",
                    Price = 3000,
                    Quantity = 15,
                    CategoryId = 1,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 8,
                    Name = "Martin 000-18 Standard",
                    Description = "Smaller body size offers intimate tones and comfortable playing experience, favored by fingerstyle players.",
                    ImageUrl = "/Images/Guitars/martin-00018.png",
                    Price = 1700,
                    Quantity = 40,
                    CategoryId = 1,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 9,
                    Name = "Gibson Hummingbird",
                    Description = "Smaller slope-shouldered body provides a focused tone with punchy midrange, popular for blues and fingerpicking.",
                    ImageUrl = "/Images/Guitars/gibson-hummingbird.png",
                    Price = 1400,
                    Quantity = 28,
                    CategoryId = 1,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 10,
                    Name = "Yamaha FG800J",
                    Description = "Budget-friendly workhorse, known for its solid construction and reliable tone, perfect for beginners and seasoned players alike.",
                    ImageUrl = "/Images/Guitars/yamaha-fg800j.png",
                    Price = 500,
                    Quantity = 60,
                    CategoryId = 1,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 11,
                    Name = "Breedlove Discovery Concert CE",
                    Description = "Sustainable wood choices and innovative design combine for a unique voice and comfortable playing experience.",
                    ImageUrl = "/Images/Guitars/breedlove-discovery.png",
                    Price = 800,
                    Quantity = 45,
                    CategoryId = 1,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 12,
                    Name = "Seagull S6 Original",
                    Description = "Canadian-made guitar known for its balanced tone and playability, a popular choice for singer-songwriters.",
                    ImageUrl = "/Images/Guitars/seagull-s6.png",
                    Price = 700,
                    Quantity = 55,
                    CategoryId = 1,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 13,
                    Name = "Blueridge BR-160",
                    Description = "Vintage-inspired dreadnought at an affordable price, delivering classic warm tones and traditional vibe.",
                    ImageUrl = "/Images/Guitars/blueridge-br160.png",
                    Price = 900,
                    Quantity = 38,
                    CategoryId = 1,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 14,
                    Name = "Fender Paramount Dreadnought Pau Ferro",
                    Description = "Modern take on the classic design with bold aesthetics and versatile Fishman electronics.",
                    ImageUrl = "/Images/Guitars/fender-paramount.png",
                    Price = 1100,
                    Quantity = 32,
                    CategoryId = 1,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 15,
                    Name = "Epiphone Masterbilt DR-100",
                    Description = "Affordable option with solid mahogany body and warm, rich tone, inspired by Gibson's classic designs.",
                    ImageUrl = "/Images/Guitars/epiphone-masterbilt.png",
                    Price = 400,
                    Quantity = 70,
                    CategoryId = 1,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 16,
                    Name = "Fender Stratocaster",
                    Description = "The iconic Strat, used by countless legends like Jimi Hendrix, Eric Clapton, and Stevie Ray Vaughan. Features a classic single-coil pickup configuration and smooth playability.",
                    ImageUrl = "/Images/Guitars/fender1.png",
                    Price = 100,
                    Quantity = 100,
                    CategoryId = 1,
                    SubCategoryId = 2
                },
                new Product
                {
                    Id = 17,
                    Name = "Gibson Les Paul",
                    Description = "Another legendary axe, known for its warm, thick tone and sustain. Beloved by Slash, Jimmy Page, and countless rock and blues players.",
                    ImageUrl = "/Images/Guitars/gibson1.png",
                    Price = 100,
                    Quantity = 100,
                    CategoryId = 1,
                    SubCategoryId = 2
                },
                new Product
                {
                    Id = 18,
                    Name = "Gretsch G6120T-59 Rancher Falcon",
                    Description = "A unique hollow-body guitar with a distinctive twangy sound, popularized by artists like Duane Eddy and Jack White.",
                    ImageUrl = "/Images/Guitars/gretsch1.png",
                    Price = 100,
                    Quantity = 100,
                    CategoryId = 1,
                    SubCategoryId = 2
                },
                new Product
                {
                    Id = 19,
                    Name = "Epiphone SG",
                    Description = "Inspired by Gibson's SG design, this affordable option offers classic rock and blues tones with P-90 pickups.",
                    ImageUrl = "/Images/Guitars/epiphone1.png",
                    Price = 100,
                    Quantity = 100,
                    CategoryId = 1,
                    SubCategoryId = 2
                },
                new Product
                {
                    Id = 20,
                    Name = "Ibanez RG Series",
                    Description = "Modern shred machine with a fast neck, active pickups, and versatile tone, favored by metal and progressive rock guitarists.",
                    ImageUrl = "/Images/Guitars/ibanez1.png",
                    Price = 100,
                    Quantity = 100,
                    CategoryId = 1,
                    SubCategoryId = 2
                },
                new Product
                {
                    Id = 21,
                    Name = "Fender Telecaster",
                    Description = "Simple and straightforward, the Tele boasts a bright, twangy sound and is perfect for country, blues, and indie rock.",
                    ImageUrl = "/Images/Guitars/fendertel1.png",
                    Price = 100,
                    Quantity = 100,
                    CategoryId = 1,
                    SubCategoryId = 2
                },
                new Product
                {
                    Id = 22,
                    Name = "PRS Custom 24",
                    Description = "American-made masterpiece with a comfortable neck, stunning finishes, and versatile pickups for any genre.",
                    ImageUrl = "/Images/Guitars/prs1.png",
                    Price = 100,
                    Quantity = 100,
                    CategoryId = 1,
                    SubCategoryId = 2
                },
                new Product
                {
                    Id = 23,
                    Name = "Gibson ES-335",
                    Description = "Semi-hollow guitar with a rich, warm tone, perfect for jazz, blues, and classic rock.",
                    ImageUrl = "/Images/Guitars/gison2.png",
                    Price = 100,
                    Quantity = 100,
                    CategoryId = 1,
                    SubCategoryId = 2
                },
                new Product
                {
                    Id = 24,
                    Name = "Rickenbacker 330",
                    Description = "Distinctive 'jangly' sound and beautiful design, favored by The Beatles and The Who.",
                    ImageUrl = "/Images/Guitars/rickenbacker1.png",
                    Price = 100,
                    Quantity = 100,
                    CategoryId = 1,
                    SubCategoryId = 2
                },
                new Product
                {
                    Id = 25,
                    Name = "Epiphone Wilshire",
                    Description = "Affordable hollow-body option with P-90 pickups, delivering warm, woody tones for blues and rockabilly.",
                    ImageUrl = "/Images/Guitars/epiphone2.png",
                    Price = 100,
                    Quantity = 100,
                    CategoryId = 1,
                    SubCategoryId = 2
                },
                new Product
                {
                    Id = 26,
                    Name = "Charvel Pro-Mod DK24 HSS",
                    Description = "Modern metal guitar with a Floyd Rose tremolo system, screaming active pickups, and a sleek profile.",
                    ImageUrl = "/Images/Guitars/carvel1.png",
                    Price = 100,
                    Quantity = 100,
                    CategoryId = 1,
                    SubCategoryId = 2
                },
                new Product
                {
                    Id = 27,
                    Name = "Fender Jazzmaster",
                    Description = "Unique offset body and versatile pickup options, producing jazz-inspired clean tones and biting distortion.",
                    ImageUrl = "/Images/Guitars/fender2.png",
                    Price = 100,
                    Quantity = 100,
                    CategoryId = 1,
                    SubCategoryId = 2
                },
                new Product
                {
                    Id = 28,
                    Name = "Gretsch Jet Black Falcon",
                    Description = "A modern take on the classic Falcon, offering powerful P-90 pickups and a striking black finish.",
                    ImageUrl = "/Images/Guitars/gretsch2.png",
                    Price = 100,
                    Quantity = 100,
                    CategoryId = 1,
                    SubCategoryId = 2
                },
                new Product
                {
                    Id = 29,
                    Name = "Epiphone ES-175",
                    Description = "Elegant archtop jazz guitar with a warm, smooth tone, perfect for standards and classic jazz.",
                    ImageUrl = "/Images/Guitars/epiphone2.png",
                    Price = 100,
                    Quantity = 100,
                    CategoryId = 1,
                    SubCategoryId = 2
                },
                new Product
                {
                    Id = 30,
                    Name = "Schecter Hellraiser C-1",
                    Description = "Affordable shred machine with a comfortable C-shaped neck, EMG active pickups, and a devilish aesthetic.",
                    ImageUrl = "/Images/Guitars/schecter2.png",
                    Price = 100,
                    Quantity = 100,
                    CategoryId = 1,
                    SubCategoryId = 2
                },
                new Product
                {
                    Id = 31,
                    Name = "Fender Precision Bass",
                    Description = "The classic bass that revolutionized the world of electric bass guitars. Known for its deep, punchy tone and iconic design.",
                    ImageUrl = "/Images/BassGuitars/fender-precision.png",
                    Price = 900,
                    Quantity = 25,
                    CategoryId = 1,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 32,
                    Name = "Music Man StingRay",
                    Description = "Powerful and versatile, the StingRay is favored by many professional bassists for its distinctive tone and playability.",
                    ImageUrl = "/Images/BassGuitars/music-man-stingray.png",
                    Price = 1200,
                    Quantity = 20,
                    CategoryId = 1,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 33,
                    Name = "Ibanez SR500",
                    Description = "A popular choice for modern players, the SR500 features a sleek design, thin neck, and a wide range of tonal options.",
                    ImageUrl = "/Images/BassGuitars/ibanez-sr500.png",
                    Price = 800,
                    Quantity = 30,
                    CategoryId = 1,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 34,
                    Name = "Gibson Thunderbird",
                    Description = "Known for its unique body shape and powerful low-end, the Thunderbird is a rock and metal favorite.",
                    ImageUrl = "/Images/BassGuitars/gibson-thunderbird.png",
                    Price = 1500,
                    Quantity = 15,
                    CategoryId = 1,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 35,
                    Name = "Fender Jazz Bass",
                    Description = "Versatile and well-balanced, the Jazz Bass is appreciated for its smooth playing feel and tonal flexibility.",
                    ImageUrl = "/Images/BassGuitars/fender-jazz.png",
                    Price = 1000,
                    Quantity = 22,
                    CategoryId = 1,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 36,
                    Name = "Schecter Stiletto Custom",
                    Description = "Sleek and aggressive, the Stiletto Custom offers a modern design with high-output pickups for heavy tones.",
                    ImageUrl = "/Images/BassGuitars/schecter-stiletto.png",
                    Price = 1100,
                    Quantity = 18,
                    CategoryId = 1,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 37,
                    Name = "Rickenbacker 4003",
                    Description = "A classic choice with a distinct look and signature sound. The 4003 is known for its pronounced midrange and punch.",
                    ImageUrl = "/Images/BassGuitars/rickenbacker-4003.png",
                    Price = 1800,
                    Quantity = 12,
                    CategoryId = 1,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 38,
                    Name = "Yamaha BB434",
                    Description = "Combining classic design with modern features, the BB434 is a reliable and affordable option for bass players.",
                    ImageUrl = "/Images/BassGuitars/yamaha-bb434.png",
                    Price = 700,
                    Quantity = 28,
                    CategoryId = 1,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 39,
                    Name = "Epiphone Thunderbird IV",
                    Description = "An affordable take on the iconic Thunderbird design, offering a great balance of style and performance.",
                    ImageUrl = "/Images/BassGuitars/epiphone-thunderbird.png",
                    Price = 600,
                    Quantity = 35,
                    CategoryId = 1,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 40,
                    Name = "Sire Marcus Miller V7",
                    Description = "Designed in collaboration with Marcus Miller, this bass is known for its quality construction and versatile tonal options.",
                    ImageUrl = "/Images/BassGuitars/sire-marcus-miller.png",
                    Price = 1300,
                    Quantity = 16,
                    CategoryId = 1,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 41,
                    Name = "ESP LTD B-1004SE",
                    Description = "A high-end bass with premium features, the B-1004SE is crafted for professional players seeking top-tier performance.",
                    ImageUrl = "/Images/BassGuitars/esp-ltd-b1004se.png",
                    Price = 2000,
                    Quantity = 10,
                    CategoryId = 1,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 42,
                    Name = "Fodera Emperor Standard",
                    Description = "Handcrafted with precision, the Emperor Standard is a boutique bass known for its exquisite craftsmanship and tone.",
                    ImageUrl = "/Images/BassGuitars/fodera-emperor.png",
                    Price = 4000,
                    Quantity = 8,
                    CategoryId = 1,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 43,
                    Name = "Warwick Corvette Standard",
                    Description = "A German-made bass with a distinctive body shape, the Corvette Standard offers a powerful and clear sound.",
                    ImageUrl = "/Images/BassGuitars/warwick-corvette.png",
                    Price = 1600,
                    Quantity = 14,
                    CategoryId = 1,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 44,
                    Name = "Hofner Ignition Violin Bass",
                    Description = "Inspired by the iconic bass used by Paul McCartney, the Ignition Violin Bass offers a vintage look and feel.",
                    ImageUrl = "/Images/BassGuitars/hofner-ignition.png",
                    Price = 800,
                    Quantity = 20,
                    CategoryId = 1,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 45,
                    Name = "Squier Vintage Modified Jazz Bass",
                    Description = "An affordable alternative with classic Jazz Bass styling and versatile tonal options for various playing styles.",
                    ImageUrl = "/Images/BassGuitars/squier-jazz.png",
                    Price = 500,
                    Quantity = 30,
                    CategoryId = 1,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 46,
                    Name = "Ernie Ball Regular Slinky Electric Guitar Strings",
                    Description = "High-quality nickel-wound strings known for their balanced tone and durability.",
                    ImageUrl = "/Images/Accessories/strings1.png",
                    Price = 10,
                    Quantity = 50,
                    CategoryId = 1,
                    SubCategoryId = 4
                },
                new Product
                {
                    Id = 47,
                    Name = "D'Addario EJ16 Phosphor Bronze Acoustic Guitar Strings",
                    Description = "Popular acoustic guitar strings with a bright tone and excellent intonation.",
                    ImageUrl = "/Images/Accessories/strings2.png",
                    Price = 12,
                    Quantity = 40,
                    CategoryId = 1,
                    SubCategoryId = 4
                },
                new Product
                {
                    Id = 48,
                    Name = "Elixir Nanoweb Electric Guitar Strings",
                    Description = "Coated strings that provide extended life and a smooth feel, ideal for players looking for longevity.",
                    ImageUrl = "/Images/Accessories/strings3.png",
                    Price = 15,
                    Quantity = 30,
                    CategoryId = 1,
                    SubCategoryId = 4
                },
                new Product
                {
                    Id = 49,
                    Name = "GHS Boomers Roundwound Bass Guitar Strings",
                    Description = "Bright and punchy bass strings suitable for a variety of playing styles.",
                    ImageUrl = "/Images/Accessories/strings4.png",
                    Price = 20,
                    Quantity = 25,
                    CategoryId = 1,
                    SubCategoryId = 4
                },
                new Product
                {
                    Id = 50,
                    Name = "Thomastik-Infeld Jazz Swing Series Flatwound Strings",
                    Description = "Smooth and warm flatwound strings designed for jazz guitarists seeking a vintage tone.",
                    ImageUrl = "/Images/Accessories/strings5.png",
                    Price = 25,
                    Quantity = 20,
                    CategoryId = 1,
                    SubCategoryId = 4
                },
                new Product
                {
                    Id = 51,
                    Name = "Kyser Quick-Change Capo",
                    Description = "Easy-to-use capo with a quick-change design, perfect for fast adjustments during live performances.",
                    ImageUrl = "/Images/Accessories/capo1.png",
                    Price = 15,
                    Quantity = 30,
                    CategoryId = 1,
                    SubCategoryId = 4
                },
                new Product
                {
                    Id = 52,
                    Name = "Shubb Deluxe S-Series Steel String Capo",
                    Description = "High-quality capo with a smooth operation and adjustable tension for precise fretboard pressure.",
                    ImageUrl = "/Images/Accessories/capo2.png",
                    Price = 20,
                    Quantity = 25,
                    CategoryId = 1,
                    SubCategoryId = 4
                },
                new Product
                {
                    Id = 53,
                    Name = "G7th Performance 3 Capo",
                    Description = "Sleek capo with adaptive pressure technology, ensuring even pressure across the fretboard for optimal intonation.",
                    ImageUrl = "/Images/Accessories/capo3.png",
                    Price = 30,
                    Quantity = 20,
                    CategoryId = 1,
                    SubCategoryId = 4
                },
                new Product
                {
                    Id = 54,
                    Name = "D'Addario NS Artist Guitar Capo",
                    Description = "Lightweight capo with micrometer tension adjustment for precise and buzz-free fretting.",
                    ImageUrl = "/Images/Accessories/capo4.png",
                    Price = 25,
                    Quantity = 22,
                    CategoryId = 1,
                    SubCategoryId = 4
                },
                new Product
                {
                    Id = 55,
                    Name = "Planet Waves NS Tri-Action Capo",
                    Description = "Versatile capo with a unique design that accommodates both flat and curved fretboards.",
                    ImageUrl = "/Images/Accessories/capo5.png",
                    Price = 18,
                    Quantity = 28,
                    CategoryId = 1,
                    SubCategoryId = 4
                },
                new Product
                {
                    Id = 56,
                    Name = "Snark SN-5X Clip-On Tuner",
                    Description = "Clip-on tuner with a bright and easy-to-read display, suitable for guitars and other stringed instruments.",
                    ImageUrl = "/Images/Accessories/tuner1.png",
                    Price = 15,
                    Quantity = 30,
                    CategoryId = 1,
                    SubCategoryId = 4
                },
                new Product
                {
                    Id = 57,
                    Name = "Boss TU-3 Chromatic Tuner",
                    Description = "Sturdy pedal tuner with high accuracy and a durable design, ideal for gigging musicians.",
                    ImageUrl = "/Images/Accessories/tuner2.png",
                    Price = 80,
                    Quantity = 15,
                    CategoryId = 1,
                    SubCategoryId = 4
                },
                new Product
                {
                    Id = 58,
                    Name = "Korg Pitchblack Advance Pedal Tuner",
                    Description = "Sleek pedal tuner with a large LED display and true bypass for transparent signal when not in use.",
                    ImageUrl = "/Images/Accessories/tuner3.png",
                    Price = 65,
                    Quantity = 18,
                    CategoryId = 1,
                    SubCategoryId = 4
                },
                new Product
                {
                    Id = 59,
                    Name = "TC Electronic Polytune 3 Mini",
                    Description = "Compact polyphonic tuner with a small footprint, allowing for quick tuning of all strings at once.",
                    ImageUrl = "/Images/Accessories/tuner4.png",
                    Price = 90,
                    Quantity = 12,
                    CategoryId = 1,
                    SubCategoryId = 4
                },
                new Product
                {
                    Id = 60,
                    Name = "Peterson StroboClip HD Tuner",
                    Description = "High-definition clip-on tuner with unparalleled tuning accuracy and a variety of tuning presets.",
                    ImageUrl = "/Images/Accessories/tuner5.png",
                    Price = 100,
                    Quantity = 10,
                    CategoryId = 1,
                    SubCategoryId = 4
                },
                new Product
                {
                    Id = 61,
                    Name = "Yamaha U1 Upright Piano",
                    Description = "A classic and versatile upright piano known for its clear tone and responsive touch.",
                    ImageUrl = "/Images/Pianos/yamaha1.png",
                    Price = 5000,
                    Quantity = 10,
                    CategoryId = 2,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 62,
                    Name = "Steinway Model D Concert Grand Piano",
                    Description = "The gold standard in concert grand pianos, renowned for its exceptional sound and craftsmanship.",
                    ImageUrl = "/Images/Pianos/steinway1.png",
                    Price = 100000,
                    Quantity = 2,
                    CategoryId = 2,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 63,
                    Name = "Kawai K-500 Upright Piano",
                    Description = "A high-quality upright piano with a rich and expressive sound, suitable for both beginners and professionals.",
                    ImageUrl = "/Images/Pianos/kawai1.png",
                    Price = 6000,
                    Quantity = 8,
                    CategoryId = 2,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 64,
                    Name = "Bösendorfer 280VC Concert Grand Piano",
                    Description = "A prestigious concert grand piano with Viennese craftsmanship, offering a unique and resonant sound.",
                    ImageUrl = "/Images/Pianos/bosendorfer1.png",
                    Price = 120000,
                    Quantity = 1,
                    CategoryId = 2,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 65,
                    Name = "Roland RD-2000 Stage Piano",
                    Description = "A digital stage piano with versatile sounds, advanced features, and realistic weighted keyboard action.",
                    ImageUrl = "/Images/Pianos/roland1.png",
                    Price = 2500,
                    Quantity = 15,
                    CategoryId = 2,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 66,
                    Name = "C. Bechstein A 192 Grand Piano",
                    Description = "A German-made grand piano with a distinguished heritage and a warm, singing tone.",
                    ImageUrl = "/Images/Pianos/bechstein1.png",
                    Price = 80000,
                    Quantity = 3,
                    CategoryId = 2,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 67,
                    Name = "Korg LP-380 Digital Piano",
                    Description = "A compact and stylish digital piano with authentic piano sounds and a responsive hammer-action keyboard.",
                    ImageUrl = "/Images/Pianos/korg1.png",
                    Price = 1200,
                    Quantity = 20,
                    CategoryId = 2,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 68,
                    Name = "Blüthner Model 1 Grand Piano",
                    Description = "A German grand piano known for its clarity and singing tone, featuring the innovative Aliquot system.",
                    ImageUrl = "/Images/Pianos/bluthner1.png",
                    Price = 90000,
                    Quantity = 2,
                    CategoryId = 2,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 69,
                    Name = "Casio Privia PX-870 Digital Piano",
                    Description = "An affordable digital piano with realistic piano sound and feel, suitable for practice and performance.",
                    ImageUrl = "/Images/Pianos/casio1.png",
                    Price = 800,
                    Quantity = 30,
                    CategoryId = 2,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 70,
                    Name = "Bechstein Academy A 3 Upright Piano",
                    Description = "A high-quality upright piano designed for both beginners and advanced players, delivering rich tones.",
                    ImageUrl = "/Images/Pianos/bechstein2.png",
                    Price = 7000,
                    Quantity = 12,
                    CategoryId = 2,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 71,
                    Name = "Yamaha CP88 Stage Piano",
                    Description = "A professional stage piano with authentic acoustic and electric piano sounds, perfect for live performances.",
                    ImageUrl = "/Images/Pianos/yamaha2.png",
                    Price = 2500,
                    Quantity = 18,
                    CategoryId = 2,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 72,
                    Name = "Kawai ES110 Digital Piano",
                    Description = "A portable and budget-friendly digital piano with responsive keys and a variety of built-in sounds.",
                    ImageUrl = "/Images/Pianos/kawai2.png",
                    Price = 700,
                    Quantity = 25,
                    CategoryId = 2,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 73,
                    Name = "Fazioli F308 Concert Grand Piano",
                    Description = "An Italian concert grand piano known for its craftsmanship, power, and dynamic range.",
                    ImageUrl = "/Images/Pianos/fazioli1.png",
                    Price = 150000,
                    Quantity = 1,
                    CategoryId = 2,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 74,
                    Name = "Nord Stage 3 Compact Digital Piano",
                    Description = "A versatile digital stage piano with a wide range of sounds and intuitive controls for live performances.",
                    ImageUrl = "/Images/Pianos/nord1.png",
                    Price = 3000,
                    Quantity = 15,
                    CategoryId = 2,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 75,
                    Name = "Young Chang Y-118 Upright Piano",
                    Description = "An affordable and reliable upright piano suitable for students and home use, delivering a warm tone.",
                    ImageUrl = "/Images/Pianos/youngchang1.png",
                    Price = 3000,
                    Quantity = 10,
                    CategoryId = 2,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 76,
                    Name = "Moog Subsequent 37 Analog Synthesizer",
                    Description = "A powerful analog synthesizer with rich sound and versatile controls, perfect for creating iconic Moog tones.",
                    ImageUrl = "/Images/Synthesizers/moog1.png",
                    Price = 2500,
                    Quantity = 8,
                    CategoryId = 2,
                    SubCategoryId = 2
                },
                new Product
                {
                    Id = 77,
                    Name = "Korg Minilogue XD Polyphonic Analog Synthesizer",
                    Description = "A compact polyphonic analog synthesizer with digital effects and a customizable digital oscillator.",
                    ImageUrl = "/Images/Synthesizers/korg1.png",
                    Price = 800,
                    Quantity = 15,
                    CategoryId = 2,
                    SubCategoryId = 2
                },
                new Product
                {
                    Id = 78,
                    Name = "Dave Smith Instruments Prophet Rev2 Synthesizer",
                    Description = "A 16-voice analog synthesizer with a versatile sound engine and expansive modulation possibilities.",
                    ImageUrl = "/Images/Synthesizers/davesmith1.png",
                    Price = 2000,
                    Quantity = 10,
                    CategoryId = 2,
                    SubCategoryId = 2
                },
                new Product
                {
                    Id = 79,
                    Name = "Roland JU-06A Boutique Synthesizer Module",
                    Description = "A compact module that recreates the classic Juno-60 and Juno-106 synthesizer sounds with modern features.",
                    ImageUrl = "/Images/Synthesizers/roland1.png",
                    Price = 350,
                    Quantity = 20,
                    CategoryId = 2,
                    SubCategoryId = 2
                },
                new Product
                {
                    Id = 80,
                    Name = "Arturia MicroFreak Hybrid Synthesizer",
                    Description = "A unique hybrid synthesizer with a digital oscillator and analog filter, offering a wide sonic palette.",
                    ImageUrl = "/Images/Synthesizers/arturia1.png",
                    Price = 400,
                    Quantity = 18,
                    CategoryId = 2,
                    SubCategoryId = 2
                },
                new Product
                {
                    Id = 81,
                    Name = "Novation Peak 8-Voice Polyphonic Synthesizer",
                    Description = "A powerful polyphonic synthesizer with analog and digital oscillators, delivering versatile sound design capabilities.",
                    ImageUrl = "/Images/Synthesizers/novation1.png",
                    Price = 1800,
                    Quantity = 7,
                    CategoryId = 2,
                    SubCategoryId = 2
                },
                new Product
                {
                    Id = 82,
                    Name = "Behringer DeepMind 12 Analog Synthesizer",
                    Description = "A 12-voice analog synthesizer with a rich and warm sound, featuring deep modulation possibilities.",
                    ImageUrl = "/Images/Synthesizers/behringer1.png",
                    Price = 900,
                    Quantity = 12,
                    CategoryId = 2,
                    SubCategoryId = 2
                },
                new Product
                {
                    Id = 83,
                    Name = "Yamaha Montage 8 Flagship Synthesizer",
                    Description = "A flagship synthesizer with advanced FM-X and AWM2 sound engines, providing unparalleled sound quality.",
                    ImageUrl = "/Images/Synthesizers/yamaha1.png",
                    Price = 3000,
                    Quantity = 5,
                    CategoryId = 2,
                    SubCategoryId = 2
                },
                new Product
                {
                    Id = 84,
                    Name = "Sequential Prophet X Hybrid Synthesizer",
                    Description = "A hybrid synthesizer with sample-based oscillators and analog filters, offering a wide range of sonic possibilities.",
                    ImageUrl = "/Images/Synthesizers/sequential1.png",
                    Price = 2500,
                    Quantity = 8,
                    CategoryId = 2,
                    SubCategoryId = 2
                },
                new Product
                {
                    Id = 85,
                    Name = "Korg Wavestate Wave-Sequencing Synthesizer",
                    Description = "A wave-sequencing synthesizer that reimagines Korg's classic Wavestation, providing evolving and dynamic sounds.",
                    ImageUrl = "/Images/Synthesizers/korg2.png",
                    Price = 1200,
                    Quantity = 10,
                    CategoryId = 2,
                    SubCategoryId = 2
                },
                new Product
                {
                    Id = 86,
                    Name = "Dave Smith Instruments OB-6 Analog Synthesizer",
                    Description = "A collaboration between Dave Smith and Tom Oberheim, this analog synthesizer offers classic Oberheim sound with modern features.",
                    ImageUrl = "/Images/Synthesizers/davesmith2.png",
                    Price = 2800,
                    Quantity = 6,
                    CategoryId = 2,
                    SubCategoryId = 2
                },
                new Product
                {
                    Id = 87,
                    Name = "Modal Electronics Argon8 Polyphonic Synthesizer",
                    Description = "An 8-voice wavetable synthesizer with a modern design, intuitive controls, and a wide range of sonic possibilities.",
                    ImageUrl = "/Images/Synthesizers/modal1.png",
                    Price = 1000,
                    Quantity = 15,
                    CategoryId = 2,
                    SubCategoryId = 2
                },
                new Product
                {
                    Id = 88,
                    Name = "Access Virus TI2 Desktop Synthesizer",
                    Description = "A desktop version of the popular Virus TI2 synthesizer, known for its powerful sound and versatile synthesis engine.",
                    ImageUrl = "/Images/Synthesizers/access1.png",
                    Price = 2200,
                    Quantity = 5,
                    CategoryId = 2,
                    SubCategoryId = 2
                },
                new Product
                {
                    Id = 89,
                    Name = "Waldorf Quantum Synthesizer",
                    Description = "A flagship synthesizer from Waldorf with a unique hybrid architecture, offering deep sound design possibilities.",
                    ImageUrl = "/Images/Synthesizers/waldorf1.png",
                    Price = 3500,
                    Quantity = 3,
                    CategoryId = 2,
                    SubCategoryId = 2
                },
                new Product
                {
                    Id = 90,
                    Name = "Nord Lead A1 Analog Modeling Synthesizer",
                    Description = "An analog modeling synthesizer with a streamlined interface and advanced sound-shaping capabilities.",
                    ImageUrl = "/Images/Synthesizers/nord1.png",
                    Price = 1700,
                    Quantity = 9,
                    CategoryId = 2,
                    SubCategoryId = 2
                },
                new Product
                {
                    Id = 91,
                    Name = "Vox Continental 73-Key Combo Organ",
                    Description = "A legendary combo organ known for its distinctive sound, played by iconic musicians of the '60s and '70s.",
                    ImageUrl = "/Images/ComboOrgans/vox1.png",
                    Price = 1800,
                    Quantity = 7,
                    CategoryId = 2,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 92,
                    Name = "Farfisa Compact Deluxe Combo Organ",
                    Description = "A classic Italian combo organ with a bright and percussive sound, popularized in pop and rock music.",
                    ImageUrl = "/Images/ComboOrgans/farfisa1.png",
                    Price = 2000,
                    Quantity = 5,
                    CategoryId = 2,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 93,
                    Name = "Hammond XK-5 Portable Organ",
                    Description = "A modern portable organ with authentic Hammond tonewheel sound and advanced digital features.",
                    ImageUrl = "/Images/ComboOrgans/hammond1.png",
                    Price = 2500,
                    Quantity = 8,
                    CategoryId = 2,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 94,
                    Name = "Nord Electro 6D 73-Key Stage Piano/Organ",
                    Description = "A versatile stage instrument featuring classic organ sounds, piano, and electric piano tones.",
                    ImageUrl = "/Images/ComboOrgans/nord1.png",
                    Price = 2400,
                    Quantity = 10,
                    CategoryId = 2,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 95,
                    Name = "Ace Tone TOP-5 Combo Organ",
                    Description = "A vintage combo organ with a warm and fuzzy sound, appreciated for its retro character.",
                    ImageUrl = "/Images/ComboOrgans/acetone1.png",
                    Price = 1500,
                    Quantity = 6,
                    CategoryId = 2,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 96,
                    Name = "Korg CX-3 Tonewheel Organ",
                    Description = "A tonewheel organ with authentic rotary speaker emulation, delivering classic organ tones.",
                    ImageUrl = "/Images/ComboOrgans/korg1.png",
                    Price = 1600,
                    Quantity = 9,
                    CategoryId = 2,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 97,
                    Name = "GEM Continental 61 Combo Organ",
                    Description = "A compact combo organ with a variety of vintage sounds, suitable for stage and studio use.",
                    ImageUrl = "/Images/ComboOrgans/gem1.png",
                    Price = 1200,
                    Quantity = 12,
                    CategoryId = 2,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 98,
                    Name = "Crumar Mojo 61 Digital Organ",
                    Description = "A compact and lightweight digital organ with authentic tonewheel emulation and modern features.",
                    ImageUrl = "/Images/ComboOrgans/crumar1.png",
                    Price = 1300,
                    Quantity = 15,
                    CategoryId = 2,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 99,
                    Name = "Roland VR-730 V-Combo Organ",
                    Description = "A performance-oriented combo organ with authentic tonewheel sounds and additional instrument sounds.",
                    ImageUrl = "/Images/ComboOrgans/roland1.png",
                    Price = 2200,
                    Quantity = 7,
                    CategoryId = 2,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 100,
                    Name = "Nord C2D 61-Key Combo Organ",
                    Description = "A dual manual combo organ featuring a comprehensive selection of organ sounds and drawbars.",
                    ImageUrl = "/Images/ComboOrgans/nord2.png",
                    Price = 2800,
                    Quantity = 6,
                    CategoryId = 2,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 101,
                    Name = "Viscount Legend '70s Portable Organ",
                    Description = "A portable organ inspired by the sound of classic combo organs from the 1970s.",
                    ImageUrl = "/Images/ComboOrgans/viscount1.png",
                    Price = 1700,
                    Quantity = 10,
                    CategoryId = 2,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 102,
                    Name = "Kawai VPC1 Virtual Piano Controller",
                    Description = "A MIDI controller designed for virtual piano software, providing an authentic piano playing experience.",
                    ImageUrl = "/Images/ComboOrgans/kawai1.png",
                    Price = 1200,
                    Quantity = 15,
                    CategoryId = 2,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 103,
                    Name = "Clavia Nord Stage 3 Compact",
                    Description = "A compact stage instrument with a wide range of sounds, including organ, piano, and synth tones.",
                    ImageUrl = "/Images/ComboOrgans/nord3.png",
                    Price = 3000,
                    Quantity = 8,
                    CategoryId = 2,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 104,
                    Name = "Kurzweil PC4 Performance Controller",
                    Description = "A performance-oriented controller with a variety of sounds, including realistic organ and piano tones.",
                    ImageUrl = "/Images/ComboOrgans/kurzweil1.png",
                    Price = 2500,
                    Quantity = 10,
                    CategoryId = 2,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 105,
                    Name = "Hammond SKX Stage Keyboard",
                    Description = "A versatile stage keyboard featuring authentic Hammond organ sounds and a wide range of instrument tones.",
                    ImageUrl = "/Images/ComboOrgans/hammond2.png",
                    Price = 2300,
                    Quantity = 9,
                    CategoryId = 2,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 106,
                    Name = "Yamaha PSR-SX900 Arranger Workstation",
                    Description = "A powerful arranger workstation with a wide range of voices, styles, and advanced performance features.",
                    ImageUrl = "/Images/Arrangers/yamaha1.png",
                    Price = 2500,
                    Quantity = 10,
                    CategoryId = 2,
                    SubCategoryId = 4
                },
                new Product
                {
                    Id = 107,
                    Name = "Korg Pa600 Professional Arranger",
                    Description = "A professional arranger keyboard with a vast library of sounds, styles, and easy-to-use features.",
                    ImageUrl = "/Images/Arrangers/korg1.png",
                    Price = 1800,
                    Quantity = 8,
                    CategoryId = 2,
                    SubCategoryId = 4
                },
                new Product
                {
                    Id = 108,
                    Name = "Roland E-A7 Expandable Arranger Keyboard",
                    Description = "An expandable arranger keyboard with a wide variety of realistic sounds, backing styles, and versatile features.",
                    ImageUrl = "/Images/Arrangers/roland1.png",
                    Price = 2200,
                    Quantity = 12,
                    CategoryId = 2,
                    SubCategoryId = 4
                },
                new Product
                {
                    Id = 109,
                    Name = "Ketron SD9 Professional Arranger Module",
                    Description = "A compact arranger module with high-quality sounds and styles, designed for professional performers.",
                    ImageUrl = "/Images/Arrangers/ketron1.png",
                    Price = 2800,
                    Quantity = 6,
                    CategoryId = 2,
                    SubCategoryId = 4
                },
                new Product
                {
                    Id = 110,
                    Name = "Casio MZ-X300 Arranger Keyboard",
                    Description = "An arranger keyboard with a diverse range of sounds, rhythms, and recording features, suitable for various genres.",
                    ImageUrl = "/Images/Arrangers/casio1.png",
                    Price = 1600,
                    Quantity = 15,
                    CategoryId = 2,
                    SubCategoryId = 4
                },
                new Product
                {
                    Id = 111,
                    Name = "Korg Pa1000 Professional Arranger",
                    Description = "A professional arranger keyboard with advanced sound technology, extensive styles, and intuitive controls.",
                    ImageUrl = "/Images/Arrangers/korg2.png",
                    Price = 3000,
                    Quantity = 7,
                    CategoryId = 2,
                    SubCategoryId = 4
                },
                new Product
                {
                    Id = 112,
                    Name = "Yamaha Genos Digital Workstation",
                    Description = "A flagship digital workstation with top-tier sounds, features, and a user-friendly interface for professional performers.",
                    ImageUrl = "/Images/Arrangers/yamaha2.png",
                    Price = 3500,
                    Quantity = 5,
                    CategoryId = 2,
                    SubCategoryId = 4
                },
                new Product
                {
                    Id = 113,
                    Name = "Roland BK-9 Backing Keyboard",
                    Description = "A versatile backing keyboard with a wide selection of sounds, styles, and performance features.",
                    ImageUrl = "/Images/Arrangers/roland2.png",
                    Price = 2400,
                    Quantity = 9,
                    CategoryId = 2,
                    SubCategoryId = 4
                },
                new Product
                {
                    Id = 114,
                    Name = "Ketron SD7 Professional Arranger Module",
                    Description = "A compact arranger module with high-quality sounds and styles, designed for live performances and studio use.",
                    ImageUrl = "/Images/Arrangers/ketron2.png",
                    Price = 2600,
                    Quantity = 8,
                    CategoryId = 2,
                    SubCategoryId = 4
                },
                new Product
                {
                    Id = 115,
                    Name = "Casio CT-X5000 Portable Keyboard",
                    Description = "A portable keyboard with advanced arranger features, including a vast library of tones and rhythms.",
                    ImageUrl = "/Images/Arrangers/casio2.png",
                    Price = 1200,
                    Quantity = 18,
                    CategoryId = 2,
                    SubCategoryId = 4
                },
                new Product
                {
                    Id = 116,
                    Name = "Korg Pa4X 76-Key Professional Arranger",
                    Description = "A professional arranger keyboard with advanced sound technology, extensive styles, and a user-friendly interface.",
                    ImageUrl = "/Images/Arrangers/korg3.png",
                    Price = 3800,
                    Quantity = 4,
                    CategoryId = 2,
                    SubCategoryId = 4
                },
                new Product
                {
                    Id = 117,
                    Name = "Yamaha PSR-S775 Arranger Workstation",
                    Description = "An arranger workstation with a wide range of sounds, styles, and features for live performances and music production.",
                    ImageUrl = "/Images/Arrangers/yamaha3.png",
                    Price = 2000,
                    Quantity = 11,
                    CategoryId = 2,
                    SubCategoryId = 4
                },
                new Product
                {
                    Id = 118,
                    Name = "Roland E-X30 Arranger Keyboard",
                    Description = "A compact arranger keyboard with a variety of sounds, styles, and features, suitable for beginners and advanced players.",
                    ImageUrl = "/Images/Arrangers/roland3.png",
                    Price = 1000,
                    Quantity = 20,
                    CategoryId = 2,
                    SubCategoryId = 4
                },
                new Product
                {
                    Id = 119,
                    Name = "Ketron Audya 5 Arranger Module",
                    Description = "A versatile arranger module with a wide range of sounds and advanced features, designed for professional musicians.",
                    ImageUrl = "/Images/Arrangers/ketron3.png",
                    Price = 3200,
                    Quantity = 6,
                    CategoryId = 2,
                    SubCategoryId = 4
                },
                new Product
                {
                    Id = 120,
                    Name = "Casio WK-7600 Workstation Keyboard",
                    Description = "A workstation keyboard with arranger features, including a wide selection of tones, rhythms, and recording capabilities.",
                    ImageUrl = "/Images/Arrangers/casio3.png",
                    Price = 800,
                    Quantity = 25,
                    CategoryId = 2,
                    SubCategoryId = 4
                },
                new Product
                {
                    Id = 121,
                    Name = "Pearl Export Series 5-Piece Drum Set",
                    Description = "A popular and versatile drum set known for its durability and balanced sound, suitable for various genres.",
                    ImageUrl = "/Images/DrumSets/pearl1.png",
                    Price = 800,
                    Quantity = 15,
                    CategoryId = 3,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 122,
                    Name = "Mapex Armory Series 6-Piece Studioease Shell Pack",
                    Description = "A high-quality shell pack designed for studio recording, featuring versatile tonewoods and precise construction.",
                    ImageUrl = "/Images/DrumSets/mapex1.png",
                    Price = 1200,
                    Quantity = 10,
                    CategoryId = 3,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 123,
                    Name = "DW Collector's Series 4-Piece Shell Pack",
                    Description = "A premium drum set crafted with high-quality materials and meticulous attention to detail, favored by professionals.",
                    ImageUrl = "/Images/DrumSets/dw1.png",
                    Price = 2500,
                    Quantity = 8,
                    CategoryId = 3,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 124,
                    Name = "Tama Superstar Classic 7-Piece Shell Pack",
                    Description = "A classic drum set with a powerful and focused sound, featuring high-quality maple shells and robust hardware.",
                    ImageUrl = "/Images/DrumSets/tama1.png",
                    Price = 1500,
                    Quantity = 12,
                    CategoryId = 3,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 125,
                    Name = "Gretsch Catalina Maple 6-Piece Shell Pack",
                    Description = "A versatile maple drum set with warm tones and reliable hardware, suitable for various musical styles.",
                    ImageUrl = "/Images/DrumSets/gretsch1.png",
                    Price = 1100,
                    Quantity = 10,
                    CategoryId = 3,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 126,
                    Name = "Sonor AQ2 Martini 4-Piece Shell Pack",
                    Description = "A compact and portable drum set with a punchy sound, ideal for small venues and tight spaces.",
                    ImageUrl = "/Images/DrumSets/sonor1.png",
                    Price = 700,
                    Quantity = 18,
                    CategoryId = 3,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 127,
                    Name = "Ludwig Classic Maple 3-Piece Fab Shell Pack",
                    Description = "A classic maple shell pack with timeless tones, ideal for vintage enthusiasts and modern drummers alike.",
                    ImageUrl = "/Images/DrumSets/ludwig1.png",
                    Price = 1800,
                    Quantity = 8,
                    CategoryId = 3,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 128,
                    Name = "PDP Concept Maple 5-Piece Shell Pack",
                    Description = "A budget-friendly maple drum set with professional features, offering a balanced and versatile sound.",
                    ImageUrl = "/Images/DrumSets/pdp1.png",
                    Price = 900,
                    Quantity = 14,
                    CategoryId = 3,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 129,
                    Name = "Craviotto Custom Shop Maple/Walnut 4-Piece Shell Pack",
                    Description = "A handcrafted drum set with a unique maple/walnut blend, delivering a warm and rich sonic character.",
                    ImageUrl = "/Images/DrumSets/craviotto1.png",
                    Price = 3200,
                    Quantity = 6,
                    CategoryId = 3,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 130,
                    Name = "Yamaha Stage Custom Birch 5-Piece Shell Pack",
                    Description = "A reliable birch drum set known for its clear and focused sound, suitable for various playing styles.",
                    ImageUrl = "/Images/DrumSets/yamaha1.png",
                    Price = 1000,
                    Quantity = 12,
                    CategoryId = 3,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 131,
                    Name = "Mapex Saturn V MH Exotic 4-Piece Shell Pack",
                    Description = "An exotic wood shell pack with a combination of maple and walnut, providing a unique and powerful sound.",
                    ImageUrl = "/Images/DrumSets/mapex2.png",
                    Price = 2200,
                    Quantity = 9,
                    CategoryId = 3,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 132,
                    Name = "Gibraltar GRS-850DB Rack System",
                    Description = "A versatile drum rack system with adjustable mounts, ideal for customizing and organizing drum setups.",
                    ImageUrl = "/Images/DrumSets/gibraltar1.png",
                    Price = 300,
                    Quantity = 25,
                    CategoryId = 3,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 133,
                    Name = "Remo Silentstroke Drumhead Pack",
                    Description = "A set of silent drumheads designed for quiet practicing, featuring a realistic feel and reduced volume.",
                    ImageUrl = "/Images/DrumSets/remo1.png",
                    Price = 80,
                    Quantity = 30,
                    CategoryId = 3,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 134,
                    Name = "Zildjian K Custom Dark Cymbal Set",
                    Description = "A set of dark and expressive cymbals from Zildjian's K Custom series, suitable for various musical genres.",
                    ImageUrl = "/Images/DrumSets/zildjian1.png",
                    Price = 700,
                    Quantity = 15,
                    CategoryId = 3,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 135,
                    Name = "Vic Firth 5A American Classic Drumsticks",
                    Description = "A pair of classic drumsticks from Vic Firth, known for their balanced feel and versatility.",
                    ImageUrl = "/Images/DrumSets/vicfirth1.png",
                    Price = 10,
                    Quantity = 50,
                    CategoryId = 3,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 136,
                    Name = "Roland TD-17KVX V-Drums Electronic Drum Kit",
                    Description = "A high-quality electronic drum kit with advanced sound technology, expressive playing feel, and versatile features.",
                    ImageUrl = "/Images/ElectronicDrumSets/roland1.png",
                    Price = 1500,
                    Quantity = 10,
                    CategoryId = 3,
                    SubCategoryId = 2
                },
                new Product
                {
                    Id = 137,
                    Name = "Yamaha DTX522K Electronic Drum Set",
                    Description = "An intermediate-level electronic drum set with realistic drum and cymbal pads, designed for quiet practice and live performances.",
                    ImageUrl = "/Images/ElectronicDrumSets/yamaha1.png",
                    Price = 1100,
                    Quantity = 8,
                    CategoryId = 3,
                    SubCategoryId = 2
                },
                new Product
                {
                    Id = 138,
                    Name = "Alesis Nitro Mesh Kit Electronic Drum Set",
                    Description = "An affordable electronic drum set with mesh drum heads for a natural playing experience, suitable for beginners and practice sessions.",
                    ImageUrl = "/Images/ElectronicDrumSets/alesis1.png",
                    Price = 500,
                    Quantity = 15,
                    CategoryId = 3,
                    SubCategoryId = 2
                },
                new Product
                {
                    Id = 139,
                    Name = "Roland TD-27KV V-Drums Electronic Drum Kit",
                    Description = "A professional-grade electronic drum kit with advanced sound processing, realistic response, and customizable options.",
                    ImageUrl = "/Images/ElectronicDrumSets/roland2.png",
                    Price = 3000,
                    Quantity = 12,
                    CategoryId = 3,
                    SubCategoryId = 2
                },
                new Product
                {
                    Id = 140,
                    Name = "Alesis Strike Pro Special Edition Electronic Drum Kit",
                    Description = "A premium electronic drum set with multiple mesh pads, advanced sound module, and extensive customization options.",
                    ImageUrl = "/Images/ElectronicDrumSets/alesis2.png",
                    Price = 2500,
                    Quantity = 8,
                    CategoryId = 3,
                    SubCategoryId = 2
                },
                new Product
                {
                    Id = 141,
                    Name = "Yamaha EAD10 Electronic Acoustic Drum Module",
                    Description = "An innovative drum module that transforms acoustic drum kits into electronic instruments, featuring studio-quality effects.",
                    ImageUrl = "/Images/ElectronicDrumSets/yamaha2.png",
                    Price = 400,
                    Quantity = 20,
                    CategoryId = 3,
                    SubCategoryId = 2
                },
                new Product
                {
                    Id = 142,
                    Name = "Simmons SD600 Electronic Drum Kit",
                    Description = "An intermediate-level electronic drum kit with a wide range of sounds, responsive pads, and a sturdy rack.",
                    ImageUrl = "/Images/ElectronicDrumSets/simmons1.png",
                    Price = 800,
                    Quantity = 18,
                    CategoryId = 3,
                    SubCategoryId = 2
                },
                new Product
                {
                    Id = 143,
                    Name = "Pearl e/MERGE EM53H Electronic Drum Set",
                    Description = "A flagship electronic drum set with advanced sensor technology, responsive pads, and a versatile sound module.",
                    ImageUrl = "/Images/ElectronicDrumSets/pearl1.png",
                    Price = 3500,
                    Quantity = 6,
                    CategoryId = 3,
                    SubCategoryId = 2
                },
                new Product
                {
                    Id = 144,
                    Name = "KAT Percussion KT4 Advanced Electronic Drum Set",
                    Description = "A feature-rich electronic drum set with responsive pads, realistic drum sounds, and advanced control options.",
                    ImageUrl = "/Images/ElectronicDrumSets/kat1.png",
                    Price = 2000,
                    Quantity = 10,
                    CategoryId = 3,
                    SubCategoryId = 2
                },
                new Product
                {
                    Id = 145,
                    Name = "Roland TD-1DMK V-Drums Electronic Drum Kit",
                    Description = "A compact and affordable electronic drum kit with a solid frame, responsive pads, and built-in coaching functions.",
                    ImageUrl = "/Images/ElectronicDrumSets/roland3.png",
                    Price = 700,
                    Quantity = 15,
                    CategoryId = 3,
                    SubCategoryId = 2
                },
                new Product
                {
                    Id = 146,
                    Name = "Alesis Surge Mesh Kit Electronic Drum Set",
                    Description = "An entry-level electronic drum set with mesh pads for a realistic playing experience, suitable for beginners.",
                    ImageUrl = "/Images/ElectronicDrumSets/alesis3.png",
                    Price = 400,
                    Quantity = 25,
                    CategoryId = 3,
                    SubCategoryId = 2
                },
                new Product
                {
                    Id = 147,
                    Name = "Simmons SD1200 Electronic Drum Kit",
                    Description = "An advanced electronic drum kit with an expansive sound library, responsive pads, and a user-friendly interface.",
                    ImageUrl = "/Images/ElectronicDrumSets/simmons2.png",
                    Price = 1200,
                    Quantity = 12,
                    CategoryId = 3,
                    SubCategoryId = 2
                },
                new Product
                {
                    Id = 148,
                    Name = "Yamaha DTX452K Electronic Drum Set",
                    Description = "An entry-level electronic drum set with dynamic drum pads, built-in training functions, and a compact design.",
                    ImageUrl = "/Images/ElectronicDrumSets/yamaha3.png",
                    Price = 600,
                    Quantity = 20,
                    CategoryId = 3,
                    SubCategoryId = 2
                },
                new Product
                {
                    Id = 149,
                    Name = "Roland TD-4KP V-Drums Portable Electronic Drum Kit",
                    Description = "A portable electronic drum kit with a folding design, responsive pads, and a compact footprint for easy storage.",
                    ImageUrl = "/Images/ElectronicDrumSets/roland4.png",
                    Price = 900,
                    Quantity = 15,
                    CategoryId = 3,
                    SubCategoryId = 2
                },
                new Product
                {
                    Id = 150,
                    Name = "Alesis Command Mesh Kit Electronic Drum Set",
                    Description = "An intermediate-level electronic drum set with mesh pads, a powerful sound module, and extensive customization options.",
                    ImageUrl = "/Images/ElectronicDrumSets/alesis4.png",
                    Price = 800,
                    Quantity = 18,
                    CategoryId = 3,
                    SubCategoryId = 2
                },
                new Product
                {
                    Id = 151,
                    Name = "Meinl Headliner Series Conga Set",
                    Description = "A professional-grade conga set with hand-selected buffalo heads, sturdy stands, and rich, resonant tones.",
                    ImageUrl = "/Images/WorldPercussion/meinl1.png",
                    Price = 800,
                    Quantity = 10,
                    CategoryId = 3,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 152,
                    Name = "LP Aspire Bongo Set",
                    Description = "A versatile bongo set with durable wood shells, rawhide heads, and traditional tuning lugs for authentic tones.",
                    ImageUrl = "/Images/WorldPercussion/lp1.png",
                    Price = 120,
                    Quantity = 15,
                    CategoryId = 3,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 153,
                    Name = "Remo Djembe - Key-Tuned",
                    Description = "An African-style djembe with a lightweight design, key-tuned head, and vibrant, resonant sounds.",
                    ImageUrl = "/Images/WorldPercussion/remo1.png",
                    Price = 180,
                    Quantity = 12,
                    CategoryId = 3,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 154,
                    Name = "Tycoon Percussion Cajon",
                    Description = "A high-quality cajon with adjustable snare wires, birch wood construction, and a versatile sound for various genres.",
                    ImageUrl = "/Images/WorldPercussion/tycoon1.png",
                    Price = 150,
                    Quantity = 18,
                    CategoryId = 3,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 155,
                    Name = "Pearl Pandeiro",
                    Description = "A Brazilian-style pandeiro with a synthetic head, jingles, and a sturdy frame for traditional samba rhythms.",
                    ImageUrl = "/Images/WorldPercussion/pearl1.png",
                    Price = 60,
                    Quantity = 20,
                    CategoryId = 3,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 156,
                    Name = "Meinl Artisan Edition Shekere",
                    Description = "A handcrafted shekere with a fiberglass body, coconut shells, and a unique blend of warm and bright tones.",
                    ImageUrl = "/Images/WorldPercussion/meinl2.png",
                    Price = 120,
                    Quantity = 14,
                    CategoryId = 3,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 157,
                    Name = "LP Matador Timbales",
                    Description = "Professional-grade timbales with 14\" and 15\" shells, traditional tuning, and a chrome finish for a bright sound.",
                    ImageUrl = "/Images/WorldPercussion/lp2.png",
                    Price = 250,
                    Quantity = 8,
                    CategoryId = 3,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 158,
                    Name = "Remo Ocean Drum",
                    Description = "An innovative ocean drum with a clear head filled with steel balls, producing soothing sounds reminiscent of the sea.",
                    ImageUrl = "/Images/WorldPercussion/remo2.png",
                    Price = 80,
                    Quantity = 25,
                    CategoryId = 3,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 159,
                    Name = "Tycoon Percussion Maracas",
                    Description = "Classic wooden maracas with a traditional design, delivering a bright and crisp sound for Latin music.",
                    ImageUrl = "/Images/WorldPercussion/tycoon2.png",
                    Price = 20,
                    Quantity = 30,
                    CategoryId = 3,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 160,
                    Name = "Meinl Artisan Edition Tambourine",
                    Description = "Hand-hammered tambourine with brass jingles, wooden frame, and a warm, articulate sound for various musical styles.",
                    ImageUrl = "/Images/WorldPercussion/meinl3.png",
                    Price = 50,
                    Quantity = 20,
                    CategoryId = 3,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 161,
                    Name = "LP Aspire Triangle",
                    Description = "A durable steel triangle with a striker, offering clear and bright tones for percussion ensembles and arrangements.",
                    ImageUrl = "/Images/WorldPercussion/lp3.png",
                    Price = 15,
                    Quantity = 40,
                    CategoryId = 3,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 162,
                    Name = "Remo Tablatone Frame Drum",
                    Description = "A frame drum with a synthetic head, pre-tuned for a deep and resonant tone, suitable for various world music styles.",
                    ImageUrl = "/Images/WorldPercussion/remo3.png",
                    Price = 70,
                    Quantity = 15,
                    CategoryId = 3,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 163,
                    Name = "Tycoon Percussion Rainstick",
                    Description = "A decorative rainstick with a bamboo construction, producing a soothing sound reminiscent of falling rain.",
                    ImageUrl = "/Images/WorldPercussion/tycoon3.png",
                    Price = 25,
                    Quantity = 30,
                    CategoryId = 3,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 164,
                    Name = "Meinl NINO African Style Djembe",
                    Description = "A kid-friendly djembe with a synthetic head, suitable for young percussionists exploring world rhythms.",
                    ImageUrl = "/Images/WorldPercussion/meinl4.png",
                    Price = 40,
                    Quantity = 25,
                    CategoryId = 3,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 165,
                    Name = "LP Latin Percussion Cowbell",
                    Description = "A classic Latin percussion cowbell with a bright sound, perfect for adding accents to various musical genres.",
                    ImageUrl = "/Images/WorldPercussion/lp4.png",
                    Price = 30,
                    Quantity = 35,
                    CategoryId = 3,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 166,
                    Name = "DW 9000 Series Double Bass Drum Pedal",
                    Description = "High-performance double bass drum pedal with adjustable cam and linkage for precise and smooth footwork.",
                    ImageUrl = "/Images/DrumAccessories/dw1.png",
                    Price = 400,
                    Quantity = 8,
                    CategoryId = 3,
                    SubCategoryId = 4
                },
                new Product
                {
                    Id = 167,
                    Name = "Zildjian A Custom Cymbal Pack",
                    Description = "A set of professional-grade cymbals, including hi-hats, crashes, and ride, with bright and articulate tones.",
                    ImageUrl = "/Images/DrumAccessories/zildjian1.png",
                    Price = 800,
                    Quantity = 5,
                    CategoryId = 3,
                    SubCategoryId = 4
                },
                new Product
                {
                    Id = 168,
                    Name = "Vic Firth 5A Drumsticks",
                    Description = "Classic 5A drumsticks with a comfortable grip, suitable for various playing styles and genres.",
                    ImageUrl = "/Images/DrumAccessories/vicfirth1.png",
                    Price = 10,
                    Quantity = 50,
                    CategoryId = 3,
                    SubCategoryId = 4
                },
                new Product
                {
                    Id = 169,
                    Name = "Remo Silentstroke Drumhead Pack",
                    Description = "A set of mesh drumheads designed for quiet practice sessions, maintaining realistic feel and response.",
                    ImageUrl = "/Images/DrumAccessories/remo1.png",
                    Price = 60,
                    Quantity = 20,
                    CategoryId = 3,
                    SubCategoryId = 4
                },
                new Product
                {
                    Id = 170,
                    Name = "Gibraltar Drum Throne",
                    Description = "Adjustable drum throne with comfortable padding and sturdy construction for long-lasting playing comfort.",
                    ImageUrl = "/Images/DrumAccessories/gibraltar1.png",
                    Price = 80,
                    Quantity = 15,
                    CategoryId = 3,
                    SubCategoryId = 4
                },
                new Product
                {
                    Id = 171,
                    Name = "Tama Iron Cobra Hi-Hat Stand",
                    Description = "Durable hi-hat stand with smooth action and adjustable tension, providing precise control over hi-hat cymbals.",
                    ImageUrl = "/Images/DrumAccessories/tama1.png",
                    Price = 150,
                    Quantity = 10,
                    CategoryId = 3,
                    SubCategoryId = 4
                },
                new Product
                {
                    Id = 172,
                    Name = "Meinl Drum Rug",
                    Description = "Non-slip drum rug with ample space for drum kit placement, ensuring stability during intense playing sessions.",
                    ImageUrl = "/Images/DrumAccessories/meinl1.png",
                    Price = 70,
                    Quantity = 12,
                    CategoryId = 3,
                    SubCategoryId = 4
                },
                new Product
                {
                    Id = 173,
                    Name = "Pearl Demon Drive Bass Drum Pedal",
                    Description = "Innovative bass drum pedal with direct drive, providing fast and responsive playability for the modern drummer.",
                    ImageUrl = "/Images/DrumAccessories/pearl1.png",
                    Price = 250,
                    Quantity = 8,
                    CategoryId = 3,
                    SubCategoryId = 4
                },
                new Product
                {
                    Id = 174,
                    Name = "Sabian B8X Performance Cymbal Set",
                    Description = "Entry-level cymbal set with bright and focused tones, ideal for beginner and intermediate drummers.",
                    ImageUrl = "/Images/DrumAccessories/sabian1.png",
                    Price = 200,
                    Quantity = 10,
                    CategoryId = 3,
                    SubCategoryId = 4
                },
                new Product
                {
                    Id = 175,
                    Name = "Roc-N-Soc Nitro Drum Throne",
                    Description = "Hydraulic drum throne with nitrogen gas shock absorber for comfortable and height-adjustable seating.",
                    ImageUrl = "/Images/DrumAccessories/rocnsoc1.png",
                    Price = 120,
                    Quantity = 12,
                    CategoryId = 3,
                    SubCategoryId = 4
                },
                new Product
                {
                    Id = 176,
                    Name = "Ahead Armor Drum Cases Set",
                    Description = "Heavy-duty drum cases designed for protection during transportation, featuring weather-resistant fabric and foam padding.",
                    ImageUrl = "/Images/DrumAccessories/ahead1.png",
                    Price = 300,
                    Quantity = 6,
                    CategoryId = 3,
                    SubCategoryId = 4
                },
                new Product
                {
                    Id = 177,
                    Name = "Evans EQ3 Bass Drum Head",
                    Description = "Clear bass drum head with an internal control ring, providing a well-defined attack and controlled sustain.",
                    ImageUrl = "/Images/DrumAccessories/evans1.png",
                    Price = 40,
                    Quantity = 25,
                    CategoryId = 3,
                    SubCategoryId = 4
                },
                new Product
                {
                    Id = 178,
                    Name = "PDP Concept Series Hardware Pack",
                    Description = "Complete hardware pack for drum kit setup, including sturdy stands and a reliable bass drum pedal.",
                    ImageUrl = "/Images/DrumAccessories/pdp1.png",
                    Price = 180,
                    Quantity = 10,
                    CategoryId = 3,
                    SubCategoryId = 4
                },
                new Product
                {
                    Id = 179,
                    Name = "Mapex Armory Snare Drum",
                    Description = "Versatile snare drum with a hybrid shell design, offering a balanced mix of warmth and brightness.",
                    ImageUrl = "/Images/DrumAccessories/mapex1.png",
                    Price = 120,
                    Quantity = 15,
                    CategoryId = 3,
                    SubCategoryId = 4
                },
                new Product
                {
                    Id = 180,
                    Name = "Latin Percussion LP Claw",
                    Description = "Mounting claw for percussion accessories, providing a secure and adjustable attachment to drum hardware.",
                    ImageUrl = "/Images/DrumAccessories/lp1.png",
                    Price = 15,
                    Quantity = 30,
                    CategoryId = 3,
                    SubCategoryId = 4
                },
                new Product
                {
                    Id = 181,
                    Name = "Metallica Master of Puppets T-Shirt",
                    Description = "Classic black t-shirt featuring the iconic 'Master of Puppets' album cover artwork from Metallica.",
                    ImageUrl = "/Images/MetalTShirts/metallica1.png",
                    Price = 25,
                    Quantity = 40,
                    CategoryId = 4,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 182,
                    Name = "Slayer Eagle Logo Tee",
                    Description = "Black t-shirt with the legendary Slayer eagle logo, a must-have for fans of thrash metal.",
                    ImageUrl = "/Images/MetalTShirts/slayer1.png",
                    Price = 20,
                    Quantity = 35,
                    CategoryId = 4,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 183,
                    Name = "Iron Maiden Trooper Shirt",
                    Description = "Official Iron Maiden t-shirt featuring the iconic 'Trooper' album artwork, perfect for Maiden enthusiasts.",
                    ImageUrl = "/Images/MetalTShirts/ironmaiden1.png",
                    Price = 30,
                    Quantity = 30,
                    CategoryId = 4,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 184,
                    Name = "Megadeth Rust in Peace Tee",
                    Description = "Black t-shirt featuring the artwork from Megadeth's 'Rust in Peace' album, a classic design for metalheads.",
                    ImageUrl = "/Images/MetalTShirts/megadeth1.png",
                    Price = 22,
                    Quantity = 25,
                    CategoryId = 4,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 185,
                    Name = "Pantera Vulgar Display of Power Shirt",
                    Description = "Official Pantera t-shirt featuring the 'Vulgar Display of Power' album cover, a bold statement for fans.",
                    ImageUrl = "/Images/MetalTShirts/pantera1.png",
                    Price = 28,
                    Quantity = 20,
                    CategoryId = 4,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 186,
                    Name = "Black Sabbath Paranoid Tee",
                    Description = "Vintage-style Black Sabbath t-shirt featuring the iconic 'Paranoid' album artwork, a timeless classic.",
                    ImageUrl = "/Images/MetalTShirts/blacksabbath1.png",
                    Price = 26,
                    Quantity = 28,
                    CategoryId = 4,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 187,
                    Name = "Opeth Ghost Reveries Shirt",
                    Description = "Official Opeth t-shirt featuring the haunting 'Ghost Reveries' album artwork, perfect for progressive metal fans.",
                    ImageUrl = "/Images/MetalTShirts/opeth1.png",
                    Price = 30,
                    Quantity = 22,
                    CategoryId = 4,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 188,
                    Name = "Cannibal Corpse Butchered at Birth Tee",
                    Description = "Brutal Cannibal Corpse t-shirt featuring the controversial 'Butchered at Birth' album cover, not for the faint-hearted.",
                    ImageUrl = "/Images/MetalTShirts/cannibalcorpse1.png",
                    Price = 24,
                    Quantity = 18,
                    CategoryId = 4,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 189,
                    Name = "In Flames Jesterhead Tee",
                    Description = "In Flames t-shirt featuring the iconic Jesterhead logo, a symbol of the band's melodic death metal legacy.",
                    ImageUrl = "/Images/MetalTShirts/inflames1.png",
                    Price = 27,
                    Quantity = 18,
                    CategoryId = 4,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 190,
                    Name = "Meshuggah Obzen Shirt",
                    Description = "Unique Meshuggah t-shirt featuring artwork from the 'Obzen' album, a statement for fans of extreme metal.",
                    ImageUrl = "/Images/MetalTShirts/meshuggah1.png",
                    Price = 28,
                    Quantity = 15,
                    CategoryId = 4,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 191,
                    Name = "Behemoth The Satanist Tee",
                    Description = "Official Behemoth t-shirt featuring imagery from the critically acclaimed 'The Satanist' album.",
                    ImageUrl = "/Images/MetalTShirts/behemoth1.png",
                    Price = 32,
                    Quantity = 12,
                    CategoryId = 4,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 192,
                    Name = "Amon Amarth Viking Ship Shirt",
                    Description = "Viking-themed Amon Amarth t-shirt featuring a majestic ship design, perfect for fans of melodic death metal.",
                    ImageUrl = "/Images/MetalTShirts/amonamarth1.png",
                    Price = 26,
                    Quantity = 16,
                    CategoryId = 4,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 193,
                    Name = "Nightwish Endless Forms Most Beautiful Tee",
                    Description = "Nightwish t-shirt featuring artwork from the 'Endless Forms Most Beautiful' album, a must-have for symphonic metal enthusiasts.",
                    ImageUrl = "/Images/MetalTShirts/nightwish1.png",
                    Price = 28,
                    Quantity = 14,
                    CategoryId = 4,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 194,
                    Name = "Deicide Legion Shirt",
                    Description = "Official Deicide t-shirt featuring imagery from the iconic 'Legion' album, a classic design for death metal devotees.",
                    ImageUrl = "/Images/MetalTShirts/deicide1.png",
                    Price = 25,
                    Quantity = 20,
                    CategoryId = 4,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 195,
                    Name = "Children of Bodom Hate Crew Deathroll Tee",
                    Description = "High-energy Children of Bodom t-shirt featuring the 'Hate Crew Deathroll' album artwork.",
                    ImageUrl = "/Images/MetalTShirts/cob1.png",
                    Price = 22,
                    Quantity = 24,
                    CategoryId = 4,
                    SubCategoryId = 1
                },
                new Product
                {
                    Id = 196,
                    Name = "Levy's Leather Guitar Strap",
                    Description = "High-quality leather guitar strap with adjustable length and comfortable padding, perfect for long gigs.",
                    ImageUrl = "/Images/GuitarStraps/levys1.png",
                    Price = 40,
                    Quantity = 25,
                    CategoryId = 4,
                    SubCategoryId = 2
                },
                new Product
                {
                    Id = 197,
                    Name = "Ernie Ball Polypro Guitar Strap",
                    Description = "Durable and lightweight polypropylene guitar strap with an adjustable length, featuring the iconic Ernie Ball logo.",
                    ImageUrl = "/Images/GuitarStraps/ernieball1.png",
                    Price = 15,
                    Quantity = 50,
                    CategoryId = 4,
                    SubCategoryId = 2
                },
                new Product
                {
                    Id = 198,
                    Name = "D'Addario Planet Waves Woven Strap",
                    Description = "Colorful and stylish woven guitar strap with leather ends, providing both durability and visual appeal.",
                    ImageUrl = "/Images/GuitarStraps/daddario1.png",
                    Price = 20,
                    Quantity = 40,
                    CategoryId = 4,
                    SubCategoryId = 2
                },
                new Product
                {
                    Id = 199,
                    Name = "Fender Monogrammed Guitar Strap",
                    Description = "Classic Fender monogrammed guitar strap with an adjustable length, featuring the iconic Fender logo.",
                    ImageUrl = "/Images/GuitarStraps/fenderstrap1.png",
                    Price = 25,
                    Quantity = 35,
                    CategoryId = 4,
                    SubCategoryId = 2
                },
                new Product
                {
                    Id = 200,
                    Name = "Gibson The Classic Strap",
                    Description = "Premium leather guitar strap with embossed Gibson logo, offering both style and comfort for your guitar.",
                    ImageUrl = "/Images/GuitarStraps/gibsonstrap1.png",
                    Price = 50,
                    Quantity = 20,
                    CategoryId = 4,
                    SubCategoryId = 2
                },
                new Product
                {
                    Id = 201,
                    Name = "DiMarzio ClipLock Guitar Strap",
                    Description = "Secure and adjustable ClipLock guitar strap by DiMarzio, ensuring your guitar stays in place during intense performances.",
                    ImageUrl = "/Images/GuitarStraps/dimarzio1.png",
                    Price = 30,
                    Quantity = 30,
                    CategoryId = 4,
                    SubCategoryId = 2
                },
                new Product
                {
                    Id = 202,
                    Name = "Lock-It Straps Poly Classic",
                    Description = "Innovative polypropylene guitar strap with a locking mechanism, providing security and peace of mind while playing.",
                    ImageUrl = "/Images/GuitarStraps/lockit1.png",
                    Price = 35,
                    Quantity = 25,
                    CategoryId = 4,
                    SubCategoryId = 2
                },
                new Product
                {
                    Id = 203,
                    Name = "PRS Leather Bird Strap",
                    Description = "Luxurious leather guitar strap by PRS with the iconic bird inlay design, combining style and craftsmanship.",
                    ImageUrl = "/Images/GuitarStraps/prsstrap1.png",
                    Price = 60,
                    Quantity = 15,
                    CategoryId = 4,
                    SubCategoryId = 2
                },
                new Product
                {
                    Id = 204,
                    Name = "Leathergraft Vintage Tweed Strap",
                    Description = "Vintage-inspired tweed guitar strap with genuine leather ends, offering a classic look for your instrument.",
                    ImageUrl = "/Images/GuitarStraps/leathergraft1.png",
                    Price = 45,
                    Quantity = 18,
                    CategoryId = 4,
                    SubCategoryId = 2
                },
                new Product
                {
                    Id = 205,
                    Name = "Gruv Gear SoloStrap Neo",
                    Description = "Ergonomically designed SoloStrap Neo by Gruv Gear, providing comfort and even weight distribution for long playing sessions.",
                    ImageUrl = "/Images/GuitarStraps/gruvgear1.png",
                    Price = 55,
                    Quantity = 22,
                    CategoryId = 4,
                    SubCategoryId = 2
                },
                new Product
                {
                    Id = 206,
                    Name = "LM Products Vintage Suede Strap",
                    Description = "Vintage-style suede guitar strap by LM Products, combining a timeless look with durability and comfort.",
                    ImageUrl = "/Images/GuitarStraps/lmproducts1.png",
                    Price = 38,
                    Quantity = 28,
                    CategoryId = 4,
                    SubCategoryId = 2
                },
                new Product
                {
                    Id = 207,
                    Name = "RightOn! Mojo Collection Strap",
                    Description = "Handmade guitar strap from the Mojo Collection by RightOn!, featuring unique designs and quality materials.",
                    ImageUrl = "/Images/GuitarStraps/righton1.png",
                    Price = 42,
                    Quantity = 24,
                    CategoryId = 4,
                    SubCategoryId = 2
                },
                new Product
                {
                    Id = 208,
                    Name = "Souldier Vintage Woven Strap",
                    Description = "Vintage-inspired woven guitar strap by Souldier, handmade with recycled materials for a sustainable and stylish choice.",
                    ImageUrl = "/Images/GuitarStraps/souldier1.png",
                    Price = 48,
                    Quantity = 20,
                    CategoryId = 4,
                    SubCategoryId = 2
                },
                new Product
                {
                    Id = 209,
                    Name = "Mono M80 Betty Strap",
                    Description = "Adjustable and ergonomic guitar strap by Mono, featuring a minimalist design and comfortable shoulder pad.",
                    ImageUrl = "/Images/GuitarStraps/mono1.png",
                    Price = 32,
                    Quantity = 32,
                    CategoryId = 4,
                    SubCategoryId = 2
                },
                new Product
                {
                    Id = 210,
                    Name = "Taylor Nouveau Leather Strap",
                    Description = "Premium leather guitar strap by Taylor with embossed Nouveau design, offering a blend of style and quality.",
                    ImageUrl = "/Images/GuitarStraps/taylor1.png",
                    Price = 58,
                    Quantity = 16,
                    CategoryId = 4,
                    SubCategoryId = 2
                },
                 new Product
                 {
                     Id = 211,
                     Name = "Hercules GS414B Guitar Stand",
                     Description = "Sturdy and adjustable guitar stand with a folding design by Hercules, suitable for both electric and acoustic guitars.",
                     ImageUrl = "/Images/Stands/hercules1.png",
                     Price = 30,
                     Quantity = 25,
                     CategoryId = 4,
                     SubCategoryId = 3
                 },
                new Product
                {
                    Id = 212,
                    Name = "On-Stage XCG4 Guitar Stand",
                    Description = "Classic XCG4 guitar stand by On-Stage with a durable design and secure locking mechanism, ideal for stage and studio use.",
                    ImageUrl = "/Images/Stands/onstage1.png",
                    Price = 20,
                    Quantity = 40,
                    CategoryId = 4,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 213,
                    Name = "Ultimate Support GS-1000 Pro Guitar Stand",
                    Description = "Professional-grade GS-1000 Pro guitar stand by Ultimate Support, featuring a sleek design and reliable stability for your instrument.",
                    ImageUrl = "/Images/Stands/ultimate1.png",
                    Price = 40,
                    Quantity = 30,
                    CategoryId = 4,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 214,
                    Name = "String Swing CC01K Guitar Hanger",
                    Description = "Wall-mounted guitar hanger by String Swing, allowing you to display your guitar securely while saving floor space.",
                    ImageUrl = "/Images/Stands/stringswing1.png",
                    Price = 15,
                    Quantity = 35,
                    CategoryId = 4,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 215,
                    Name = "Yamaha PKBS1 Keyboard Stand",
                    Description = "Adjustable single-braced X-style keyboard stand by Yamaha, suitable for a variety of keyboard sizes and weights.",
                    ImageUrl = "/Images/Stands/yamaha1.png",
                    Price = 35,
                    Quantity = 28,
                    CategoryId = 4,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 216,
                    Name = "Quik Lok WS-551 Keyboard Stand",
                    Description = "Heavy-duty double-braced keyboard stand by Quik Lok, providing stability and adjustability for various keyboard setups.",
                    ImageUrl = "/Images/Stands/quiklok1.png",
                    Price = 50,
                    Quantity = 20,
                    CategoryId = 4,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 217,
                    Name = "K&M Omega Table-Style Keyboard Stand",
                    Description = "Table-style keyboard stand by K&M, offering a versatile and stable platform for your keyboard during performances.",
                    ImageUrl = "/Images/Stands/km1.png",
                    Price = 60,
                    Quantity = 18,
                    CategoryId = 4,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 218,
                    Name = "Roland KS-10X Keyboard Stand",
                    Description = "Adjustable X-style keyboard stand by Roland, featuring a sturdy design and easy setup for various keyboard models.",
                    ImageUrl = "/Images/Stands/roland1.png",
                    Price = 45,
                    Quantity = 22,
                    CategoryId = 4,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 219,
                    Name = "Korg PS3 Piano-Style Sustain Pedal",
                    Description = "Piano-style sustain pedal by Korg, designed for use with keyboards and digital pianos, providing expressive control.",
                    ImageUrl = "/Images/Stands/korg1.png",
                    Price = 25,
                    Quantity = 32,
                    CategoryId = 4,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 220,
                    Name = "Gator Frameworks GFW-KEY-1000X Keyboard Stand",
                    Description = "Heavy-duty keyboard stand by Gator Frameworks, offering stability and adjustability for various keyboard setups.",
                    ImageUrl = "/Images/Stands/gator1.png",
                    Price = 55,
                    Quantity = 24,
                    CategoryId = 4,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 221,
                    Name = "Casio ARST Single X Keyboard Stand",
                    Description = "Single X-style keyboard stand by Casio, featuring an adjustable height design for comfortable playing.",
                    ImageUrl = "/Images/Stands/casio1.png",
                    Price = 30,
                    Quantity = 28,
                    CategoryId = 4,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 222,
                    Name = "Neewer Heavy Duty Z-Style Keyboard Stand",
                    Description = "Z-style keyboard stand by Neewer, providing a stable and space-saving solution for various keyboard setups.",
                    ImageUrl = "/Images/Stands/neewer1.png",
                    Price = 65,
                    Quantity = 15,
                    CategoryId = 4,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 223,
                    Name = "RockJam Xfinity Heavy-Duty Double-X Pre-Assembled Keyboard Stand",
                    Description = "Pre-assembled double-X keyboard stand by RockJam, featuring a sturdy design and easy setup for different keyboard sizes.",
                    ImageUrl = "/Images/Stands/rockjam1.png",
                    Price = 40,
                    Quantity = 30,
                    CategoryId = 4,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 224,
                    Name = "Kawai F-30 Triple Pedal Unit",
                    Description = "Triple pedal unit by Kawai, designed for use with digital pianos, providing enhanced control over sustain, sostenuto, and soft functions.",
                    ImageUrl = "/Images/Stands/kawai1.png",
                    Price = 75,
                    Quantity = 18,
                    CategoryId = 4,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 225,
                    Name = "Mogami Gold Instrument Cable",
                    Description = "High-quality instrument cable by Mogami, featuring gold-plated connectors for optimal signal transfer and durability.",
                    ImageUrl = "/Images/Connectors/mogami1.png",
                    Price = 25,
                    Quantity = 40,
                    CategoryId = 4,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 226,
                    Name = "Planet Waves Classic Series Instrument Cable",
                    Description = "Reliable instrument cable by Planet Waves, with molded plugs for strain relief and oxygen-free copper conductors.",
                    ImageUrl = "/Images/Connectors/planetwaves1.png",
                    Price = 15,
                    Quantity = 50,
                    CategoryId = 4,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 227,
                    Name = "Hosa GTR-210 Straight to Straight Guitar Cable",
                    Description = "Straight to straight guitar cable by Hosa, offering a simple and effective solution for connecting guitars and amplifiers.",
                    ImageUrl = "/Images/Connectors/hosa1.png",
                    Price = 10,
                    Quantity = 60,
                    CategoryId = 4,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 228,
                    Name = "George L's Effects Kit Cable",
                    Description = "Customizable effects kit cable by George L's, allowing you to create patch cables of various lengths for your pedalboard.",
                    ImageUrl = "/Images/Connectors/georgels1.png",
                    Price = 20,
                    Quantity = 35,
                    CategoryId = 4,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 229,
                    Name = "HOSA MID-310BK MIDI Cable",
                    Description = "MIDI cable by HOSA, providing reliable and low-noise connectivity for MIDI devices such as keyboards and controllers.",
                    ImageUrl = "/Images/Connectors/hosa2.png",
                    Price = 12,
                    Quantity = 45,
                    CategoryId = 4,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 230,
                    Name = "Roland Black Series Interconnect Cable",
                    Description = "Interconnect cable by Roland, designed for connecting keyboards, synthesizers, and other audio devices with 1/4-inch jacks.",
                    ImageUrl = "/Images/Connectors/roland2.png",
                    Price = 18,
                    Quantity = 30,
                    CategoryId = 4,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 231,
                    Name = "MIDI Solutions Quadra Thru",
                    Description = "MIDI Thru box by MIDI Solutions, providing four individually addressable MIDI Thru outputs for routing MIDI signals.",
                    ImageUrl = "/Images/Connectors/midisolutions1.png",
                    Price = 30,
                    Quantity = 25,
                    CategoryId = 4,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 232,
                    Name = "Hosa GPM-103 3.5mm TRS to 1/4\" TRS Adapter",
                    Description = "Adapter cable by Hosa, allowing the connection of devices with 3.5mm TRS jacks to devices with 1/4\" TRS jacks.",
                    ImageUrl = "/Images/Connectors/hosa3.png",
                    Price = 8,
                    Quantity = 50,
                    CategoryId = 4,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 233,
                    Name = "Mogami Gold RCA to RCA Audio Cable",
                    Description = "Premium RCA to RCA audio cable by Mogami, ideal for connecting audio interfaces, mixers, and other audio equipment.",
                    ImageUrl = "/Images/Connectors/mogami2.png",
                    Price = 22,
                    Quantity = 28,
                    CategoryId = 4,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 234,
                    Name = "Pro Co PowerPlus Y-Cable",
                    Description = "Y-Cable by Pro Co PowerPlus, featuring sturdy connectors for splitting power to multiple pedals on your pedalboard.",
                    ImageUrl = "/Images/Connectors/proco1.png",
                    Price = 15,
                    Quantity = 40,
                    CategoryId = 4,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 235,
                    Name = "HOSA STP-201 1/4\" TRS to Dual 1/4\" TS Insert Cable",
                    Description = "Insert cable by HOSA, allowing the connection of audio processors and effects units to mixing consoles.",
                    ImageUrl = "/Images/Connectors/hosa4.png",
                    Price = 14,
                    Quantity = 38,
                    CategoryId = 4,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 236,
                    Name = "Roland RIC-B3 Black Series Instrument Cable",
                    Description = "Premium instrument cable by Roland Black Series, featuring heavy-duty connectors for reliable performance.",
                    ImageUrl = "/Images/Connectors/roland3.png",
                    Price = 28,
                    Quantity = 32,
                    CategoryId = 4,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 237,
                    Name = "MIDI Solutions Merger",
                    Description = "MIDI Merger by MIDI Solutions, allowing the combination of MIDI data from two sources into a single MIDI stream.",
                    ImageUrl = "/Images/Connectors/midisolutions2.png",
                    Price = 35,
                    Quantity = 22,
                    CategoryId = 4,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 238,
                    Name = "Korg SQ-Cable-6 Sync Cable",
                    Description = "Sync cable by Korg, designed for connecting Korg volca series and other compatible devices for synchronized operation.",
                    ImageUrl = "/Images/Connectors/korg2.png",
                    Price = 10,
                    Quantity = 45,
                    CategoryId = 4,
                    SubCategoryId = 3
                },
                new Product
                {
                    Id = 239,
                    Name = "Livewire Essential Dual MIDI Cable",
                    Description = "Dual MIDI cable by Livewire Essential, featuring reliable connectors for connecting MIDI devices in your setup.",
                    ImageUrl = "/Images/Connectors/livewire1.png",
                    Price = 16,
                    Quantity = 36,
                    CategoryId = 4,
                    SubCategoryId = 3
                }


                );

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    UserName = "Sahan",
                    Email = "sahan@gmail.com"

                }
                );
        }
    }
}
