using TesteEclipse.Models;

namespace TesteEclipse.Data.Repositories
{
    public interface IProjetoRepository
    {
        Task<IEnumerable<Projeto>> ListarProjetosPorUsuario(int idUsuario);
        Task<Projeto> ObterPorId(int id);
        Task Adicionar(Projeto projeto);
        Task Atualizar(Projeto projeto);
        Task Remover(Projeto projeto);
    }
}
