using AutoMapper;
using TesteEclipse.DTOs;
using TesteEclipse.Models;

namespace TesteEclipse.MappingProfiles
{
    public class ProjetoProfile : Profile
    {
        public ProjetoProfile()
        {
            CreateMap<Projeto, ProjetoDTO>().ReverseMap();
        }
    }
}
