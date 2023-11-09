using AutoMapper;
using EntityData.Models;
using ServicesDomain.Views.Rent;

namespace ServicesDomain.Mappers
{
    public class RentProfile : Profile
    {

        public RentProfile()
        {
            CreateMap<RentPostView, Rent>();

        }

    }
}
