using MongoDB.Driver;
using ServicesDomain.Services;

namespace API.RentalReviews.Configurations
{
    public static class RentalReviewsServicesConfiguration
    {

        public static void AddRentalReviewsServicesConfiguration(this IServiceCollection services)
        {
            services.AddSingleton<UserService>();
            services.AddSingleton<RentService>();
            services.AddSingleton<ReviewService>();
           
         
        }
    }
}
