using AutoMapper;
using TesteEclipse.DTOs;
using TesteEclipse.Models;

namespace TesteEclipse.MappingProfiles
{
    public class HistoricoProfile : Profile
    {
        public HistoricoProfile() 
        {
            CreateMap<Historico, HistoricoDTO>().ReverseMap();
        }
    }
}
