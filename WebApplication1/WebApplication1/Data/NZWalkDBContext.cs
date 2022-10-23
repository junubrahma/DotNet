using Microsoft.EntityFrameworkCore;
using WebApplication1.Models.Domain;

namespace WebApplication1.Data
{
    public class NZWalkDBContext :DbContext
    {
        public NZWalkDBContext(DbContextOptions<NZWalkDBContext> options):base(options)
        {

        }
        public DbSet<Region> Regions { get; set; }

        public DbSet<Walk> Walks{ get; set; }
        public DbSet<WalkDifficulty> WalkDifficulty{ get; set; }

    }
}
