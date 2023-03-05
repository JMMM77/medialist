using MongoDB.Bson;
using MongoDB.Driver;
using MediaList.Data.Infrastructure;
using MediaList.Data.Models;

namespace MediaList.Data
{
    public static class Seed
    {
        public static async Task DoSeedAsync(MediaListDbContext context)
        {
            var mangaCount = await context.Mangas.CountDocumentsAsync(new BsonDocument());
            if (mangaCount != 0)
            {
                return;
            }

            var mangasToAdd = new Manga[] { new() { Name = "Test" } };

            await context.Mangas.InsertManyAsync(mangasToAdd);
        }
    }
}
