using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkFinderAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parks",
                columns: table => new
                {
                    ParkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(100) CHARACTER SET utf8mb4", maxLength: 100, nullable: false),
                    Location = table.Column<string>(type: "varchar(135) CHARACTER SET utf8mb4", maxLength: 135, nullable: false),
                    IsNationalPark = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsOtherFederalLand = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsStatePark = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsCountyPark = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsCityOrMunicipalPark = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsPrivatePark = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsFree = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Rating = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Comments = table.Column<string>(type: "varchar(500) CHARACTER SET utf8mb4", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parks", x => x.ParkId);
                });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Comments", "IsCityOrMunicipalPark", "IsCountyPark", "IsFree", "IsNationalPark", "IsOtherFederalLand", "IsPrivatePark", "IsStatePark", "Location", "Name", "Rating" },
                values: new object[,]
                {
                    { 1, "Breathtaking", false, false, false, true, false, false, false, "Ashford, WA", "Mount Rainier National Park", "5" },
                    { 2, "Wildflowers season is bonkers. The fee for a Central Cascades Wilderness Permit is minimal and totally worth it.", false, false, false, false, true, false, false, "Sisters, Oregon", "Mount Jefferson Wilderness", "5" },
                    { 3, "Whether you want a short hike or a long one, you can enjoy coastal forest, beaches and tidal pools here. An Oregon gem.", false, false, true, false, false, false, true, "Arch Cape, OR", "Oswald West State Park", "4" },
                    { 4, "While listed here as a County Park, Smith and Bybee is technically run by Metro, a regional form of government unique to the Portland Metropolitan Area. A lovely wetland great for paddling right in the city. Popular spot--be prepared for putting in and taking out (as well as parking) to be crowded. Once you're out on the water however, you can usually find some peace and quite to accompany your beautiful view.", false, true, true, false, false, false, false, "Portland, OR", "Smith and Bybee Wetlands Natural Area", "4" },
                    { 5, "Home to many great events including the downtown Vancouver Farmers Market.", true, false, true, false, false, false, false, "Vancouver, WA", "Esther Short Park", "3" },
                    { 6, "Truly a hidden gem of Portland. A beautiful garden with charming paths and a wonderful view of the Willamette River. Thank you to the Episcopal Diocese of Portland for this gift to the community.", false, false, true, false, false, true, false, "Portland, OR", "Elk Rock Garden at Bishop's Close", "4" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parks");
        }
    }
}
