namespace EntityData.DatabaseSettings
{
    public class RentStoreDatabaseSettings
    {
        public string ConnectionString { get; set; } = null!;

        public string DatabaseName { get; set; } = null!;

        public string RentsCollectionName { get; set; } = null!;
    }
}
