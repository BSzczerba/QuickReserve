using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using QuickReserve.Application.Mappings;
using QuickReserve.Application.Services;
using QuickReserve.Application.Services.Interfaces;


namespace QuickReserve.Application.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddApplication(this IServiceCollection services)
        {

            services.AddScoped(provider => new MapperConfiguration(cfg =>
            {
                var scope = provider.CreateScope();
                cfg.AddProfile(new QuickReserveMappingProfile());
            }).CreateMapper()
            );

            services.AddScoped<IRestaurantService,RestaurantService>();
        }
    }
}
