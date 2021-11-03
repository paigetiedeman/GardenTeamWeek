using System.ComponentModel.DataAnnotations;

namespace Garden.Models
{
  public class Plot
  {
    public int PlotId { get; set; }
    [Required]
    public string Name { get; set; }
    public string Sun { get; set; }
    public string Soil { get; set; }
    [Range(1, 11, ErrorMessage = "Please enter a number between 1-11")]
    public int Hardiness { get; set; }
    [Required]
    public int Width { get; set; }
    [Required]
    public int Length { get; set; }
    [Required]
    public int Depth { get; set; }
    public string Privacy { get; set; }
    public virtual ApplicationUser User { get; set; }
  }
}