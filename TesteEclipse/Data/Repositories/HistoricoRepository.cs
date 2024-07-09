using Microsoft.EntityFrameworkCore;
using TesteEclipse.Models;

namespace TesteEclipse.Data.Repositories
{
    public class HistoricoRepository : IHistoricoRepository
    {
        private readonly TesteEclipseContext _context;

        public HistoricoRepository(TesteEclipseContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Historico>> ListarHistoricoPorTarefa(int idTarefa)
        {
            return await _context.Historicos
                .Where(h => h.IdTarefa == idTarefa)
                .ToListAsync();
        }

        public async Task<Historico> ObterPorId(int id)
        {
            return await _context.Historicos.FindAsync(id);
        }

        public async Task Adicionar(Historico historico)
        {
            await _context.Historicos.AddAsync(historico);
            await _context.SaveChangesAsync();
        }
    }
}
