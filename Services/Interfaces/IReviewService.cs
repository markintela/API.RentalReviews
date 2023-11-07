using ServicesDomain.Views.Review;

namespace ServicesDomain.Interfaces
{
    public interface IReviewService
    {
        Task CreateReviewsAsync(string id, List<ReviewPostView> reviewListCreate);

        Task UpdateReviewsAsync(string id, ReviewPutView reviewUpdate);
    }
}
