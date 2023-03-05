using MediaList.Data.Models;

namespace MediaList.Data.Interfaces
{
    public interface IGenreRepository
    {
        public Task<List<Genre>> GetAsync();
        public Task<Genre?> GetAsync(string id);

        public Task CreateAsync(Genre newGenre);

        public Task UpdateAsync(string id, Genre updatedGenre);

        public Task RemoveAsync(string id);
    }
}