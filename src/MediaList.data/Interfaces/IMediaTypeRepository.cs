using MediaList.Data.Models;

namespace MediaList.Data.Interfaces
{
    public interface IMediaTypeRepository
    {
        public Task<List<MediaType>> GetAsync();
        public Task<MediaType?> GetAsync(string id);

        public Task CreateAsync(MediaType newMediaType);

        public Task UpdateAsync(string id, MediaType updatedMediaType);

        public Task RemoveAsync(string id);
    }
}