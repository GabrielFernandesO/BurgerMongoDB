namespace BurgerMongoDB.DBContext
{
    public class DBStoreSettings : IDatabase
    {
        public string ConnectionString { get; set; } = string.Empty;
        public string Database { get; set; } = string.Empty;
        public string CollectionDB { get; set; } = string.Empty;

    }
}
