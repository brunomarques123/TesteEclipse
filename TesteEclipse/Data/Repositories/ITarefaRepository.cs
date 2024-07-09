using TesteEclipse.Models;

namespace TesteEclipse.Data.Repositories
{
    public interface ITarefaRepository
    {
        Task<IEnumerable<Tarefa>> ListarTarefasPorProjeto(int idProjeto);
        Task<Tarefa> ObterPorId(int id);
        Task Adicionar(Tarefa tarefa);
        Task Atualizar(Tarefa tarefa);
        Task Remover(Tarefa tarefa);
    }
}
