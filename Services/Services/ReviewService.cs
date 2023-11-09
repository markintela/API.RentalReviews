using AutoMapper;
using EntityData.DatabaseSettings;
using EntityData.Models;
using Microsoft.Extensions.Options;
using ServicesDomain.Interfaces;
using ServicesDomain.Views.Review;

namespace ServicesDomain.Services
{
    public class ReviewService : IReviewService
    {
        private readonly IMapper _mapper;

        public ReviewService()
        {
       
        }

        public Task<Review> CreateAsync(Review review)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Review>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Review> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Review> UpdateAsync(Review review)
        {
            throw new NotImplementedException();
        }
    }
}
