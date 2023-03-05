using AutoMapper;
using MediaList.Data.Interfaces;
using MediaList.Data.Models;
using MediaList.Services.Interfaces;
using MediaList.Services.Models;

namespace MediaList.Services.Services
{
    public class MediaTypeService : IMediaTypeService
    {
        private readonly IMapper _mapper;
        private readonly IMediaTypeRepository _MediaTypeRepository;

        public MediaTypeService(IMapper mapper, IMediaTypeRepository MediaTypeRepository)
        {
            _mapper = mapper;
            _MediaTypeRepository = MediaTypeRepository;
        }

        public async Task<List<MediaTypeViewModel>> Get()
        {
            var dbModels = await _MediaTypeRepository.GetAsync();

            return _mapper.Map<List<MediaTypeViewModel>>(dbModels);
        }
            
        public async Task<MediaTypeViewModel> Get(string id)
        {
            var dbModel = await _MediaTypeRepository.GetAsync(id);

            return _mapper.Map<MediaTypeViewModel>(dbModel);
        }

        public async Task<MediaTypeViewModel> Post(MediaType newMediaType)
        {
            await _MediaTypeRepository.CreateAsync(newMediaType);

            return _mapper.Map<MediaTypeViewModel>(newMediaType);
        }
        public async Task<MediaTypeViewModel> Update(string id, MediaType updatedMediaType)
        {
            var MediaType = await _MediaTypeRepository.GetAsync(id);

            if (MediaType == null) { 
                return _mapper.Map<MediaTypeViewModel>(new MediaType());
            }
            updatedMediaType.Id = MediaType?.Id;

            await _MediaTypeRepository.UpdateAsync(id, updatedMediaType);

            return _mapper.Map<MediaTypeViewModel>(updatedMediaType);
        }

        public async Task<MediaTypeViewModel> Delete(string id)
        {
            var MediaType = await _MediaTypeRepository.GetAsync(id);

            if (MediaType is null)
            {
                return _mapper.Map<MediaTypeViewModel>(new MediaType());
            }

            await _MediaTypeRepository.RemoveAsync(id);

            return _mapper.Map<MediaTypeViewModel>(new MediaType());
        }
    }
}
