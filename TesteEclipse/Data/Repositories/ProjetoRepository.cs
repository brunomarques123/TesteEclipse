using Microsoft.EntityFrameworkCore;
using TesteEclipse.Models;

namespace TesteEclipse.Data.Repositories
{
    public class ProjetoRepository : IProjetoRepository
    {
        private readonly TesteEclipseContext _context;

        public ProjetoRepository(TesteEclipseContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Projeto>> ListarProjetosPorUsuario(int idUsuario)
        {
            return await _context.Projetos
                .Where(p => p.IdUsuario == idUsuario)
                .ToListAsync();
        }

        public async Task<Projeto> ObterPorId(int id)
        {
            return await _context.Projetos.FindAsync(id);
        }

        public async Task Adicionar(Projeto projeto)
        {
            await _context.Projetos.AddAsync(projeto);
            await _context.SaveChangesAsync();
        }

        public async Task Atualizar(Projeto projeto)
        {
            _context.Projetos.Update(projeto);
            await _context.SaveChangesAsync();
        }

        public async Task Remover(Projeto projeto)
        {
            _context.Projetos.Remove(projeto);
            await _context.SaveChangesAsync();
        }
    }
}