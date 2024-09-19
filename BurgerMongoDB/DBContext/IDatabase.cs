namespace BurgerMongoDB.DBContext
{
    public interface IDatabase
    {
        string ConnectionString { get; set; }
        string Database { get; set; }
        string CollectionDB { get; set; }
    }
}
