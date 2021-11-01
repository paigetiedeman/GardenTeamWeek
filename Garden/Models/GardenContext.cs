using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Garden.Models
{
  public class GardenContext : DbContext
  {
    public DbSet<Plot> Plots { get; set; }

    public DbSet<Squarefoot> Squarefoots { get; set; }

    public GardenContext(DbContextOptions<GardenContext> options) : base(options) { }
    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //   optionsBuilder.UseLazyLoadingProxies();
    // }

    // protected override void OnModelCreating(ModelBuilder builder)
    //   {
    //     // modelBuilder.Entity<IdentityUserClaim<string>>().HasKey(p => new {p.id});
    //   builder.Entity<Plot>().HasData(
    //   new Plot { PlotId = 1, Name = "Small Plot", Sun = "Bright", Soil = "Dirty", Hardiness = 1, Width = 6, Length = 6, Privacy = null, User = null },
    //   new Plot { PlotId = 2, Name = "Medium Plot", Sun = "Dark", Soil = "Moist", Hardiness = 2, Width = 12, Length = 12, Privacy = null, User = null },
    //   new Plot { PlotId = 3, Name = "Large Plot", Sun = "Seven", Soil = "Roosevelt", Hardiness = 3, Width = 18, Length = 18, Privacy = null, User = null }
    //     );
    //   }
}
}