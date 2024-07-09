using TesteEclipse.DTOs;

namespace TesteEclipse.Services
{
    public interface IHistoricoService
    {
        Task<IEnumerable<HistoricoDTO>> ListarHistoricoPorTarefa(int idTarefa);
        Task AdicionarHistorico(HistoricoDTO historicoDTO);
    }
}
