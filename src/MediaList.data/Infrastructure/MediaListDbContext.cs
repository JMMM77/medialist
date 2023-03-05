using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MediaList.Data.Models;

namespace MediaList.Data.Infrastructure
{
    public class MediaListDbContext
    {
        public IMongoCollection<Genre> Genres { get; set; }
        public IMongoCollection<MediaType> MediaTypes { get; set; }
        public IMongoCollection<Manga> Mangas { get; set; }

        public MediaListDbContext(IOptions<MediaListDatabaseSettings> options)
        {
            var mongoClient = new MongoClient(
                options.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                options.Value.DatabaseName);

            Genres = mongoDatabase.GetCollection<Genre>(
                options.Value.GenreCollectionName);

            MediaTypes = mongoDatabase.GetCollection<MediaType>(
                options.Value.MediaTypeCollectionName);

            Mangas = mongoDatabase.GetCollection<Manga>(
                options.Value.MangaCollectionName);

        }

    }
}
