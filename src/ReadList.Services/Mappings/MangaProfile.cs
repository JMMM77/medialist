using AutoMapper;
using ReadList.Data.Models;
using ReadList.Services.Models;

namespace ReadList.Services.Mappings
{
    public class MangaProfile : Profile
    {
        public MangaProfile()
        {
            CreateMap<Manga, MangaViewModel>(MemberList.Destination);
        }
    }
}
