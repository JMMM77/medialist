using AutoMapper;
using MediaList.Data.Infrastructure;
using MediaList.Data.Interfaces;
using MediaList.Data.Models;
using MediaList.Services.Interfaces;
using MediaList.Services.Models;

namespace MediaList.Services.Services
{
    public class MediaService : IMediaService
    {
        private readonly IGenreRepository _genreRepository;
        private readonly IMapper _mapper;
        private readonly IMediaTypeRepository _mediaTypeRepository;

        public MediaService(IGenreRepository genreRepository, IMapper mapper, IMediaTypeRepository mediaTypeRepository)
        {
            _genreRepository = genreRepository;
            _mapper = mapper;
            _mediaTypeRepository = mediaTypeRepository;
        }

        public async Task<IEnumerable<MediaTypeViewModel>> GetAllMediaTypes()
        {
            var dbModels = await _mediaTypeRepository.GetAsync();

            return _mapper.Map<IEnumerable<MediaTypeViewModel>>(dbModels);
        }

        public async Task<IEnumerable<GenreViewModel>> GetAllGenres()
        {
            var dbModels = await _genreRepository.GetAsync();

            return _mapper.Map<IEnumerable<GenreViewModel>>(dbModels);
        }
    }
}
