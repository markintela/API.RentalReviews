using API.RenalReviews.Models;
using API.RentalReviews.Views.User;
using AutoMapper;

namespace API.RentalReviews.Mappers
{
    public class UserProfile : Profile
    {

        public UserProfile()
        {

            CreateMap<UserPostView, User>()
           .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.Nome))
           .ForMember(dest => dest.From, opt => opt.MapFrom(src => src.From));

        }
    }
}
