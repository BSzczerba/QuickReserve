using AutoMapper;
using QuickReserve.Application.Dtos;
using QuickReserve.Domain.Entities;


namespace QuickReserve.Application.Mappings
{
    public class QuickReserveMappingProfile : Profile
    {
        public QuickReserveMappingProfile()
        {
            CreateMap<RestaurantDto, Restaurant>()
                .ForMember(e => e.ContancDetails, opt => opt.MapFrom(src => new RestaurantContancDetails()
                {
                    City = src.City,
                    PhoneNumber = src.PhoneNumber,
                    PostalCode = src.PostalCode,
                    Street = src.Street,
                }));

            CreateMap<Restaurant, RestaurantDto>()
                .ForMember(e => e.Street, opt => opt.MapFrom(scr => scr.ContancDetails.Street))
                .ForMember(e => e.PostalCode, opt => opt.MapFrom(scr => scr.ContancDetails.PostalCode))
                .ForMember(e => e.City, opt => opt.MapFrom(scr => scr.ContancDetails.City))
                .ForMember(e => e.PhoneNumber, opt => opt.MapFrom(scr => scr.ContancDetails.PhoneNumber));
        }
    }
}
