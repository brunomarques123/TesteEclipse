using AutoMapper;
using TesteEclipse.Data.Repositories;
using TesteEclipse.DTOs;
using TesteEclipse.Models;

namespace TesteEclipse.Services
{
    public class HistoricoService : IHistoricoService
    {
        private readonly IHistoricoRepository _historicoRepository;
        private readonly IMapper _mapper;

        public HistoricoService(IHistoricoRepository historicoRepository, IMapper mapper)
        {
            _historicoRepository = historicoRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<HistoricoDTO>> ListarHistoricoPorTarefa(int idTarefa)
        {
            var historicos = await _historicoRepository.ListarHistoricoPorTarefa(idTarefa);
            return _mapper.Map<IEnumerable<HistoricoDTO>>(historicos);
        }

        public async Task AdicionarHistorico(HistoricoDTO historicoDTO)
        {
            var historico = _mapper.Map<Historico>(historicoDTO);
            await _historicoRepository.Adicionar(historico);
        }
    }
}