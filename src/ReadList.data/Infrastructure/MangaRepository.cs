using MongoDB.Driver;
using ReadList.Data.Interfaces;
using ReadList.Data.Models;

namespace ReadList.Data.Infrastructure
{
    public class MangaRepository : IMangaRepository
    {
        private readonly IMongoCollection<Manga> _MangasCollection;

        public MangaRepository(ReadListDbContext context)
        {
            _MangasCollection = context.Mangas;
        }

        public async Task<List<Manga>> GetAsync() =>
            await _MangasCollection.Find(_ => true).ToListAsync();

        public async Task<Manga?> GetAsync(string id) =>
            await _MangasCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(Manga newManga) =>
            await _MangasCollection.InsertOneAsync(newManga);

        public async Task UpdateAsync(string id, Manga updatedManga) =>
            await _MangasCollection.ReplaceOneAsync(x => x.Id == id, updatedManga);

        public async Task RemoveAsync(string id) =>
            await _MangasCollection.DeleteOneAsync(x => x.Id == id);
    }
}
