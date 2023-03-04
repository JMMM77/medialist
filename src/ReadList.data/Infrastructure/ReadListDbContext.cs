using Microsoft.Extensions.Options;
using MongoDB.Driver;
using ReadList.Data.Models;

namespace ReadList.Data.Infrastructure
{
    public class ReadListDbContext
    {
        public IMongoCollection<Manga> Mangas { get; set; }

        public ReadListDbContext(IOptions<ReadListDatabaseSettings> options)
        {
            var mongoClient = new MongoClient(
                options.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                options.Value.DatabaseName);

            Mangas = mongoDatabase.GetCollection<Manga>(
                options.Value.MangaCollectionName);

        }

    }
}
