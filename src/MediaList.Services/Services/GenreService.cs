using AutoMapper;
using MediaList.Data.Interfaces;
using MediaList.Data.Models;
using MediaList.Services.Interfaces;
using MediaList.Services.Models;

namespace MediaList.Services.Services
{
    public class GenreService : IGenreService
    {
        private readonly IMapper _mapper;
        private readonly IGenreRepository _GenreRepository;

        public GenreService(IMapper mapper, IGenreRepository GenreRepository)
        {
            _mapper = mapper;
            _GenreRepository = GenreRepository;
        }

        public async Task<List<GenreViewModel>> Get()
        {
            var dbModels = await _GenreRepository.GetAsync();

            return _mapper.Map<List<GenreViewModel>>(dbModels);
        }
            
        public async Task<GenreViewModel> Get(string id)
        {
            var dbModel = await _GenreRepository.GetAsync(id);

            return _mapper.Map<GenreViewModel>(dbModel);
        }

        public async Task<GenreViewModel> Post(Genre newGenre)
        {
            await _GenreRepository.CreateAsync(newGenre);

            return _mapper.Map<GenreViewModel>(newGenre);
        }
        public async Task<GenreViewModel> Update(string id, Genre updatedGenre)
        {
            var Genre = await _GenreRepository.GetAsync(id);

            if (Genre == null) { 
                return _mapper.Map<GenreViewModel>(new Genre());
            }
            updatedGenre.Id = Genre?.Id;

            await _GenreRepository.UpdateAsync(id, updatedGenre);

            return _mapper.Map<GenreViewModel>(updatedGenre);
        }

        public async Task<GenreViewModel> Delete(string id)
        {
            var Genre = await _GenreRepository.GetAsync(id);

            if (Genre is null)
            {
                return _mapper.Map<GenreViewModel>(new Genre());
            }

            await _GenreRepository.RemoveAsync(id);

            return _mapper.Map<GenreViewModel>(new Genre());
        }
    }
}
