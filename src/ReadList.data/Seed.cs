using MongoDB.Bson;
using MongoDB.Driver;
using ReadList.Data.Infrastructure;
using ReadList.Data.Models;

namespace ReadList.Data
{
    public static class Seed
    {
        public static async Task DoSeedAsync(ReadListDbContext context)
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
