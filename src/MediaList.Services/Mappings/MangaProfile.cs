using AutoMapper;
using MediaList.Data.Models;
using MediaList.Services.Models;

namespace MediaList.Services.Mappings
{
    public class MangaProfile : Profile
    {
        public MangaProfile()
        {
            CreateMap<Manga, MangaViewModel>(MemberList.Destination).ReverseMap();
        }
    }
}
