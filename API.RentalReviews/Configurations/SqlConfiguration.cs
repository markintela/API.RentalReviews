using EntityData.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace API.RentalReviews.Configurations
{
    static class SqlConfiguration
    {
        public static void AddSqlConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            var database = configuration.GetConnectionString("SqlConnection");
            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(database);

            });

        }
    }
}
