using TesteEclipse.DTOs;

namespace TesteEclipse.Services
{
    public interface ITarefaService
    {
        Task<IEnumerable<TarefaDTO>> ListarTarefasPorProjeto(int idProjeto);
        Task<TarefaDTO> ObterTarefaPorId(int id);
        Task AdicionarTarefa(TarefaDTO tarefaDTO);
        Task AtualizarTarefa(TarefaDTO tarefaDTO);
        Task RemoverTarefa(int id);
    }
}
