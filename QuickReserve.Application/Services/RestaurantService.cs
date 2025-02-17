using AutoMapper;
using QuickReserve.Application.Dtos;
using QuickReserve.Application.Services.Interfaces;
using QuickReserve.Domain.Interfaces;


namespace QuickReserve.Application.Services
{
    public class RestaurantService : IRestaurantService
    {
        private readonly IRestaurantRepository restaurantRepository;
        private readonly IMapper mapper;

        public RestaurantService(IRestaurantRepository restaurantRepository, IMapper mapper)
        {
            this.restaurantRepository = restaurantRepository;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<RestaurantDto>> GetAll()
        {
            var restaurants = await restaurantRepository.GetAll();

            var dtos = mapper.Map<List<RestaurantDto>>(restaurants);

            return dtos;
        }

        public async Task<RestaurantDto> GetByEncodedName(string encodedName)
        {
            var restaurant = await restaurantRepository.GetByEncodedName(encodedName);

            if (restaurant == null)
            {
                throw new InvalidOperationException("Sequence contains no elements");
            }

            var dto = mapper.Map<RestaurantDto>(restaurant);

            return dto;
        }
    }
}
