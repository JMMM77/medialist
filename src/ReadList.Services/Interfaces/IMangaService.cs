using Microsoft.AspNetCore.Mvc;
using MediaList.Data.Models;
using MediaList.Services.Models;

namespace MediaList.Services.Interfaces
{
    public interface IMangaService
    {
        public Task<List<MangaViewModel>> Get();

        public Task<MangaViewModel> Get(string id);

        public Task<MangaViewModel> Post(Manga newManga);

        public Task<MangaViewModel> Update(string id, Manga updatedManga);

        public Task<MangaViewModel> Delete(string id);
    }
}
