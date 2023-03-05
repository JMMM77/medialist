using Microsoft.AspNetCore.Mvc;
using MediaList.Data.Models;
using MediaList.Services.Models;

namespace MediaList.Services.Interfaces
{
    public interface IMediaTypeService
    {
        public Task<List<MediaTypeViewModel>> Get();

        public Task<MediaTypeViewModel> Get(string id);

        public Task<MediaTypeViewModel> Post(MediaType newMediaType);

        public Task<MediaTypeViewModel> Update(string id, MediaType updatedMediaType);

        public Task<MediaTypeViewModel> Delete(string id);
    }
}
