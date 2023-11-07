using AutoMapper;
using EntityData.Models;
using ServicesDomain.Views.User;

namespace ServicesDomain.Mappers
{
    public class UserProfile : Profile
    {

        public UserProfile()
        {

            CreateMap<UserPostView, User>()
           .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.Name))
           .ForMember(dest => dest.From, opt => opt.MapFrom(src => src.From));


            CreateMap<UserPutView, User>()
           .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.Nome))
           .ForMember(dest => dest.From, opt => opt.MapFrom(src => src.From));

        }




    }
}
