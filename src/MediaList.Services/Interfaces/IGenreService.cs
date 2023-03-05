using Microsoft.AspNetCore.Mvc;
using MediaList.Data.Models;
using MediaList.Services.Models;

namespace MediaList.Services.Interfaces
{
    public interface IGenreService
    {
        public Task<List<GenreViewModel>> Get();

        public Task<GenreViewModel> Get(string id);

        public Task<GenreViewModel> Post(Genre newGenre);

        public Task<GenreViewModel> Update(string id, Genre updatedGenre);

        public Task<GenreViewModel> Delete(string id);
    }
}
