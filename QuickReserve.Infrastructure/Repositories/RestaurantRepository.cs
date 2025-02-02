using Microsoft.EntityFrameworkCore;
using QuickReserve.Domain.Entities;
using QuickReserve.Domain.Interfaces;
using QuickReserve.Infrastructure.Persistence;


namespace QuickReserve.Infrastructure.Repositories
{
    public class RestaurantRepository : IRestaurantRepository
    {
        private readonly QuickReserveDbContext dbContext;

        public RestaurantRepository(QuickReserveDbContext dbContextd)
        {
            this.dbContext = dbContextd;
        }
        public async Task<IEnumerable<Restaurant>> GetAll()
        => await dbContext.Restaurants.ToListAsync();

        public async Task<Restaurant?> GetByName(string name)
        => await dbContext.Restaurants.FirstOrDefaultAsync(r => r.Name.ToLower() == name.ToLower());

    }
}
