using QuickReserve.Application.Dtos;

namespace QuickReserve.Application.Services.Interfaces
{
    public interface IRestaurantService
    {
        Task<IEnumerable<RestaurantDto>> GetAll();
        Task<RestaurantDto> GetByName(string name);
    }
}