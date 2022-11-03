using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models.Domain;

namespace WebApplication1.Repositories
{
    public class RegionRepository : IRegionRepository
    {
        private readonly NZWalkDBContext nzWalkDBContext;
        public RegionRepository(NZWalkDBContext nzWalkDbContext)
        {
            this.nzWalkDBContext = nzWalkDbContext;
        }
        public async Task<IEnumerable<Region>> GetAllRegions()
        {
            return await nzWalkDBContext.Regions.ToListAsync();
        }
    }
}
