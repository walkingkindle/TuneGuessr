using AutoMapper;
using TuneGuessr.Application.ViewModels;
using TuneGuessr.Domain.Entities;

namespace TuneGuessr.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Player, PlayerVm>().ReverseMap();
        }
    }
}
