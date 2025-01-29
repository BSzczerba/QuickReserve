using Microsoft.EntityFrameworkCore;
using QuickReserve.Domain.Entities;

namespace QuickReserve.Infrastructure.Persistence
{
    public class QuickReserveDbContext: DbContext
    {
        public QuickReserveDbContext(DbContextOptions<QuickReserveDbContext> options) : base(options)
        {

        }

        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Dish> Dishes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Restaurant>()
                .OwnsOne(c => c.ContancDetails);

            modelBuilder.Entity<Restaurant>()
                .HasMany(c => c.Dishes)
                .WithOne(s => s.Restaurant)
                .HasForeignKey(s => s.RestaurantId);
        }
    }
}
