using Microsoft.EntityFrameworkCore;
using TesteEclipse.Models;

namespace TesteEclipse.Data.Repositories
{
    public class TarefaRepository : ITarefaRepository
    {
        private readonly TesteEclipseContext _context;

        public TarefaRepository(TesteEclipseContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Tarefa>> ListarTarefasPorProjeto(int idProjeto)
        {
            return await _context.Tarefas
                .Where(t => t.IdProjeto == idProjeto)
                .ToListAsync();
        }

        public async Task<Tarefa> ObterPorId(int id)
        {
            return await _context.Tarefas.FindAsync(id);
        }

        public async Task Adicionar(Tarefa tarefa)
        {
            await _context.Tarefas.AddAsync(tarefa);
            await _context.SaveChangesAsync();
        }

        public async Task Atualizar(Tarefa tarefa)
        {
            _context.Tarefas.Update(tarefa);
            await _context.SaveChangesAsync();
        }

        public async Task Remover(Tarefa tarefa)
        {
            _context.Tarefas.Remove(tarefa);
            await _context.SaveChangesAsync();
        }
    }

}
