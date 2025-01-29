
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using QuickReserve.Infrastructure.Persistence;

namespace QuickReserve.Infrastructure.Extensions
{
    public static class QuickReserveExtension
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<QuickReserveDbContext>(options => options.UseSqlServer(
    configuration.GetConnectionString("ComputerService")));

            //services.AddScoped<>();

        }
    }
}
