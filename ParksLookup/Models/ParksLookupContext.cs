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
          new Park { ParkId = 1, ParkName = "Yellowstone National Park", ParkLocation = "Wyoming" },
          new Park { ParkId = 2, ParkName = "Glacier National Park", ParkLocation = "Montana"},
          new Park { ParkId = 3, ParkName = "Grand Canyon National Park", ParkLocation = "Arzona" },
          new Park { ParkId = 4, ParkName = "Crater Lake National Park", ParkLocation = "Oregon"},
          new Park { ParkId = 5, ParkName = "Joshua Tree National Park", ParkLocation = "California"}
        );
    }

    public DbSet<Park> Parks {get; set;}
  }
}