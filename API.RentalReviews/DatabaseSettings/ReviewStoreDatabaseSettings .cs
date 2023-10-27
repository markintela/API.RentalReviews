namespace API.RentalReviews.DatabaseSettings
{
    public class ReviewStoreDatabaseSettings
    {
        public string ConnectionString { get; set; } = null!;

        public string DatabaseName { get; set; } = null!;

        public string ReviewsCollectionName { get; set; } = null!;
    }
}
