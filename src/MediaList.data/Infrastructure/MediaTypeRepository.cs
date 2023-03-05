using MongoDB.Driver;
using MediaList.Data.Interfaces;
using MediaList.Data.Models;

namespace MediaList.Data.Infrastructure
{
    public class MediaTypeRepository : IMediaTypeRepository
    {
        private readonly IMongoCollection<MediaType> _MediaTypesCollection;

        public MediaTypeRepository(MediaListDbContext context)
        {
            _MediaTypesCollection = context.MediaTypes;
        }

        public async Task<List<MediaType>> GetAsync() =>
            await _MediaTypesCollection.Find(_ => true).ToListAsync();

        public async Task<MediaType?> GetAsync(string id) =>
            await _MediaTypesCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(MediaType newMediaType) =>
            await _MediaTypesCollection.InsertOneAsync(newMediaType);

        public async Task UpdateAsync(string id, MediaType updatedMediaType) =>
            await _MediaTypesCollection.ReplaceOneAsync(x => x.Id == id, updatedMediaType);

        public async Task RemoveAsync(string id) =>
            await _MediaTypesCollection.DeleteOneAsync(x => x.Id == id);
    }
}
