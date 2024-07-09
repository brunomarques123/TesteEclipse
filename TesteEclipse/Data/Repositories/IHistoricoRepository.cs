using TesteEclipse.Models;

namespace TesteEclipse.Data.Repositories
{
    public interface IHistoricoRepository
    {
        Task<IEnumerable<Historico>> ListarHistoricoPorTarefa(int idTarefa);
        Task<Historico> ObterPorId(int id);
        Task Adicionar(Historico historico);
    }
}
