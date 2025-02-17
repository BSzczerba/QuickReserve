using QuickReserve.Domain.Entities;

namespace QuickReserve.Domain.Interfaces
{
    public interface IRestaurantRepository
    {
        Task<Restaurant?> GetByEncodedName(string encodedName);
        Task<IEnumerable<Restaurant>> GetAll();
    }
}
