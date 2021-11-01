using System;

namespace Garden.Models
{ 
  public class Squarefoot
  { 
    public int SquarefootId { get; set; }
    public int SeedId { get; set; }
    public DateTime PlantDate { get; set; }
    public DateTime HarvestDate { get; set; }
    public int PlotId { get; set; }
    public bool NeedsWater { get; set; }
    public DateTime LastWaterDate { get; set; }
    public virtual ApplicationUser User { get; set; }
  }
}