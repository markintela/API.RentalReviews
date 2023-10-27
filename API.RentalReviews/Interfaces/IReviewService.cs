using API.RentalReviews.Models;
using API.RentalReviews.Views.Review;

namespace API.RentalReviews.Interfaces
{
    public interface IReviewService
    {
        Task CreateReviewsAsync(string id, List<ReviewPostView> reviewListCreate);

        Task UpdateReviewsAsync(string id, ReviewPutView reviewUpdate);
    }
}
