using Microsoft.AspNetCore.Mvc;
using MediaList.Data.Models;
using MediaList.Services.Models;

namespace MediaList.Services.Interfaces
{
    public interface IMediaService
    {
        /// <summary>
        /// Get all of the available media types
        /// </summary>
        /// <returns>IEnumerable list of media types</returns>
        public Task<IEnumerable<MediaTypeViewModel>> GetAllMediaTypes();

        /// <summary>
        /// Get all of the available genres
        /// </summary>
        /// <returns>IEnumerable list of genres</returns>
        public Task<IEnumerable<GenreViewModel>> GetAllGenres();
    }
}
