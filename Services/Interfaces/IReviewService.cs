using EntityData.Models;
using ServicesDomain.Views.Review;

namespace ServicesDomain.Interfaces
{
    public interface IReviewService
    {
        Task<Review> CreateAsync(Review review);
        Task<List<Review>> GetAllAsync();
        Task<Review> GetAsync(int id);
        Task<Review> UpdateAsync(Review review);
        Task DeleteAsync(int id);
    }
}
