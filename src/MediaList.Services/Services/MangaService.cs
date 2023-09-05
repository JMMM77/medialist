using AutoMapper;
using MediaList.Data.Infrastructure;
using MediaList.Data.Interfaces;
using MediaList.Data.Models;
using MediaList.Services.Interfaces;
using MediaList.Services.Models;

namespace MediaList.Services.Services
{
    public class MangaService : IMangaService
    {
        private readonly IMapper _mapper;
        private readonly IMangaRepository _mangaRepository;
        private readonly IMediaTypeRepository _mediaTypeRepository;

        public MangaService(IMapper mapper, IMangaRepository mangaRepository, IMediaTypeRepository mediaTypeRepository)
        {
            _mapper = mapper;
            _mangaRepository = mangaRepository;
            _mediaTypeRepository = mediaTypeRepository;
        }

        public async Task<List<MangaViewModel>> Get()
        {
            var dbModels = await _mangaRepository.GetAsync();

            return _mapper.Map<List<MangaViewModel>>(dbModels);
        }
            
        public async Task<MangaViewModel> Get(string id)
        {
            var dbModel = await _mangaRepository.GetAsync(id);
            var viewModel = _mapper.Map<MangaViewModel>(dbModel);

            viewModel.NamedType = _mediaTypeRepository.GetAsync(viewModel.Type).Result?.Name ?? "";

            return viewModel;
        }

        public async Task<MangaViewModel> Post(Manga newManga)
        {
            await _mangaRepository.CreateAsync(newManga);

            return _mapper.Map<MangaViewModel>(newManga);
        }

        public async Task<MangaViewModel> Update(string id, Manga updatedManga)
        {
            var manga = await _mangaRepository.GetAsync(id);

            if (manga == null) { 
                return _mapper.Map<MangaViewModel>(new Manga());
            }
            updatedManga.Id = manga?.Id;

            await _mangaRepository.UpdateAsync(id, updatedManga);

            return _mapper.Map<MangaViewModel>(updatedManga);
        }

        public async Task<MangaViewModel> Delete(string id)
        {
            var Manga = await _mangaRepository.GetAsync(id);

            if (Manga is null)
            {
                return _mapper.Map<MangaViewModel>(new Manga());
            }

            await _mangaRepository.RemoveAsync(id);

            return _mapper.Map<MangaViewModel>(new Manga());
        }
    }
}
