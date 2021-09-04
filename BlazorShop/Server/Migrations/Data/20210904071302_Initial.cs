using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorShop.Server.Migrations.Data
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
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
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OriginalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Views = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "car", "Cars", "cars" },
                    { 2, "bike", "Bikes", "bikes" },
                    { 3, "aircraft", "Aircrafts", "aicrafts" },
                    { 4, "tank", "Tanks", "tanks" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateUpdated", "Description", "Image", "IsDeleted", "IsPublic", "OriginalPrice", "Price", "Title", "Views" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "The A80 program began in February 1989 under various teams for design, product planning, and engineering led by Isao Tsuzuki. By the middle of 1990, a final A80 design concept from Toyota Technical Centre Aichi was approved and frozen for production in late 1990. The first test mules were hand-built in A70 bodies during late 1990, followed by the first A80 prototypes being hand-assembled in 1991. Again using subframe, suspension, and drivetrain assemblies from the Z30 Soarer (Lexus SC300/400), pre-production of the test models started in December 1992 with 20 units made, and official mass production began in April 1993. The fourth generation of the Supra again shared its platform with the upscale Soarer coupé, sold in the U.S. as the Lexus SC. Although the two cars looked similar dimension-wise, the new Supra was more than 13 inches (340 mm) shorter than its luxurious cousin.", "https://upload.wikimedia.org/wikipedia/commons/thumb/7/72/1994_Toyota_Supra_Sport_Roof_in_Red%2C_front_left.jpg/1200px-1994_Toyota_Supra_Sport_Roof_in_Red%2C_front_left.jpg", false, false, 120000m, 90000m, "Toyota Supra 2002", 0 },
                    { 2, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "The performance model was the Challenger R/T (Road/Track), with a 383 cu in (6.3 L) Magnum V8, rated at 335 hp (250 kW); 300 hp (224 kW) for 1971, due to a drop in compression. The standard transmission was a 3-speed manual. Optional R/T engines were the 375 hp (280 kW) 440 cu in (7.2 L) Magnum, the 390 hp (291 kW) 440 cu in (7.2 L) Six-Pack and the 426 cu in (7.0 L) Hemi rated at 425 hp (431 PS; 317 kW) at 5,000 rpm and 490 lb⋅ft (664 N⋅m) of torque at 4,000 rpm. The R/T was available in either the hardtop or convertible. The Challenger R/T came with a Rallye instrument cluster that included a 150 mph (240 km/h) speedometer, an 8,000 rpm tachometer and an oil pressure gauge.The shaker hood scoop was not available after 1971.", "https://upload.wikimedia.org/wikipedia/commons/thumb/8/88/%2770_Dodge_Challenger_%28Les_chauds_vendredis_%2710%29.jpg/1200px-%2770_Dodge_Challenger_%28Les_chauds_vendredis_%2710%29.jpg", false, false, 90000m, 75000m, "Dodge Challenger R/T 1969", 0 },
                    { 3, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "The Porsche Carrera GT (Project Code 980) is a mid-engine sports car that was manufactured by German automobile manufacturer Porsche from 2004 to 2007.Sports Car International named the Carrera GT number one on its list of Top Sports Cars of the 2000s, and number eight on Top Sports Cars of All Time list. For its advanced technology and development of its chassis, Popular Science magazine awarded it the Best of What's New award in 2003.", "https://upload.wikimedia.org/wikipedia/commons/6/65/Porsche_Carrera_GT_-_Goodwood_Breakfast_Club_%28July_2008%29.jpg", false, false, 1000000m, 750000m, "Porsche Carrera GT 2007", 0 },
                    { 4, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "The Nissan GT-R is a high-performance sports car and grand tourer produced by Nissan that was unveiled in 2007.It is the successor to the Skyline GT-R, a high performance variant of the Nissan Skyline. Although the car is the sixth-generation model to bear the GT-R name, the model is no longer part of the Nissan Skyline model lineup since that name is now reserved for Nissan's luxury-sport vehicles.", "https://upload.wikimedia.org/wikipedia/commons/7/7e/Nissan_GT-R_MY2017_%281%29.jpg", false, false, 115000m, 99000m, "Nissan GT-R 2019", 0 },
                    { 5, 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "The BMW E24 is the first generation of BMW 6 Series range of grand tourer cars, which was produced from January 1976 to 1989 and replaced the BMW E9 coupé.The E24 was produced solely in a 2-door coupé body style. All models used petrol straight-six engines, with the majority (aside from the M635CSi/M6 model) using a version of the BMW M30 engine family. The E24 was initially based on the E12 5 Series platform, until it switched to the newly-released E28 5 Series platform in 1982.The M635CSi is the first of the BMW M6 model line and is powered by the M88/3 straight-six engine. In North America, the vehicle is badged as M6 and uses the less powerful BMW S38 engine.", "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ae/1985_BMW_M635CSi_-_11.jpg/280px-1985_BMW_M635CSi_-_11.jpg", false, false, 0m, 150000m, "BMW M6 E24 1989", 0 },
                    { 6, 2, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "The Harley-Davidson Fat Boy, is a V-twin softail cruiser motorcycle with solid-cast disc wheels. Designed by Willie G. Davidson and Louie Netz, Harley-Davidson built a prototype Fat Boy in Milwaukee for the Daytona Bike Week rally at Daytona Beach in 1988 and 1989. Fat Boys produced from 1990-2017 are coded FLSTF, and FLFB (& FLFBS) from 2018.The name is said (by a New York seller of Harley Davidson parts) to come from a contraction of Fat Man and Little Boy, the atomic bombs dropped on Japan during WWII.", "https://cdp.azureedge.net/products/USA/HD/2020/MC/CRUISER/FAT_BOY_114/50/VIVID_BLACK/2000000014.jpg", false, false, 30000m, 24999m, "Harley-Davidson Fat Boy 2013", 0 },
                    { 7, 2, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "The Kawasaki Ninja 650R, also called ER-6f or EХ-6, is a motorcycle in the Ninja series from the Japanese manufacturer Kawasaki sold since 2006. The 2012 model drops the R suffix from its name. It is a middleweight, parallel-twin engined motorcycle, designed for normal use on paved roads. They have modern styling and features, with low-seating ergonomics and a low center of gravity. The engine has a 180° crankshaft, resulting in an uneven firing interval of 0° and 540°.", "https://upload.wikimedia.org/wikipedia/commons/0/02/Ninja650-2009model.jpg", false, false, 0m, 19000m, "Kawasaki Ninja 650 2020", 0 },
                    { 8, 2, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "The Honda Gold Wing is a series of touring motorcycles manufactured by Honda. Gold Wings feature shaft drive, and a flat engine. Introduced at the Cologne Motorcycle Show in October 1974, the Gold Wing went on to become a popular model in North America, Western Europe and Australia, as well as Japan.", "https://upload.wikimedia.org/wikipedia/commons/7/7d/Honda_Gold_Wing_GL_1800_%28SC79_-_2018%29.jpg", false, false, 23000m, 17999m, "Honda Gold Wing 2015", 0 },
                    { 9, 3, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "The Supermarine Spitfire is a British single-seat fighter aircraft that was used by the Royal Air Force and other Allied countries before, during, and after World War II. Many variants of the Spitfire were built, using several wing configurations, and it was produced in greater numbers than any other British aircraft. It was also the only British fighter produced continuously throughout the war. The Spitfire continues to be popular among enthusiasts; nearly 60 remain airworthy, and many more are static exhibits in aviation museums throughout the world.", "https://upload.wikimedia.org/wikipedia/commons/0/04/Supermarine_Spitfire_Vb_%27AB910_SH-F%27_%2845209564741%29.jpg", false, false, 0m, 3000000m, "Supermarine Spitfire 1948", 0 },
                    { 10, 3, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "The Lockheed SR-71 Blackbird is a long-range, high-altitude, Mach 3+ strategic reconnaissance aircraft developed and manufactured by the American aerospace company Lockheed Corporation. It was operated by both the United States Air Force (USAF) and NASA.", "https://www.euroaviaforlibologna.eu/wp-content/uploads/2020/06/Lockheed_SR-71-1024x831.jpg", false, false, 0m, 15000000m, "Lockheed SR-71 Blackbird 1966", 0 },
                    { 11, 3, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "he Sukhoi Su-57 (Russian: Сухой Су-57; NATO reporting name: Felon)] is a single-seat, twin-engine stealth multirole fighter developed by Sukhoi for the Russian Aerospace Forces.The aircraft is the product of the PAK FA Perspektivny Aviatsionny Kompleks Frontovoy Aviatsii, lit. ''prospective aeronautical complex of front-line air forces'') fighter programme that would form the basis for a family of stealth combat aircraft. Sukhoi's internal designation for the aircraft is T-50. The Su-57 is the first fighter in Russian military service to feature stealth technology.", "https://upload.wikimedia.org/wikipedia/commons/thumb/8/8d/Sukhoi_Design_Bureau%2C_054%2C_Sukhoi_Su-57_%2849581306507%29.jpg/640px-Sukhoi_Design_Bureau%2C_054%2C_Sukhoi_Su-57_%2849581306507%29.jpg", false, false, 0m, 25000000m, "Sukhou Su-57 2009", 0 },
                    { 12, 4, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "The M1 Abrams is a third-generation American main battle tank designed by Chrysler Defense (now General Dynamics Land Systems) and named for General Creighton Abrams. Conceived for modern armored ground warfare and now one of the heaviest tanks in service at nearly 68 short tons (almost 62 metric tons), it introduced several innovative features, including a multifuel turbine engine, sophisticated Chobham composite armor, a computer fire control system, separate ammunition storage in a blow-out compartment, and NBC protection for crew safety. Initial models of the M1 were armed with a licensed-produced 105 mm Royal Ordnance L7 gun, while later variants feature a licensed Rheinmetall 120 mm L/44.", "https://upload.wikimedia.org/wikipedia/commons/9/92/Mounted_Soldier_System_%28MSS%29.jpg", false, false, 18000000m, 15000000m, "M1 Abrams 1981", 0 },
                    { 13, 4, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "e T-14 Armata (Russian: Т-14 «Армата»; industrial designation Ob'yekt 148, Russian: Объект 148) is a next-generation Russian main battle tank based on the Armata Universal Combat Platform—the first series-produced next-generation tank. The Russian Army initially planned to acquire 2,300 T-14s between 2015 and 2020. Production and fiscal shortfalls delayed this to 2025, and then to the cancellation of the main production run. The test batch of 100 is to be delivered and deployed to the 2nd Guards Tamanskaya Motor Rifle Division, with delivery expected to begin in 2022; tanks will be transferred only after the completion of all state tests.", "https://upload.wikimedia.org/wikipedia/commons/c/cf/Alabino110416-18.jpg", false, false, 0m, 30000000m, "T-14 Armata 2015", 0 },
                    { 14, 4, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "The T-34 is a Soviet medium tank introduced in 1940, famously deployed with the Red Army during World War II against Operation Barbarossa. Its 76.2 mm tank gun was more powerful than its contemporaries while its 60 degree sloped armour provided good protection against anti-tank weapons.", "https://upload.wikimedia.org/wikipedia/commons/4/42/Char_T-34.jpg", false, false, 2000000m, 1500000m, "T-34", 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Stats");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
