using API.RenalReviews.Models;
using API.RentalReviews.Views.Rent;
using API.RentalReviews.Views.User;
using AutoMapper;

namespace API.RentalReviews.Mappers
{
    public class RentProfile : Profile
    {

        public RentProfile()
        {
            CreateMap<RentPostView, Rent>()
           .ForMember(dest => dest.Id_User, opt => opt.MapFrom(src => src.Id_User))
           .ForMember(dest => dest.TypeResource, opt => opt.MapFrom(src => src.TypeResource))
           .ForMember(dest => dest.TypeImmobile, opt => opt.MapFrom(src => src.TypeImmobile))
           .ForMember(dest => dest.DateBegin, opt => opt.MapFrom(src => src.DateBegin))
           .ForMember(dest => dest.DateEnd, opt => opt.MapFrom(src => src.DateEnd))
           .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price))
           .ForMember(dest => dest.Location, opt => opt.MapFrom(src => src.Location))
           //.ForMember(dest => dest.Reviews, null)
           .ForMember(dest => dest.Comment, opt => opt.MapFrom(src => src.Comment));

        }

    }
}
