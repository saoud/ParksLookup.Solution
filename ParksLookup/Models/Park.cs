using System.ComponentModel.DataAnnotations;

namespace ParksLookup.Models
{
  public class Park
  {
    [Required]
    public int ParkId {get; set;}

    [Required]
    public string ParkName {get; set;}

    [Required]
    public string ParkLocation {get; set;}
  }
}