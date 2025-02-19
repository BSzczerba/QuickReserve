using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using QuickReserve.Domain.Interfaces;
using QuickReserve.Infrastructure.Persistence;
using QuickReserve.Infrastructure.Repositories;
using QuickReserve.Infrastructure.Seeders;

namespace QuickReserve.Infrastructure.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<QuickReserveDbContext>(options => options.UseSqlServer(
    configuration.GetConnectionString("ComputerService")));

            services.AddDefaultIdentity<IdentityUser>()
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<QuickReserveDbContext>();

            services.AddScoped<RestaurantSeeder>();

            services.AddScoped<IRestaurantRepository, RestaurantRepository>();

        }
    }
}
