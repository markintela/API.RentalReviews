using API.RentalReviews.Models;
using API.RentalReviews.Views.Review;
using AutoMapper;
using MongoDB.Bson;

namespace API.RentalReviews.Mappers
{
    public class ReviewProfile : Profile
    {
        public ReviewProfile()
        {

            CreateMap<ReviewPostView, Review>()
            .ForMember(dest => dest._id, opt => opt.MapFrom(src => ObjectId.GenerateNewId().ToString()))
            .ForMember(dest => dest.TypeReview, opt => opt.MapFrom(src => src.TypeReview))
            .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
            .ForMember(dest => dest.Score, opt => opt.MapFrom(src => src.Score))
            .ForMember(dest => dest.DateReview, opt => opt.MapFrom(src => src.DateReview));

            CreateMap<ReviewPutView, Review>()
            .ForMember(dest => dest._id, opt => opt.MapFrom(src => src._id))
            .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
            .ForMember(dest => dest.Score, opt => opt.MapFrom(src => src.Score));
   
        }
    }
}
