using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GuitarShop.Server.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    SubCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Name", "Price", "Quantity", "SubCategoryId" },
                values: new object[,]
                {
                    { 1, 1, "Unique 'mini dreadnought' body size provides portability and comfort while retaining a full-bodied sound.", "/Images/Guitars/orangewood-omd22.png", "Orangewood Americana OMD-22", 500m, 75, 1 },
                    { 2, 1, "The pinnacle of acoustic guitar craftsmanship, a classic dreadnought shape with exquisite tonewoods and impeccable build quality.", "/Images/Guitars/martin-d41.png", "Martin D-41 Special", 1500m, 50, 1 },
                    { 3, 1, "Warm and rich mahogany body delivers a timeless sound, favored by countless country and folk legends.", "/Images/Guitars/gibson-j45.png", "Gibson J-45", 1200m, 30, 1 },
                    { 4, 1, "Known for its crisp articulation and comfortable playability, this Grand Auditorium model features Taylor's innovative neck design and electronics.", "/Images/Guitars/taylor-814ce.png", "Taylor 814ce", 1800m, 25, 1 },
                    { 5, 1, "Renowned for their exceptional build quality and nuanced tone, these guitars are considered boutique works of art.", "/Images/Guitars/collings-om.png", "Collings Traditional OM", 2500m, 20, 1 },
                    { 6, 1, "Large body produces a booming voice, perfect for bluegrass strumming and flatpicking.", "/Images/Guitars/guild-f50.png", "Guild F-50 Jumbo", 1600m, 35, 1 },
                    { 7, 1, "California-crafted masterpiece with a focus on sustain and tonal richness.", "/Images/Guitars/santa-cruz.png", "Santa Cruz D Indian Rosewood", 3000m, 15, 1 },
                    { 8, 1, "Smaller body size offers intimate tones and comfortable playing experience, favored by fingerstyle players.", "/Images/Guitars/martin-00018.png", "Martin 000-18 Standard", 1700m, 40, 1 },
                    { 9, 1, "Smaller slope-shouldered body provides a focused tone with punchy midrange, popular for blues and fingerpicking.", "/Images/Guitars/gibson-hummingbird.png", "Gibson Hummingbird", 1400m, 28, 1 },
                    { 10, 1, "Budget-friendly workhorse, known for its solid construction and reliable tone, perfect for beginners and seasoned players alike.", "/Images/Guitars/yamaha-fg800j.png", "Yamaha FG800J", 500m, 60, 1 },
                    { 11, 1, "Sustainable wood choices and innovative design combine for a unique voice and comfortable playing experience.", "/Images/Guitars/breedlove-discovery.png", "Breedlove Discovery Concert CE", 800m, 45, 1 },
                    { 12, 1, "Canadian-made guitar known for its balanced tone and playability, a popular choice for singer-songwriters.", "/Images/Guitars/seagull-s6.png", "Seagull S6 Original", 700m, 55, 1 },
                    { 13, 1, "Vintage-inspired dreadnought at an affordable price, delivering classic warm tones and traditional vibe.", "/Images/Guitars/blueridge-br160.png", "Blueridge BR-160", 900m, 38, 1 },
                    { 14, 1, "Modern take on the classic design with bold aesthetics and versatile Fishman electronics.", "/Images/Guitars/fender-paramount.png", "Fender Paramount Dreadnought Pau Ferro", 1100m, 32, 1 },
                    { 15, 1, "Affordable option with solid mahogany body and warm, rich tone, inspired by Gibson's classic designs.", "/Images/Guitars/epiphone-masterbilt.png", "Epiphone Masterbilt DR-100", 400m, 70, 1 },
                    { 16, 1, "The iconic Strat, used by countless legends like Jimi Hendrix, Eric Clapton, and Stevie Ray Vaughan. Features a classic single-coil pickup configuration and smooth playability.", "/Images/Guitars/fender1.png", "Fender Stratocaster", 100m, 100, 2 },
                    { 17, 1, "Another legendary axe, known for its warm, thick tone and sustain. Beloved by Slash, Jimmy Page, and countless rock and blues players.", "/Images/Guitars/gibson1.png", "Gibson Les Paul", 100m, 100, 2 },
                    { 18, 1, "A unique hollow-body guitar with a distinctive twangy sound, popularized by artists like Duane Eddy and Jack White.", "/Images/Guitars/gretsch1.png", "Gretsch G6120T-59 Rancher Falcon", 100m, 100, 2 },
                    { 19, 1, "Inspired by Gibson's SG design, this affordable option offers classic rock and blues tones with P-90 pickups.", "/Images/Guitars/epiphone1.png", "Epiphone SG", 100m, 100, 2 },
                    { 20, 1, "Modern shred machine with a fast neck, active pickups, and versatile tone, favored by metal and progressive rock guitarists.", "/Images/Guitars/ibanez1.png", "Ibanez RG Series", 100m, 100, 2 },
                    { 21, 1, "Simple and straightforward, the Tele boasts a bright, twangy sound and is perfect for country, blues, and indie rock.", "/Images/Guitars/fendertel1.png", "Fender Telecaster", 100m, 100, 2 },
                    { 22, 1, "American-made masterpiece with a comfortable neck, stunning finishes, and versatile pickups for any genre.", "/Images/Guitars/prs1.png", "PRS Custom 24", 100m, 100, 2 },
                    { 23, 1, "Semi-hollow guitar with a rich, warm tone, perfect for jazz, blues, and classic rock.", "/Images/Guitars/gison2.png", "Gibson ES-335", 100m, 100, 2 },
                    { 24, 1, "Distinctive 'jangly' sound and beautiful design, favored by The Beatles and The Who.", "/Images/Guitars/rickenbacker1.png", "Rickenbacker 330", 100m, 100, 2 },
                    { 25, 1, "Affordable hollow-body option with P-90 pickups, delivering warm, woody tones for blues and rockabilly.", "/Images/Guitars/epiphone2.png", "Epiphone Wilshire", 100m, 100, 2 },
                    { 26, 1, "Modern metal guitar with a Floyd Rose tremolo system, screaming active pickups, and a sleek profile.", "/Images/Guitars/carvel1.png", "Charvel Pro-Mod DK24 HSS", 100m, 100, 2 },
                    { 27, 1, "Unique offset body and versatile pickup options, producing jazz-inspired clean tones and biting distortion.", "/Images/Guitars/fender2.png", "Fender Jazzmaster", 100m, 100, 2 },
                    { 28, 1, "A modern take on the classic Falcon, offering powerful P-90 pickups and a striking black finish.", "/Images/Guitars/gretsch2.png", "Gretsch Jet Black Falcon", 100m, 100, 2 },
                    { 29, 1, "Elegant archtop jazz guitar with a warm, smooth tone, perfect for standards and classic jazz.", "/Images/Guitars/epiphone2.png", "Epiphone ES-175", 100m, 100, 2 },
                    { 30, 1, "Affordable shred machine with a comfortable C-shaped neck, EMG active pickups, and a devilish aesthetic.", "/Images/Guitars/schecter2.png", "Schecter Hellraiser C-1", 100m, 100, 2 },
                    { 31, 1, "The classic bass that revolutionized the world of electric bass guitars. Known for its deep, punchy tone and iconic design.", "/Images/BassGuitars/fender-precision.png", "Fender Precision Bass", 900m, 25, 3 },
                    { 32, 1, "Powerful and versatile, the StingRay is favored by many professional bassists for its distinctive tone and playability.", "/Images/BassGuitars/music-man-stingray.png", "Music Man StingRay", 1200m, 20, 3 },
                    { 33, 1, "A popular choice for modern players, the SR500 features a sleek design, thin neck, and a wide range of tonal options.", "/Images/BassGuitars/ibanez-sr500.png", "Ibanez SR500", 800m, 30, 3 },
                    { 34, 1, "Known for its unique body shape and powerful low-end, the Thunderbird is a rock and metal favorite.", "/Images/BassGuitars/gibson-thunderbird.png", "Gibson Thunderbird", 1500m, 15, 3 },
                    { 35, 1, "Versatile and well-balanced, the Jazz Bass is appreciated for its smooth playing feel and tonal flexibility.", "/Images/BassGuitars/fender-jazz.png", "Fender Jazz Bass", 1000m, 22, 3 },
                    { 36, 1, "Sleek and aggressive, the Stiletto Custom offers a modern design with high-output pickups for heavy tones.", "/Images/BassGuitars/schecter-stiletto.png", "Schecter Stiletto Custom", 1100m, 18, 3 },
                    { 37, 1, "A classic choice with a distinct look and signature sound. The 4003 is known for its pronounced midrange and punch.", "/Images/BassGuitars/rickenbacker-4003.png", "Rickenbacker 4003", 1800m, 12, 3 },
                    { 38, 1, "Combining classic design with modern features, the BB434 is a reliable and affordable option for bass players.", "/Images/BassGuitars/yamaha-bb434.png", "Yamaha BB434", 700m, 28, 3 },
                    { 39, 1, "An affordable take on the iconic Thunderbird design, offering a great balance of style and performance.", "/Images/BassGuitars/epiphone-thunderbird.png", "Epiphone Thunderbird IV", 600m, 35, 3 },
                    { 40, 1, "Designed in collaboration with Marcus Miller, this bass is known for its quality construction and versatile tonal options.", "/Images/BassGuitars/sire-marcus-miller.png", "Sire Marcus Miller V7", 1300m, 16, 3 },
                    { 41, 1, "A high-end bass with premium features, the B-1004SE is crafted for professional players seeking top-tier performance.", "/Images/BassGuitars/esp-ltd-b1004se.png", "ESP LTD B-1004SE", 2000m, 10, 3 },
                    { 42, 1, "Handcrafted with precision, the Emperor Standard is a boutique bass known for its exquisite craftsmanship and tone.", "/Images/BassGuitars/fodera-emperor.png", "Fodera Emperor Standard", 4000m, 8, 3 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Name", "Price", "Quantity", "SubCategoryId" },
                values: new object[,]
                {
                    { 43, 1, "A German-made bass with a distinctive body shape, the Corvette Standard offers a powerful and clear sound.", "/Images/BassGuitars/warwick-corvette.png", "Warwick Corvette Standard", 1600m, 14, 3 },
                    { 44, 1, "Inspired by the iconic bass used by Paul McCartney, the Ignition Violin Bass offers a vintage look and feel.", "/Images/BassGuitars/hofner-ignition.png", "Hofner Ignition Violin Bass", 800m, 20, 3 },
                    { 45, 1, "An affordable alternative with classic Jazz Bass styling and versatile tonal options for various playing styles.", "/Images/BassGuitars/squier-jazz.png", "Squier Vintage Modified Jazz Bass", 500m, 30, 3 },
                    { 46, 1, "High-quality nickel-wound strings known for their balanced tone and durability.", "/Images/Accessories/strings1.png", "Ernie Ball Regular Slinky Electric Guitar Strings", 10m, 50, 4 },
                    { 47, 1, "Popular acoustic guitar strings with a bright tone and excellent intonation.", "/Images/Accessories/strings2.png", "D'Addario EJ16 Phosphor Bronze Acoustic Guitar Strings", 12m, 40, 4 },
                    { 48, 1, "Coated strings that provide extended life and a smooth feel, ideal for players looking for longevity.", "/Images/Accessories/strings3.png", "Elixir Nanoweb Electric Guitar Strings", 15m, 30, 4 },
                    { 49, 1, "Bright and punchy bass strings suitable for a variety of playing styles.", "/Images/Accessories/strings4.png", "GHS Boomers Roundwound Bass Guitar Strings", 20m, 25, 4 },
                    { 50, 1, "Smooth and warm flatwound strings designed for jazz guitarists seeking a vintage tone.", "/Images/Accessories/strings5.png", "Thomastik-Infeld Jazz Swing Series Flatwound Strings", 25m, 20, 4 },
                    { 51, 1, "Easy-to-use capo with a quick-change design, perfect for fast adjustments during live performances.", "/Images/Accessories/capo1.png", "Kyser Quick-Change Capo", 15m, 30, 4 },
                    { 52, 1, "High-quality capo with a smooth operation and adjustable tension for precise fretboard pressure.", "/Images/Accessories/capo2.png", "Shubb Deluxe S-Series Steel String Capo", 20m, 25, 4 },
                    { 53, 1, "Sleek capo with adaptive pressure technology, ensuring even pressure across the fretboard for optimal intonation.", "/Images/Accessories/capo3.png", "G7th Performance 3 Capo", 30m, 20, 4 },
                    { 54, 1, "Lightweight capo with micrometer tension adjustment for precise and buzz-free fretting.", "/Images/Accessories/capo4.png", "D'Addario NS Artist Guitar Capo", 25m, 22, 4 },
                    { 55, 1, "Versatile capo with a unique design that accommodates both flat and curved fretboards.", "/Images/Accessories/capo5.png", "Planet Waves NS Tri-Action Capo", 18m, 28, 4 },
                    { 56, 1, "Clip-on tuner with a bright and easy-to-read display, suitable for guitars and other stringed instruments.", "/Images/Accessories/tuner1.png", "Snark SN-5X Clip-On Tuner", 15m, 30, 4 },
                    { 57, 1, "Sturdy pedal tuner with high accuracy and a durable design, ideal for gigging musicians.", "/Images/Accessories/tuner2.png", "Boss TU-3 Chromatic Tuner", 80m, 15, 4 },
                    { 58, 1, "Sleek pedal tuner with a large LED display and true bypass for transparent signal when not in use.", "/Images/Accessories/tuner3.png", "Korg Pitchblack Advance Pedal Tuner", 65m, 18, 4 },
                    { 59, 1, "Compact polyphonic tuner with a small footprint, allowing for quick tuning of all strings at once.", "/Images/Accessories/tuner4.png", "TC Electronic Polytune 3 Mini", 90m, 12, 4 },
                    { 60, 1, "High-definition clip-on tuner with unparalleled tuning accuracy and a variety of tuning presets.", "/Images/Accessories/tuner5.png", "Peterson StroboClip HD Tuner", 100m, 10, 4 },
                    { 61, 2, "A classic and versatile upright piano known for its clear tone and responsive touch.", "/Images/Pianos/yamaha1.png", "Yamaha U1 Upright Piano", 5000m, 10, 1 },
                    { 62, 2, "The gold standard in concert grand pianos, renowned for its exceptional sound and craftsmanship.", "/Images/Pianos/steinway1.png", "Steinway Model D Concert Grand Piano", 100000m, 2, 1 },
                    { 63, 2, "A high-quality upright piano with a rich and expressive sound, suitable for both beginners and professionals.", "/Images/Pianos/kawai1.png", "Kawai K-500 Upright Piano", 6000m, 8, 1 },
                    { 64, 2, "A prestigious concert grand piano with Viennese craftsmanship, offering a unique and resonant sound.", "/Images/Pianos/bosendorfer1.png", "Bösendorfer 280VC Concert Grand Piano", 120000m, 1, 1 },
                    { 65, 2, "A digital stage piano with versatile sounds, advanced features, and realistic weighted keyboard action.", "/Images/Pianos/roland1.png", "Roland RD-2000 Stage Piano", 2500m, 15, 1 },
                    { 66, 2, "A German-made grand piano with a distinguished heritage and a warm, singing tone.", "/Images/Pianos/bechstein1.png", "C. Bechstein A 192 Grand Piano", 80000m, 3, 1 },
                    { 67, 2, "A compact and stylish digital piano with authentic piano sounds and a responsive hammer-action keyboard.", "/Images/Pianos/korg1.png", "Korg LP-380 Digital Piano", 1200m, 20, 1 },
                    { 68, 2, "A German grand piano known for its clarity and singing tone, featuring the innovative Aliquot system.", "/Images/Pianos/bluthner1.png", "Blüthner Model 1 Grand Piano", 90000m, 2, 1 },
                    { 69, 2, "An affordable digital piano with realistic piano sound and feel, suitable for practice and performance.", "/Images/Pianos/casio1.png", "Casio Privia PX-870 Digital Piano", 800m, 30, 1 },
                    { 70, 2, "A high-quality upright piano designed for both beginners and advanced players, delivering rich tones.", "/Images/Pianos/bechstein2.png", "Bechstein Academy A 3 Upright Piano", 7000m, 12, 1 },
                    { 71, 2, "A professional stage piano with authentic acoustic and electric piano sounds, perfect for live performances.", "/Images/Pianos/yamaha2.png", "Yamaha CP88 Stage Piano", 2500m, 18, 1 },
                    { 72, 2, "A portable and budget-friendly digital piano with responsive keys and a variety of built-in sounds.", "/Images/Pianos/kawai2.png", "Kawai ES110 Digital Piano", 700m, 25, 1 },
                    { 73, 2, "An Italian concert grand piano known for its craftsmanship, power, and dynamic range.", "/Images/Pianos/fazioli1.png", "Fazioli F308 Concert Grand Piano", 150000m, 1, 1 },
                    { 74, 2, "A versatile digital stage piano with a wide range of sounds and intuitive controls for live performances.", "/Images/Pianos/nord1.png", "Nord Stage 3 Compact Digital Piano", 3000m, 15, 1 },
                    { 75, 2, "An affordable and reliable upright piano suitable for students and home use, delivering a warm tone.", "/Images/Pianos/youngchang1.png", "Young Chang Y-118 Upright Piano", 3000m, 10, 1 },
                    { 76, 2, "A powerful analog synthesizer with rich sound and versatile controls, perfect for creating iconic Moog tones.", "/Images/Synthesizers/moog1.png", "Moog Subsequent 37 Analog Synthesizer", 2500m, 8, 2 },
                    { 77, 2, "A compact polyphonic analog synthesizer with digital effects and a customizable digital oscillator.", "/Images/Synthesizers/korg1.png", "Korg Minilogue XD Polyphonic Analog Synthesizer", 800m, 15, 2 },
                    { 78, 2, "A 16-voice analog synthesizer with a versatile sound engine and expansive modulation possibilities.", "/Images/Synthesizers/davesmith1.png", "Dave Smith Instruments Prophet Rev2 Synthesizer", 2000m, 10, 2 },
                    { 79, 2, "A compact module that recreates the classic Juno-60 and Juno-106 synthesizer sounds with modern features.", "/Images/Synthesizers/roland1.png", "Roland JU-06A Boutique Synthesizer Module", 350m, 20, 2 },
                    { 80, 2, "A unique hybrid synthesizer with a digital oscillator and analog filter, offering a wide sonic palette.", "/Images/Synthesizers/arturia1.png", "Arturia MicroFreak Hybrid Synthesizer", 400m, 18, 2 },
                    { 81, 2, "A powerful polyphonic synthesizer with analog and digital oscillators, delivering versatile sound design capabilities.", "/Images/Synthesizers/novation1.png", "Novation Peak 8-Voice Polyphonic Synthesizer", 1800m, 7, 2 },
                    { 82, 2, "A 12-voice analog synthesizer with a rich and warm sound, featuring deep modulation possibilities.", "/Images/Synthesizers/behringer1.png", "Behringer DeepMind 12 Analog Synthesizer", 900m, 12, 2 },
                    { 83, 2, "A flagship synthesizer with advanced FM-X and AWM2 sound engines, providing unparalleled sound quality.", "/Images/Synthesizers/yamaha1.png", "Yamaha Montage 8 Flagship Synthesizer", 3000m, 5, 2 },
                    { 84, 2, "A hybrid synthesizer with sample-based oscillators and analog filters, offering a wide range of sonic possibilities.", "/Images/Synthesizers/sequential1.png", "Sequential Prophet X Hybrid Synthesizer", 2500m, 8, 2 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Name", "Price", "Quantity", "SubCategoryId" },
                values: new object[,]
                {
                    { 85, 2, "A wave-sequencing synthesizer that reimagines Korg's classic Wavestation, providing evolving and dynamic sounds.", "/Images/Synthesizers/korg2.png", "Korg Wavestate Wave-Sequencing Synthesizer", 1200m, 10, 2 },
                    { 86, 2, "A collaboration between Dave Smith and Tom Oberheim, this analog synthesizer offers classic Oberheim sound with modern features.", "/Images/Synthesizers/davesmith2.png", "Dave Smith Instruments OB-6 Analog Synthesizer", 2800m, 6, 2 },
                    { 87, 2, "An 8-voice wavetable synthesizer with a modern design, intuitive controls, and a wide range of sonic possibilities.", "/Images/Synthesizers/modal1.png", "Modal Electronics Argon8 Polyphonic Synthesizer", 1000m, 15, 2 },
                    { 88, 2, "A desktop version of the popular Virus TI2 synthesizer, known for its powerful sound and versatile synthesis engine.", "/Images/Synthesizers/access1.png", "Access Virus TI2 Desktop Synthesizer", 2200m, 5, 2 },
                    { 89, 2, "A flagship synthesizer from Waldorf with a unique hybrid architecture, offering deep sound design possibilities.", "/Images/Synthesizers/waldorf1.png", "Waldorf Quantum Synthesizer", 3500m, 3, 2 },
                    { 90, 2, "An analog modeling synthesizer with a streamlined interface and advanced sound-shaping capabilities.", "/Images/Synthesizers/nord1.png", "Nord Lead A1 Analog Modeling Synthesizer", 1700m, 9, 2 },
                    { 91, 2, "A legendary combo organ known for its distinctive sound, played by iconic musicians of the '60s and '70s.", "/Images/ComboOrgans/vox1.png", "Vox Continental 73-Key Combo Organ", 1800m, 7, 3 },
                    { 92, 2, "A classic Italian combo organ with a bright and percussive sound, popularized in pop and rock music.", "/Images/ComboOrgans/farfisa1.png", "Farfisa Compact Deluxe Combo Organ", 2000m, 5, 3 },
                    { 93, 2, "A modern portable organ with authentic Hammond tonewheel sound and advanced digital features.", "/Images/ComboOrgans/hammond1.png", "Hammond XK-5 Portable Organ", 2500m, 8, 3 },
                    { 94, 2, "A versatile stage instrument featuring classic organ sounds, piano, and electric piano tones.", "/Images/ComboOrgans/nord1.png", "Nord Electro 6D 73-Key Stage Piano/Organ", 2400m, 10, 3 },
                    { 95, 2, "A vintage combo organ with a warm and fuzzy sound, appreciated for its retro character.", "/Images/ComboOrgans/acetone1.png", "Ace Tone TOP-5 Combo Organ", 1500m, 6, 3 },
                    { 96, 2, "A tonewheel organ with authentic rotary speaker emulation, delivering classic organ tones.", "/Images/ComboOrgans/korg1.png", "Korg CX-3 Tonewheel Organ", 1600m, 9, 3 },
                    { 97, 2, "A compact combo organ with a variety of vintage sounds, suitable for stage and studio use.", "/Images/ComboOrgans/gem1.png", "GEM Continental 61 Combo Organ", 1200m, 12, 3 },
                    { 98, 2, "A compact and lightweight digital organ with authentic tonewheel emulation and modern features.", "/Images/ComboOrgans/crumar1.png", "Crumar Mojo 61 Digital Organ", 1300m, 15, 3 },
                    { 99, 2, "A performance-oriented combo organ with authentic tonewheel sounds and additional instrument sounds.", "/Images/ComboOrgans/roland1.png", "Roland VR-730 V-Combo Organ", 2200m, 7, 3 },
                    { 100, 2, "A dual manual combo organ featuring a comprehensive selection of organ sounds and drawbars.", "/Images/ComboOrgans/nord2.png", "Nord C2D 61-Key Combo Organ", 2800m, 6, 3 },
                    { 101, 2, "A portable organ inspired by the sound of classic combo organs from the 1970s.", "/Images/ComboOrgans/viscount1.png", "Viscount Legend '70s Portable Organ", 1700m, 10, 3 },
                    { 102, 2, "A MIDI controller designed for virtual piano software, providing an authentic piano playing experience.", "/Images/ComboOrgans/kawai1.png", "Kawai VPC1 Virtual Piano Controller", 1200m, 15, 3 },
                    { 103, 2, "A compact stage instrument with a wide range of sounds, including organ, piano, and synth tones.", "/Images/ComboOrgans/nord3.png", "Clavia Nord Stage 3 Compact", 3000m, 8, 3 },
                    { 104, 2, "A performance-oriented controller with a variety of sounds, including realistic organ and piano tones.", "/Images/ComboOrgans/kurzweil1.png", "Kurzweil PC4 Performance Controller", 2500m, 10, 3 },
                    { 105, 2, "A versatile stage keyboard featuring authentic Hammond organ sounds and a wide range of instrument tones.", "/Images/ComboOrgans/hammond2.png", "Hammond SKX Stage Keyboard", 2300m, 9, 3 },
                    { 106, 2, "A powerful arranger workstation with a wide range of voices, styles, and advanced performance features.", "/Images/Arrangers/yamaha1.png", "Yamaha PSR-SX900 Arranger Workstation", 2500m, 10, 4 },
                    { 107, 2, "A professional arranger keyboard with a vast library of sounds, styles, and easy-to-use features.", "/Images/Arrangers/korg1.png", "Korg Pa600 Professional Arranger", 1800m, 8, 4 },
                    { 108, 2, "An expandable arranger keyboard with a wide variety of realistic sounds, backing styles, and versatile features.", "/Images/Arrangers/roland1.png", "Roland E-A7 Expandable Arranger Keyboard", 2200m, 12, 4 },
                    { 109, 2, "A compact arranger module with high-quality sounds and styles, designed for professional performers.", "/Images/Arrangers/ketron1.png", "Ketron SD9 Professional Arranger Module", 2800m, 6, 4 },
                    { 110, 2, "An arranger keyboard with a diverse range of sounds, rhythms, and recording features, suitable for various genres.", "/Images/Arrangers/casio1.png", "Casio MZ-X300 Arranger Keyboard", 1600m, 15, 4 },
                    { 111, 2, "A professional arranger keyboard with advanced sound technology, extensive styles, and intuitive controls.", "/Images/Arrangers/korg2.png", "Korg Pa1000 Professional Arranger", 3000m, 7, 4 },
                    { 112, 2, "A flagship digital workstation with top-tier sounds, features, and a user-friendly interface for professional performers.", "/Images/Arrangers/yamaha2.png", "Yamaha Genos Digital Workstation", 3500m, 5, 4 },
                    { 113, 2, "A versatile backing keyboard with a wide selection of sounds, styles, and performance features.", "/Images/Arrangers/roland2.png", "Roland BK-9 Backing Keyboard", 2400m, 9, 4 },
                    { 114, 2, "A compact arranger module with high-quality sounds and styles, designed for live performances and studio use.", "/Images/Arrangers/ketron2.png", "Ketron SD7 Professional Arranger Module", 2600m, 8, 4 },
                    { 115, 2, "A portable keyboard with advanced arranger features, including a vast library of tones and rhythms.", "/Images/Arrangers/casio2.png", "Casio CT-X5000 Portable Keyboard", 1200m, 18, 4 },
                    { 116, 2, "A professional arranger keyboard with advanced sound technology, extensive styles, and a user-friendly interface.", "/Images/Arrangers/korg3.png", "Korg Pa4X 76-Key Professional Arranger", 3800m, 4, 4 },
                    { 117, 2, "An arranger workstation with a wide range of sounds, styles, and features for live performances and music production.", "/Images/Arrangers/yamaha3.png", "Yamaha PSR-S775 Arranger Workstation", 2000m, 11, 4 },
                    { 118, 2, "A compact arranger keyboard with a variety of sounds, styles, and features, suitable for beginners and advanced players.", "/Images/Arrangers/roland3.png", "Roland E-X30 Arranger Keyboard", 1000m, 20, 4 },
                    { 119, 2, "A versatile arranger module with a wide range of sounds and advanced features, designed for professional musicians.", "/Images/Arrangers/ketron3.png", "Ketron Audya 5 Arranger Module", 3200m, 6, 4 },
                    { 120, 2, "A workstation keyboard with arranger features, including a wide selection of tones, rhythms, and recording capabilities.", "/Images/Arrangers/casio3.png", "Casio WK-7600 Workstation Keyboard", 800m, 25, 4 },
                    { 121, 3, "A popular and versatile drum set known for its durability and balanced sound, suitable for various genres.", "/Images/DrumSets/pearl1.png", "Pearl Export Series 5-Piece Drum Set", 800m, 15, 1 },
                    { 122, 3, "A high-quality shell pack designed for studio recording, featuring versatile tonewoods and precise construction.", "/Images/DrumSets/mapex1.png", "Mapex Armory Series 6-Piece Studioease Shell Pack", 1200m, 10, 1 },
                    { 123, 3, "A premium drum set crafted with high-quality materials and meticulous attention to detail, favored by professionals.", "/Images/DrumSets/dw1.png", "DW Collector's Series 4-Piece Shell Pack", 2500m, 8, 1 },
                    { 124, 3, "A classic drum set with a powerful and focused sound, featuring high-quality maple shells and robust hardware.", "/Images/DrumSets/tama1.png", "Tama Superstar Classic 7-Piece Shell Pack", 1500m, 12, 1 },
                    { 125, 3, "A versatile maple drum set with warm tones and reliable hardware, suitable for various musical styles.", "/Images/DrumSets/gretsch1.png", "Gretsch Catalina Maple 6-Piece Shell Pack", 1100m, 10, 1 },
                    { 126, 3, "A compact and portable drum set with a punchy sound, ideal for small venues and tight spaces.", "/Images/DrumSets/sonor1.png", "Sonor AQ2 Martini 4-Piece Shell Pack", 700m, 18, 1 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Name", "Price", "Quantity", "SubCategoryId" },
                values: new object[,]
                {
                    { 127, 3, "A classic maple shell pack with timeless tones, ideal for vintage enthusiasts and modern drummers alike.", "/Images/DrumSets/ludwig1.png", "Ludwig Classic Maple 3-Piece Fab Shell Pack", 1800m, 8, 1 },
                    { 128, 3, "A budget-friendly maple drum set with professional features, offering a balanced and versatile sound.", "/Images/DrumSets/pdp1.png", "PDP Concept Maple 5-Piece Shell Pack", 900m, 14, 1 },
                    { 129, 3, "A handcrafted drum set with a unique maple/walnut blend, delivering a warm and rich sonic character.", "/Images/DrumSets/craviotto1.png", "Craviotto Custom Shop Maple/Walnut 4-Piece Shell Pack", 3200m, 6, 1 },
                    { 130, 3, "A reliable birch drum set known for its clear and focused sound, suitable for various playing styles.", "/Images/DrumSets/yamaha1.png", "Yamaha Stage Custom Birch 5-Piece Shell Pack", 1000m, 12, 1 },
                    { 131, 3, "An exotic wood shell pack with a combination of maple and walnut, providing a unique and powerful sound.", "/Images/DrumSets/mapex2.png", "Mapex Saturn V MH Exotic 4-Piece Shell Pack", 2200m, 9, 1 },
                    { 132, 3, "A versatile drum rack system with adjustable mounts, ideal for customizing and organizing drum setups.", "/Images/DrumSets/gibraltar1.png", "Gibraltar GRS-850DB Rack System", 300m, 25, 1 },
                    { 133, 3, "A set of silent drumheads designed for quiet practicing, featuring a realistic feel and reduced volume.", "/Images/DrumSets/remo1.png", "Remo Silentstroke Drumhead Pack", 80m, 30, 1 },
                    { 134, 3, "A set of dark and expressive cymbals from Zildjian's K Custom series, suitable for various musical genres.", "/Images/DrumSets/zildjian1.png", "Zildjian K Custom Dark Cymbal Set", 700m, 15, 1 },
                    { 135, 3, "A pair of classic drumsticks from Vic Firth, known for their balanced feel and versatility.", "/Images/DrumSets/vicfirth1.png", "Vic Firth 5A American Classic Drumsticks", 10m, 50, 1 },
                    { 136, 3, "A high-quality electronic drum kit with advanced sound technology, expressive playing feel, and versatile features.", "/Images/ElectronicDrumSets/roland1.png", "Roland TD-17KVX V-Drums Electronic Drum Kit", 1500m, 10, 2 },
                    { 137, 3, "An intermediate-level electronic drum set with realistic drum and cymbal pads, designed for quiet practice and live performances.", "/Images/ElectronicDrumSets/yamaha1.png", "Yamaha DTX522K Electronic Drum Set", 1100m, 8, 2 },
                    { 138, 3, "An affordable electronic drum set with mesh drum heads for a natural playing experience, suitable for beginners and practice sessions.", "/Images/ElectronicDrumSets/alesis1.png", "Alesis Nitro Mesh Kit Electronic Drum Set", 500m, 15, 2 },
                    { 139, 3, "A professional-grade electronic drum kit with advanced sound processing, realistic response, and customizable options.", "/Images/ElectronicDrumSets/roland2.png", "Roland TD-27KV V-Drums Electronic Drum Kit", 3000m, 12, 2 },
                    { 140, 3, "A premium electronic drum set with multiple mesh pads, advanced sound module, and extensive customization options.", "/Images/ElectronicDrumSets/alesis2.png", "Alesis Strike Pro Special Edition Electronic Drum Kit", 2500m, 8, 2 },
                    { 141, 3, "An innovative drum module that transforms acoustic drum kits into electronic instruments, featuring studio-quality effects.", "/Images/ElectronicDrumSets/yamaha2.png", "Yamaha EAD10 Electronic Acoustic Drum Module", 400m, 20, 2 },
                    { 142, 3, "An intermediate-level electronic drum kit with a wide range of sounds, responsive pads, and a sturdy rack.", "/Images/ElectronicDrumSets/simmons1.png", "Simmons SD600 Electronic Drum Kit", 800m, 18, 2 },
                    { 143, 3, "A flagship electronic drum set with advanced sensor technology, responsive pads, and a versatile sound module.", "/Images/ElectronicDrumSets/pearl1.png", "Pearl e/MERGE EM53H Electronic Drum Set", 3500m, 6, 2 },
                    { 144, 3, "A feature-rich electronic drum set with responsive pads, realistic drum sounds, and advanced control options.", "/Images/ElectronicDrumSets/kat1.png", "KAT Percussion KT4 Advanced Electronic Drum Set", 2000m, 10, 2 },
                    { 145, 3, "A compact and affordable electronic drum kit with a solid frame, responsive pads, and built-in coaching functions.", "/Images/ElectronicDrumSets/roland3.png", "Roland TD-1DMK V-Drums Electronic Drum Kit", 700m, 15, 2 },
                    { 146, 3, "An entry-level electronic drum set with mesh pads for a realistic playing experience, suitable for beginners.", "/Images/ElectronicDrumSets/alesis3.png", "Alesis Surge Mesh Kit Electronic Drum Set", 400m, 25, 2 },
                    { 147, 3, "An advanced electronic drum kit with an expansive sound library, responsive pads, and a user-friendly interface.", "/Images/ElectronicDrumSets/simmons2.png", "Simmons SD1200 Electronic Drum Kit", 1200m, 12, 2 },
                    { 148, 3, "An entry-level electronic drum set with dynamic drum pads, built-in training functions, and a compact design.", "/Images/ElectronicDrumSets/yamaha3.png", "Yamaha DTX452K Electronic Drum Set", 600m, 20, 2 },
                    { 149, 3, "A portable electronic drum kit with a folding design, responsive pads, and a compact footprint for easy storage.", "/Images/ElectronicDrumSets/roland4.png", "Roland TD-4KP V-Drums Portable Electronic Drum Kit", 900m, 15, 2 },
                    { 150, 3, "An intermediate-level electronic drum set with mesh pads, a powerful sound module, and extensive customization options.", "/Images/ElectronicDrumSets/alesis4.png", "Alesis Command Mesh Kit Electronic Drum Set", 800m, 18, 2 },
                    { 151, 3, "A professional-grade conga set with hand-selected buffalo heads, sturdy stands, and rich, resonant tones.", "/Images/WorldPercussion/meinl1.png", "Meinl Headliner Series Conga Set", 800m, 10, 3 },
                    { 152, 3, "A versatile bongo set with durable wood shells, rawhide heads, and traditional tuning lugs for authentic tones.", "/Images/WorldPercussion/lp1.png", "LP Aspire Bongo Set", 120m, 15, 3 },
                    { 153, 3, "An African-style djembe with a lightweight design, key-tuned head, and vibrant, resonant sounds.", "/Images/WorldPercussion/remo1.png", "Remo Djembe - Key-Tuned", 180m, 12, 3 },
                    { 154, 3, "A high-quality cajon with adjustable snare wires, birch wood construction, and a versatile sound for various genres.", "/Images/WorldPercussion/tycoon1.png", "Tycoon Percussion Cajon", 150m, 18, 3 },
                    { 155, 3, "A Brazilian-style pandeiro with a synthetic head, jingles, and a sturdy frame for traditional samba rhythms.", "/Images/WorldPercussion/pearl1.png", "Pearl Pandeiro", 60m, 20, 3 },
                    { 156, 3, "A handcrafted shekere with a fiberglass body, coconut shells, and a unique blend of warm and bright tones.", "/Images/WorldPercussion/meinl2.png", "Meinl Artisan Edition Shekere", 120m, 14, 3 },
                    { 157, 3, "Professional-grade timbales with 14\" and 15\" shells, traditional tuning, and a chrome finish for a bright sound.", "/Images/WorldPercussion/lp2.png", "LP Matador Timbales", 250m, 8, 3 },
                    { 158, 3, "An innovative ocean drum with a clear head filled with steel balls, producing soothing sounds reminiscent of the sea.", "/Images/WorldPercussion/remo2.png", "Remo Ocean Drum", 80m, 25, 3 },
                    { 159, 3, "Classic wooden maracas with a traditional design, delivering a bright and crisp sound for Latin music.", "/Images/WorldPercussion/tycoon2.png", "Tycoon Percussion Maracas", 20m, 30, 3 },
                    { 160, 3, "Hand-hammered tambourine with brass jingles, wooden frame, and a warm, articulate sound for various musical styles.", "/Images/WorldPercussion/meinl3.png", "Meinl Artisan Edition Tambourine", 50m, 20, 3 },
                    { 161, 3, "A durable steel triangle with a striker, offering clear and bright tones for percussion ensembles and arrangements.", "/Images/WorldPercussion/lp3.png", "LP Aspire Triangle", 15m, 40, 3 },
                    { 162, 3, "A frame drum with a synthetic head, pre-tuned for a deep and resonant tone, suitable for various world music styles.", "/Images/WorldPercussion/remo3.png", "Remo Tablatone Frame Drum", 70m, 15, 3 },
                    { 163, 3, "A decorative rainstick with a bamboo construction, producing a soothing sound reminiscent of falling rain.", "/Images/WorldPercussion/tycoon3.png", "Tycoon Percussion Rainstick", 25m, 30, 3 },
                    { 164, 3, "A kid-friendly djembe with a synthetic head, suitable for young percussionists exploring world rhythms.", "/Images/WorldPercussion/meinl4.png", "Meinl NINO African Style Djembe", 40m, 25, 3 },
                    { 165, 3, "A classic Latin percussion cowbell with a bright sound, perfect for adding accents to various musical genres.", "/Images/WorldPercussion/lp4.png", "LP Latin Percussion Cowbell", 30m, 35, 3 },
                    { 166, 3, "High-performance double bass drum pedal with adjustable cam and linkage for precise and smooth footwork.", "/Images/DrumAccessories/dw1.png", "DW 9000 Series Double Bass Drum Pedal", 400m, 8, 4 },
                    { 167, 3, "A set of professional-grade cymbals, including hi-hats, crashes, and ride, with bright and articulate tones.", "/Images/DrumAccessories/zildjian1.png", "Zildjian A Custom Cymbal Pack", 800m, 5, 4 },
                    { 168, 3, "Classic 5A drumsticks with a comfortable grip, suitable for various playing styles and genres.", "/Images/DrumAccessories/vicfirth1.png", "Vic Firth 5A Drumsticks", 10m, 50, 4 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Name", "Price", "Quantity", "SubCategoryId" },
                values: new object[,]
                {
                    { 169, 3, "A set of mesh drumheads designed for quiet practice sessions, maintaining realistic feel and response.", "/Images/DrumAccessories/remo1.png", "Remo Silentstroke Drumhead Pack", 60m, 20, 4 },
                    { 170, 3, "Adjustable drum throne with comfortable padding and sturdy construction for long-lasting playing comfort.", "/Images/DrumAccessories/gibraltar1.png", "Gibraltar Drum Throne", 80m, 15, 4 },
                    { 171, 3, "Durable hi-hat stand with smooth action and adjustable tension, providing precise control over hi-hat cymbals.", "/Images/DrumAccessories/tama1.png", "Tama Iron Cobra Hi-Hat Stand", 150m, 10, 4 },
                    { 172, 3, "Non-slip drum rug with ample space for drum kit placement, ensuring stability during intense playing sessions.", "/Images/DrumAccessories/meinl1.png", "Meinl Drum Rug", 70m, 12, 4 },
                    { 173, 3, "Innovative bass drum pedal with direct drive, providing fast and responsive playability for the modern drummer.", "/Images/DrumAccessories/pearl1.png", "Pearl Demon Drive Bass Drum Pedal", 250m, 8, 4 },
                    { 174, 3, "Entry-level cymbal set with bright and focused tones, ideal for beginner and intermediate drummers.", "/Images/DrumAccessories/sabian1.png", "Sabian B8X Performance Cymbal Set", 200m, 10, 4 },
                    { 175, 3, "Hydraulic drum throne with nitrogen gas shock absorber for comfortable and height-adjustable seating.", "/Images/DrumAccessories/rocnsoc1.png", "Roc-N-Soc Nitro Drum Throne", 120m, 12, 4 },
                    { 176, 3, "Heavy-duty drum cases designed for protection during transportation, featuring weather-resistant fabric and foam padding.", "/Images/DrumAccessories/ahead1.png", "Ahead Armor Drum Cases Set", 300m, 6, 4 },
                    { 177, 3, "Clear bass drum head with an internal control ring, providing a well-defined attack and controlled sustain.", "/Images/DrumAccessories/evans1.png", "Evans EQ3 Bass Drum Head", 40m, 25, 4 },
                    { 178, 3, "Complete hardware pack for drum kit setup, including sturdy stands and a reliable bass drum pedal.", "/Images/DrumAccessories/pdp1.png", "PDP Concept Series Hardware Pack", 180m, 10, 4 },
                    { 179, 3, "Versatile snare drum with a hybrid shell design, offering a balanced mix of warmth and brightness.", "/Images/DrumAccessories/mapex1.png", "Mapex Armory Snare Drum", 120m, 15, 4 },
                    { 180, 3, "Mounting claw for percussion accessories, providing a secure and adjustable attachment to drum hardware.", "/Images/DrumAccessories/lp1.png", "Latin Percussion LP Claw", 15m, 30, 4 },
                    { 181, 4, "Classic black t-shirt featuring the iconic 'Master of Puppets' album cover artwork from Metallica.", "/Images/MetalTShirts/metallica1.png", "Metallica Master of Puppets T-Shirt", 25m, 40, 1 },
                    { 182, 4, "Black t-shirt with the legendary Slayer eagle logo, a must-have for fans of thrash metal.", "/Images/MetalTShirts/slayer1.png", "Slayer Eagle Logo Tee", 20m, 35, 1 },
                    { 183, 4, "Official Iron Maiden t-shirt featuring the iconic 'Trooper' album artwork, perfect for Maiden enthusiasts.", "/Images/MetalTShirts/ironmaiden1.png", "Iron Maiden Trooper Shirt", 30m, 30, 1 },
                    { 184, 4, "Black t-shirt featuring the artwork from Megadeth's 'Rust in Peace' album, a classic design for metalheads.", "/Images/MetalTShirts/megadeth1.png", "Megadeth Rust in Peace Tee", 22m, 25, 1 },
                    { 185, 4, "Official Pantera t-shirt featuring the 'Vulgar Display of Power' album cover, a bold statement for fans.", "/Images/MetalTShirts/pantera1.png", "Pantera Vulgar Display of Power Shirt", 28m, 20, 1 },
                    { 186, 4, "Vintage-style Black Sabbath t-shirt featuring the iconic 'Paranoid' album artwork, a timeless classic.", "/Images/MetalTShirts/blacksabbath1.png", "Black Sabbath Paranoid Tee", 26m, 28, 1 },
                    { 187, 4, "Official Opeth t-shirt featuring the haunting 'Ghost Reveries' album artwork, perfect for progressive metal fans.", "/Images/MetalTShirts/opeth1.png", "Opeth Ghost Reveries Shirt", 30m, 22, 1 },
                    { 188, 4, "Brutal Cannibal Corpse t-shirt featuring the controversial 'Butchered at Birth' album cover, not for the faint-hearted.", "/Images/MetalTShirts/cannibalcorpse1.png", "Cannibal Corpse Butchered at Birth Tee", 24m, 18, 1 },
                    { 189, 4, "In Flames t-shirt featuring the iconic Jesterhead logo, a symbol of the band's melodic death metal legacy.", "/Images/MetalTShirts/inflames1.png", "In Flames Jesterhead Tee", 27m, 18, 1 },
                    { 190, 4, "Unique Meshuggah t-shirt featuring artwork from the 'Obzen' album, a statement for fans of extreme metal.", "/Images/MetalTShirts/meshuggah1.png", "Meshuggah Obzen Shirt", 28m, 15, 1 },
                    { 191, 4, "Official Behemoth t-shirt featuring imagery from the critically acclaimed 'The Satanist' album.", "/Images/MetalTShirts/behemoth1.png", "Behemoth The Satanist Tee", 32m, 12, 1 },
                    { 192, 4, "Viking-themed Amon Amarth t-shirt featuring a majestic ship design, perfect for fans of melodic death metal.", "/Images/MetalTShirts/amonamarth1.png", "Amon Amarth Viking Ship Shirt", 26m, 16, 1 },
                    { 193, 4, "Nightwish t-shirt featuring artwork from the 'Endless Forms Most Beautiful' album, a must-have for symphonic metal enthusiasts.", "/Images/MetalTShirts/nightwish1.png", "Nightwish Endless Forms Most Beautiful Tee", 28m, 14, 1 },
                    { 194, 4, "Official Deicide t-shirt featuring imagery from the iconic 'Legion' album, a classic design for death metal devotees.", "/Images/MetalTShirts/deicide1.png", "Deicide Legion Shirt", 25m, 20, 1 },
                    { 195, 4, "High-energy Children of Bodom t-shirt featuring the 'Hate Crew Deathroll' album artwork.", "/Images/MetalTShirts/cob1.png", "Children of Bodom Hate Crew Deathroll Tee", 22m, 24, 1 },
                    { 196, 4, "High-quality leather guitar strap with adjustable length and comfortable padding, perfect for long gigs.", "/Images/GuitarStraps/levys1.png", "Levy's Leather Guitar Strap", 40m, 25, 2 },
                    { 197, 4, "Durable and lightweight polypropylene guitar strap with an adjustable length, featuring the iconic Ernie Ball logo.", "/Images/GuitarStraps/ernieball1.png", "Ernie Ball Polypro Guitar Strap", 15m, 50, 2 },
                    { 198, 4, "Colorful and stylish woven guitar strap with leather ends, providing both durability and visual appeal.", "/Images/GuitarStraps/daddario1.png", "D'Addario Planet Waves Woven Strap", 20m, 40, 2 },
                    { 199, 4, "Classic Fender monogrammed guitar strap with an adjustable length, featuring the iconic Fender logo.", "/Images/GuitarStraps/fenderstrap1.png", "Fender Monogrammed Guitar Strap", 25m, 35, 2 },
                    { 200, 4, "Premium leather guitar strap with embossed Gibson logo, offering both style and comfort for your guitar.", "/Images/GuitarStraps/gibsonstrap1.png", "Gibson The Classic Strap", 50m, 20, 2 },
                    { 201, 4, "Secure and adjustable ClipLock guitar strap by DiMarzio, ensuring your guitar stays in place during intense performances.", "/Images/GuitarStraps/dimarzio1.png", "DiMarzio ClipLock Guitar Strap", 30m, 30, 2 },
                    { 202, 4, "Innovative polypropylene guitar strap with a locking mechanism, providing security and peace of mind while playing.", "/Images/GuitarStraps/lockit1.png", "Lock-It Straps Poly Classic", 35m, 25, 2 },
                    { 203, 4, "Luxurious leather guitar strap by PRS with the iconic bird inlay design, combining style and craftsmanship.", "/Images/GuitarStraps/prsstrap1.png", "PRS Leather Bird Strap", 60m, 15, 2 },
                    { 204, 4, "Vintage-inspired tweed guitar strap with genuine leather ends, offering a classic look for your instrument.", "/Images/GuitarStraps/leathergraft1.png", "Leathergraft Vintage Tweed Strap", 45m, 18, 2 },
                    { 205, 4, "Ergonomically designed SoloStrap Neo by Gruv Gear, providing comfort and even weight distribution for long playing sessions.", "/Images/GuitarStraps/gruvgear1.png", "Gruv Gear SoloStrap Neo", 55m, 22, 2 },
                    { 206, 4, "Vintage-style suede guitar strap by LM Products, combining a timeless look with durability and comfort.", "/Images/GuitarStraps/lmproducts1.png", "LM Products Vintage Suede Strap", 38m, 28, 2 },
                    { 207, 4, "Handmade guitar strap from the Mojo Collection by RightOn!, featuring unique designs and quality materials.", "/Images/GuitarStraps/righton1.png", "RightOn! Mojo Collection Strap", 42m, 24, 2 },
                    { 208, 4, "Vintage-inspired woven guitar strap by Souldier, handmade with recycled materials for a sustainable and stylish choice.", "/Images/GuitarStraps/souldier1.png", "Souldier Vintage Woven Strap", 48m, 20, 2 },
                    { 209, 4, "Adjustable and ergonomic guitar strap by Mono, featuring a minimalist design and comfortable shoulder pad.", "/Images/GuitarStraps/mono1.png", "Mono M80 Betty Strap", 32m, 32, 2 },
                    { 210, 4, "Premium leather guitar strap by Taylor with embossed Nouveau design, offering a blend of style and quality.", "/Images/GuitarStraps/taylor1.png", "Taylor Nouveau Leather Strap", 58m, 16, 2 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Name", "Price", "Quantity", "SubCategoryId" },
                values: new object[,]
                {
                    { 211, 4, "Sturdy and adjustable guitar stand with a folding design by Hercules, suitable for both electric and acoustic guitars.", "/Images/Stands/hercules1.png", "Hercules GS414B Guitar Stand", 30m, 25, 3 },
                    { 212, 4, "Classic XCG4 guitar stand by On-Stage with a durable design and secure locking mechanism, ideal for stage and studio use.", "/Images/Stands/onstage1.png", "On-Stage XCG4 Guitar Stand", 20m, 40, 3 },
                    { 213, 4, "Professional-grade GS-1000 Pro guitar stand by Ultimate Support, featuring a sleek design and reliable stability for your instrument.", "/Images/Stands/ultimate1.png", "Ultimate Support GS-1000 Pro Guitar Stand", 40m, 30, 3 },
                    { 214, 4, "Wall-mounted guitar hanger by String Swing, allowing you to display your guitar securely while saving floor space.", "/Images/Stands/stringswing1.png", "String Swing CC01K Guitar Hanger", 15m, 35, 3 },
                    { 215, 4, "Adjustable single-braced X-style keyboard stand by Yamaha, suitable for a variety of keyboard sizes and weights.", "/Images/Stands/yamaha1.png", "Yamaha PKBS1 Keyboard Stand", 35m, 28, 3 },
                    { 216, 4, "Heavy-duty double-braced keyboard stand by Quik Lok, providing stability and adjustability for various keyboard setups.", "/Images/Stands/quiklok1.png", "Quik Lok WS-551 Keyboard Stand", 50m, 20, 3 },
                    { 217, 4, "Table-style keyboard stand by K&M, offering a versatile and stable platform for your keyboard during performances.", "/Images/Stands/km1.png", "K&M Omega Table-Style Keyboard Stand", 60m, 18, 3 },
                    { 218, 4, "Adjustable X-style keyboard stand by Roland, featuring a sturdy design and easy setup for various keyboard models.", "/Images/Stands/roland1.png", "Roland KS-10X Keyboard Stand", 45m, 22, 3 },
                    { 219, 4, "Piano-style sustain pedal by Korg, designed for use with keyboards and digital pianos, providing expressive control.", "/Images/Stands/korg1.png", "Korg PS3 Piano-Style Sustain Pedal", 25m, 32, 3 },
                    { 220, 4, "Heavy-duty keyboard stand by Gator Frameworks, offering stability and adjustability for various keyboard setups.", "/Images/Stands/gator1.png", "Gator Frameworks GFW-KEY-1000X Keyboard Stand", 55m, 24, 3 },
                    { 221, 4, "Single X-style keyboard stand by Casio, featuring an adjustable height design for comfortable playing.", "/Images/Stands/casio1.png", "Casio ARST Single X Keyboard Stand", 30m, 28, 3 },
                    { 222, 4, "Z-style keyboard stand by Neewer, providing a stable and space-saving solution for various keyboard setups.", "/Images/Stands/neewer1.png", "Neewer Heavy Duty Z-Style Keyboard Stand", 65m, 15, 3 },
                    { 223, 4, "Pre-assembled double-X keyboard stand by RockJam, featuring a sturdy design and easy setup for different keyboard sizes.", "/Images/Stands/rockjam1.png", "RockJam Xfinity Heavy-Duty Double-X Pre-Assembled Keyboard Stand", 40m, 30, 3 },
                    { 224, 4, "Triple pedal unit by Kawai, designed for use with digital pianos, providing enhanced control over sustain, sostenuto, and soft functions.", "/Images/Stands/kawai1.png", "Kawai F-30 Triple Pedal Unit", 75m, 18, 3 },
                    { 225, 4, "High-quality instrument cable by Mogami, featuring gold-plated connectors for optimal signal transfer and durability.", "/Images/Connectors/mogami1.png", "Mogami Gold Instrument Cable", 25m, 40, 3 },
                    { 226, 4, "Reliable instrument cable by Planet Waves, with molded plugs for strain relief and oxygen-free copper conductors.", "/Images/Connectors/planetwaves1.png", "Planet Waves Classic Series Instrument Cable", 15m, 50, 3 },
                    { 227, 4, "Straight to straight guitar cable by Hosa, offering a simple and effective solution for connecting guitars and amplifiers.", "/Images/Connectors/hosa1.png", "Hosa GTR-210 Straight to Straight Guitar Cable", 10m, 60, 3 },
                    { 228, 4, "Customizable effects kit cable by George L's, allowing you to create patch cables of various lengths for your pedalboard.", "/Images/Connectors/georgels1.png", "George L's Effects Kit Cable", 20m, 35, 3 },
                    { 229, 4, "MIDI cable by HOSA, providing reliable and low-noise connectivity for MIDI devices such as keyboards and controllers.", "/Images/Connectors/hosa2.png", "HOSA MID-310BK MIDI Cable", 12m, 45, 3 },
                    { 230, 4, "Interconnect cable by Roland, designed for connecting keyboards, synthesizers, and other audio devices with 1/4-inch jacks.", "/Images/Connectors/roland2.png", "Roland Black Series Interconnect Cable", 18m, 30, 3 },
                    { 231, 4, "MIDI Thru box by MIDI Solutions, providing four individually addressable MIDI Thru outputs for routing MIDI signals.", "/Images/Connectors/midisolutions1.png", "MIDI Solutions Quadra Thru", 30m, 25, 3 },
                    { 232, 4, "Adapter cable by Hosa, allowing the connection of devices with 3.5mm TRS jacks to devices with 1/4\" TRS jacks.", "/Images/Connectors/hosa3.png", "Hosa GPM-103 3.5mm TRS to 1/4\" TRS Adapter", 8m, 50, 3 },
                    { 233, 4, "Premium RCA to RCA audio cable by Mogami, ideal for connecting audio interfaces, mixers, and other audio equipment.", "/Images/Connectors/mogami2.png", "Mogami Gold RCA to RCA Audio Cable", 22m, 28, 3 },
                    { 234, 4, "Y-Cable by Pro Co PowerPlus, featuring sturdy connectors for splitting power to multiple pedals on your pedalboard.", "/Images/Connectors/proco1.png", "Pro Co PowerPlus Y-Cable", 15m, 40, 3 },
                    { 235, 4, "Insert cable by HOSA, allowing the connection of audio processors and effects units to mixing consoles.", "/Images/Connectors/hosa4.png", "HOSA STP-201 1/4\" TRS to Dual 1/4\" TS Insert Cable", 14m, 38, 3 },
                    { 236, 4, "Premium instrument cable by Roland Black Series, featuring heavy-duty connectors for reliable performance.", "/Images/Connectors/roland3.png", "Roland RIC-B3 Black Series Instrument Cable", 28m, 32, 3 },
                    { 237, 4, "MIDI Merger by MIDI Solutions, allowing the combination of MIDI data from two sources into a single MIDI stream.", "/Images/Connectors/midisolutions2.png", "MIDI Solutions Merger", 35m, 22, 3 },
                    { 238, 4, "Sync cable by Korg, designed for connecting Korg volca series and other compatible devices for synchronized operation.", "/Images/Connectors/korg2.png", "Korg SQ-Cable-6 Sync Cable", 10m, 45, 3 },
                    { 239, 4, "Dual MIDI cable by Livewire Essential, featuring reliable connectors for connecting MIDI devices in your setup.", "/Images/Connectors/livewire1.png", "Livewire Essential Dual MIDI Cable", 16m, 36, 3 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "UserName" },
                values: new object[] { 1, "sahan@gmail.com", "Sahan" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
