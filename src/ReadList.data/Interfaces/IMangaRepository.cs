using ReadList.Data.Models;

namespace ReadList.Data.Interfaces
{
    public interface IMangaRepository
    {
        public Task<List<Manga>> GetAsync();
        public Task<Manga?> GetAsync(string id);

        public Task CreateAsync(Manga newManga);

        public Task UpdateAsync(string id, Manga updatedManga);

        public Task RemoveAsync(string id);
    }
}
