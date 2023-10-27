namespace API.RentalReviews.DatabaseSettings
{
    public class SignatureStoreDatabaseSettings
    {
        public string ConnectionString { get; set; } = null!;

        public string DatabaseName { get; set; } = null!;

        public string SignaturesCollectionName { get; set; } = null!;
    }
}
