using Microsoft.EntityFrameworkCore;

namespace ParksLookup.Models
{
  public class ParksLookupContext : DbContext
  {
    public ParksLookupContext(DbContextOptions<ParksLookupContext> options)
      : base(options)
      { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Park>()
        .HasData(
          new Park { ParkId = 1, ParkName = "Mount Rainier", ParkLocation = "Washington" },
          new Park { ParkId = 2, ParkName = "North Cascades", ParkLocation = "Washington"},
          new Park { ParkId = 3, ParkName = "Zion", ParkLocation = "Utah" },
          new Park { ParkId = 4, ParkName = "Shenandoah", ParkLocation = "Virginia"},
          new Park { ParkId = 5, ParkName = "Redwood", ParkLocation = "California"}
        );
    }

    public DbSet<Park> Parks {get; set;}
  }
}