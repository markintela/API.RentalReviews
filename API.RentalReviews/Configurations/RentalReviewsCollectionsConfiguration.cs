using ServicesDomain.Services;

namespace API.RentalReviews.Configurations
{
    public static class RentalReviewsCollectionsConfiguration
    {

        public static void AddRentalReviewsCollectionsConfiguration(this IServiceCollection services)
        {
            services.AddSingleton<UserService>();
            services.AddSingleton<RentService>();
            services.AddSingleton<ReviewService>();
        }
    }
}
