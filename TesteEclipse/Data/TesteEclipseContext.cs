using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using TesteEclipse.Models;

namespace TesteEclipse.Data
{
    public class TesteEclipseContext : DbContext
    {
        public TesteEclipseContext(DbContextOptions<TesteEclipseContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Projeto> Projetos { get; set; }
        public DbSet<Tarefa> Tarefas { get; set; }
        public DbSet<Historico> Historicos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Projeto>()
                .HasOne(p => p.Usuario)
                .WithMany(u => u.Projetos)
                .HasForeignKey(p => p.IdUsuario);

            modelBuilder.Entity<Tarefa>()
                .HasOne(t => t.Projeto)
                .WithMany(p => p.Tarefas)
                .HasForeignKey(t => t.IdProjeto);

            modelBuilder.Entity<Historico>()
                .HasOne(h => h.Tarefa)
                .WithMany(t => t.Historicos)
                .HasForeignKey(h => h.IdTarefa);

            modelBuilder.Entity<Historico>()
                .HasOne(h => h.Usuario)
                .WithMany(u => u.Historicos)
                .HasForeignKey(h => h.IdUsuario);
        }
    }
}
