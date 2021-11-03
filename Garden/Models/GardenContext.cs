using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Garden.Models
{
  public class GardenContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Plot> Plots { get; set; }
    public DbSet<Seed> Seeds { get; set; }

    public DbSet<Squarefoot> Squarefoots { get; set; }

    public GardenContext(DbContextOptions<GardenContext> options) : base(options) { }

  }
}