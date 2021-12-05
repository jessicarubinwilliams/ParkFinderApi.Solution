using Microsoft.EntityFrameworkCore;

namespace ParkFinder.Models
{
  public class ParkFinderContext : DbContext
  {
    public ParkFinderContext(DbContextOptions<ParkFinderContext> options)
      : base(options)
      {
      }

      protected override void OnModelCreating(ModelBuilder builder)
      {
        builder.Entity<Park>()
          .HasData(
            new Park
            { 
              ParkId = 1,
              Name = "Mount Rainier National Park",
              Location = "Ashford, WA",
              IsNationalPark = true,
              IsOtherFederalLand = false,
              IsStatePark = false,
              IsCountyPark = false,
              IsCityOrMunicipalPark = false,
              IsPrivatePark = false,
              IsFree = false,
              Rating = "5",
              Comments = "Breathtaking"
            },
            new Park
            { 
              ParkId = 2,
              Name = "Mount Jefferson Wilderness",
              Location = "Sisters, Oregon",
              IsNationalPark = false,
              IsOtherFederalLand = true,
              IsStatePark = false,
              IsCountyPark = false,
              IsCityOrMunicipalPark = false,
              IsPrivatePark = false,
              IsFree = false,
              Rating = "5",
              Comments = "Wildflowers season is bonkers. The fee for a Central Cascades Wilderness Permit is minimal and totally worth it."
            },
            new Park
            { 
              ParkId = 3,
              Name = "Oswald West State Park",
              Location = "Arch Cape, OR",
              IsNationalPark = false,
              IsOtherFederalLand = false,
              IsStatePark = true,
              IsCountyPark = false,
              IsCityOrMunicipalPark = false,
              IsPrivatePark = false,
              IsFree = true,
              Rating = "4",
              Comments = "Whether you want a short hike or a long one, you can enjoy coastal forest, beaches and tidal pools here. An Oregon gem."
            },
            new Park
            { 
              ParkId = 4,
              Name = "Smith and Bybee Wetlands Natural Area",
              Location = "Portland, OR",
              IsNationalPark = false,
              IsOtherFederalLand = false,
              IsStatePark = false,
              IsCountyPark = true,
              IsCityOrMunicipalPark = false,
              IsPrivatePark = false,
              IsFree = true,
              Rating = "4",
              Comments = "While listed here as a County Park, Smith and Bybee is technically run by Metro, a regional form of government unique to the Portland Metropolitan Area. A lovely wetland great for paddling right in the city. Popular spot--be prepared for putting in and taking out (as well as parking) to be crowded. Once you're out on the water however, you can usually find some peace and quite to accompany your beautiful view."
            },
            new Park
            { 
              ParkId = 5,
              Name = "Esther Short Park",
              Location = "Vancouver, WA",
              IsNationalPark = false,
              IsOtherFederalLand = false,
              IsStatePark = false,
              IsCountyPark = false,
              IsCityOrMunicipalPark = true,
              IsPrivatePark = false,
              IsFree = true,
              Rating = "3",
              Comments = "Home to many great events including the downtown Vancouver Farmers Market."
            },
            new Park
            { 
              ParkId = 6,
              Name = "Elk Rock Garden at Bishop's Close",
              Location = "Portland, OR",
              IsNationalPark = false,
              IsOtherFederalLand = false,
              IsStatePark = false,
              IsCountyPark = false,
              IsCityOrMunicipalPark = false,
              IsPrivatePark = true,
              IsFree = true,
              Rating = "4",
              Comments = "Truly a hidden gem of Portland. A beautiful garden with charming paths and a wonderful view of the Willamette River. Thank you to the Episcopal Diocese of Portland for this gift to the community."
            }
          );
      }

      public DbSet<Park> Parks { get; set; }
  }
}