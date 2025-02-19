using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QuickReserve.Domain.Entities;

namespace QuickReserve.Infrastructure.Persistence
{
    public class QuickReserveDbContext: IdentityDbContext
    {
        public QuickReserveDbContext(DbContextOptions<QuickReserveDbContext> options) : base(options)
        {

        }

        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Restaurant>()
                .OwnsOne(c => c.ContancDetails);

            modelBuilder.Entity<Restaurant>()
                .HasMany(c => c.Dishes)
                .WithOne(s => s.Restaurant)
                .HasForeignKey(s => s.RestaurantId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Restaurant>()
                .HasMany(c => c.Tables)
                .WithOne(s => s.Restaurant)
                .HasForeignKey(s => s.RestaurantId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Table>()
                .HasMany(c => c.Reservations)
                .WithOne(s => s.Table)
                .HasForeignKey(s => s.TableId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
