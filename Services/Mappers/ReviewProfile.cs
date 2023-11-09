using AutoMapper;
using EntityData.Models;

using ServicesDomain.Views.Review;

namespace ServicesDomain.Mappers
{
    public class ReviewProfile : Profile
    {
        public ReviewProfile()
        {

            CreateMap<ReviewPostView, Review>();
            CreateMap<ReviewPutView, Review>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src._id))
            .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
            .ForMember(dest => dest.Score, opt => opt.MapFrom(src => src.Score));

        }
    }
}
