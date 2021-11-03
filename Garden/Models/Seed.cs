using System.ComponentModel.DataAnnotations;
namespace Garden.Models
{
  public class Seed
  {
    public int SeedId { get; set; }
    [Required]
    public string SeedName { get; set; }
    public int SqFootPlant { get; set; }
    public int DaysTillHarvest { get; set; }
    public int WaterInterval { get; set; }
    public int DaysTillSprout { get; set; }
    public string Companions { get; set; }
    public string Enemies { get; set; }
  }
}