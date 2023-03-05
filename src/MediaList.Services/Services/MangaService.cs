using AutoMapper;
using MediaList.Data.Interfaces;
using MediaList.Data.Models;
using MediaList.Services.Interfaces;
using MediaList.Services.Models;

namespace MediaList.Services.Services
{
    public class MangaService : IMangaService
    {
        private readonly IMapper _mapper;
        private readonly IMangaRepository _MangaRepository;

        public MangaService(IMapper mapper, IMangaRepository MangaRepository)
        {
            _mapper = mapper;
            _MangaRepository = MangaRepository;
        }

        public async Task<List<MangaViewModel>> Get()
        {
            var dbModels = await _MangaRepository.GetAsync();

            return _mapper.Map<List<MangaViewModel>>(dbModels);
        }
            
        public async Task<MangaViewModel> Get(string id)
        {
            var dbModel = await _MangaRepository.GetAsync(id);

            return _mapper.Map<MangaViewModel>(dbModel);
        }

        public async Task<MangaViewModel> Post(Manga newManga)
        {
            await _MangaRepository.CreateAsync(newManga);

            return _mapper.Map<MangaViewModel>(newManga);
        }
        public async Task<MangaViewModel> Update(string id, Manga updatedManga)
        {
            var manga = await _MangaRepository.GetAsync(id);

            if (manga == null) { 
                return _mapper.Map<MangaViewModel>(new Manga());
            }
            updatedManga.Id = manga?.Id;

            await _MangaRepository.UpdateAsync(id, updatedManga);

            return _mapper.Map<MangaViewModel>(updatedManga);
        }

        public async Task<MangaViewModel> Delete(string id)
        {
            var Manga = await _MangaRepository.GetAsync(id);

            if (Manga is null)
            {
                return _mapper.Map<MangaViewModel>(new Manga());
            }

            await _MangaRepository.RemoveAsync(id);

            return _mapper.Map<MangaViewModel>(new Manga());
        }
    }
}
