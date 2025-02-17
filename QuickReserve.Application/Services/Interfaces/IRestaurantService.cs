using QuickReserve.Application.Dtos;

namespace QuickReserve.Application.Services.Interfaces
{
    public interface IRestaurantService
    {
        Task<IEnumerable<RestaurantDto>> GetAll();
        Task<RestaurantDto> GetByEncodedName(string encodedName);
    }
}