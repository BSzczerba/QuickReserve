using QuickReserve.Domain.Entities;

namespace QuickReserve.Domain.Interfaces
{
    public interface IRestaurantRepository
    {
        Task<Restaurant?> GetByName(string name);
        Task<IEnumerable<Restaurant>> GetAll();
    }
}
