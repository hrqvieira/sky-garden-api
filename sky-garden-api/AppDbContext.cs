using Microsoft.EntityFrameworkCore;
using sky_garden_api.src.Plants;
using sky_garden_api.src.wateringCans;

namespace sky_garden_api
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<WateringCan> WateringCan { get; set; }
        public DbSet<Plant> Plant { get; set; }
    }
}
