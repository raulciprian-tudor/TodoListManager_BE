using MongoDB.Driver;

namespace Todo_List_Manager___BE.Data
{
    public class MongoDbService
    {
        private readonly IConfiguration _configuration;
        private readonly IMongoDatabase? _database;
        public MongoDbService(IConfiguration configuration)
        {
            _configuration = configuration;

            var connectionString = _configuration.GetConnectionString("dbConnection");
            var mongoUrl = new MongoUrl(connectionString);
            var mongoClient = new MongoClient(mongoUrl);
            _database = mongoClient.GetDatabase(mongoUrl.DatabaseName);
        }

        public IMongoDatabase? Database => _database;
    }
}
