namespace TesteEclipse.Models
{
    public class Projeto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DtCriacao { get; set; }

        public Usuario Usuario { get; set; }
        public ICollection<Tarefa> Tarefas { get; set; }
    }
}
