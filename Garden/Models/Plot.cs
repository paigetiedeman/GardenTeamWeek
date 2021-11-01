namespace Garden.Models
{
  public class Plot
  {
    public int PlotId { get; set; }

    public string Name { get; set; }
    public string Sun { get; set; }
    public string Soil { get; set; }
    public int Hardiness { get; set; }
    public int Width { get; set; }
    public int Length { get; set; }
    public int Depth { get; set; }
    public string Privacy { get; set; }
    public virtual ApplicationUser User { get; set; }

    // public int GetDimensions()
    // { 
      
    // }
  }
}