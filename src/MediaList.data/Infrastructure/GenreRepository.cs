using MongoDB.Driver;
using MediaList.Data.Interfaces;
using MediaList.Data.Models;

namespace MediaList.Data.Infrastructure
{
    public class GenreRepository : IGenreRepository
    {
        private readonly IMongoCollection<Genre> _GenresCollection;

        public GenreRepository(MediaListDbContext context)
        {
            _GenresCollection = context.Genres;
        }

        public async Task<List<Genre>> GetAsync() =>
            await _GenresCollection.Find(_ => true).ToListAsync();

        public async Task<Genre?> GetAsync(string id) =>
            await _GenresCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(Genre newGenre) =>
            await _GenresCollection.InsertOneAsync(newGenre);

        public async Task UpdateAsync(string id, Genre updatedGenre) =>
            await _GenresCollection.ReplaceOneAsync(x => x.Id == id, updatedGenre);

        public async Task RemoveAsync(string id) =>
            await _GenresCollection.DeleteOneAsync(x => x.Id == id);
    }
}