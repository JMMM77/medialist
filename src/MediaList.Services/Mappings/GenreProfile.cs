using AutoMapper;
using MediaList.Data.Models;
using MediaList.Services.Models;

namespace MediaList.Services.Mappings
{
    public class GenreProfile : Profile
    {
        public GenreProfile()
        {
            CreateMap<Genre, GenreViewModel>(MemberList.Destination);
        }
    }
}
