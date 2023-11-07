namespace EntityData.DatabaseSettings
{
    public class LoginStoreDatabaseSettings
    {
        public string ConnectionString { get; set; } = null!;

        public string DatabaseName { get; set; } = null!;

        public string LoginsCollectionName { get; set; } = null!;
    }
}
