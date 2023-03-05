using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MediaList.Data.Models;

namespace MediaList.Data.Infrastructure
{
    public class MediaListDbContext
    {
        public IMongoCollection<Manga> Mangas { get; set; }

        public MediaListDbContext(IOptions<MediaListDatabaseSettings> options)
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
