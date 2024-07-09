using TesteEclipse.DTOs;

namespace TesteEclipse.Services
{
    public interface IProjetoService
    {
        Task<IEnumerable<ProjetoDTO>> ListarProjetosPorUsuario(int idUsuario);
        Task<ProjetoDTO> ObterProjetoPorId(int id);
        Task AdicionarProjeto(ProjetoDTO projetoDTO);
        Task AtualizarProjeto(ProjetoDTO projetoDTO);
        Task RemoverProjeto(int id);
    }
}
