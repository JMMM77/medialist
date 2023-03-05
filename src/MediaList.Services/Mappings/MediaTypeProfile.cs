using AutoMapper;
using MediaList.Data.Models;
using MediaList.Services.Models;

namespace MediaList.Services.Mappings
{
    public class MediaTypeProfile : Profile
    {
        public MediaTypeProfile()
        {
            CreateMap<MediaType, MediaTypeViewModel>(MemberList.Destination);
        }
    }
}
