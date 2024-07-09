using AutoMapper;
using TesteEclipse.DTOs;
using TesteEclipse.Models;

namespace TesteEclipse.MappingProfiles
{
    public class TarefaProfile : Profile
    {
        public TarefaProfile() 
        { 
            CreateMap<Tarefa, TarefaDTO>().ReverseMap();
        
        }
    }
}
