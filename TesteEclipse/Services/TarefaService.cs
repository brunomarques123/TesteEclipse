using AutoMapper;
using TesteEclipse.Data.Repositories;
using TesteEclipse.DTOs;
using TesteEclipse.Models;

namespace TesteEclipse.Services
{
    public class TarefaService : ITarefaService
    {
        private readonly ITarefaRepository _tarefaRepository;
        private readonly IMapper _mapper;

        public TarefaService(ITarefaRepository tarefaRepository, IMapper mapper)
        {
            _tarefaRepository = tarefaRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TarefaDTO>> ListarTarefasPorProjeto(int idProjeto)
        {
            var tarefas = await _tarefaRepository.ListarTarefasPorProjeto(idProjeto);
            return _mapper.Map<IEnumerable<TarefaDTO>>(tarefas);
        }

        public async Task<TarefaDTO> ObterTarefaPorId(int id)
        {
            var tarefa = await _tarefaRepository.ObterPorId(id);
            return _mapper.Map<TarefaDTO>(tarefa);
        }

        public async Task AdicionarTarefa(TarefaDTO tarefaDTO)
        {
            var tarefa = _mapper.Map<Tarefa>(tarefaDTO);
            await _tarefaRepository.Adicionar(tarefa);
        }

        public async Task AtualizarTarefa(TarefaDTO tarefaDTO)
        {
            var tarefa = _mapper.Map<Tarefa>(tarefaDTO);
            await _tarefaRepository.Atualizar(tarefa);
        }

        public async Task RemoverTarefa(int id)
        {
            var tarefa = await _tarefaRepository.ObterPorId(id);
            if (tarefa != null)
            {
                await _tarefaRepository.Remover(tarefa);
            }
        }
    }
}
