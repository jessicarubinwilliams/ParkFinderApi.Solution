using System.ComponentModel.DataAnnotations;

namespace ParkFinder.Models
{
  public class Park
  {
    public int ParkId { get; set; }
    [Required]
    [StringLength(100)]
    public string Name { get; set; }
    [Required]
    [StringLength (135)]
    public string Location { get; set; }
    [Required]
    public bool IsNationalPark { get; set; }
    [Required]
    public bool IsOtherFederalLand { get; set; }
    [Required]
    public bool IsStatePark { get; set; }
    [Required]
    public bool IsCountyPark { get; set; }
    [Required]
    public bool IsCityOrMunicipalPark { get; set; }
    [Required]
    public bool IsPrivatePark { get; set; }
    [Required]
    public bool IsFree { get; set; }
    [Required]
    [Range(0,5, ErrorMessage = "Rating must be between 0 and 5.")]
    public string Rating { get; set; }
    [Required]
    [StringLength(500)]
    public string Comments { get; set; }
  }
}