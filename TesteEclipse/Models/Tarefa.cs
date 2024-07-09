namespace TesteEclipse.Models
{
    public enum PrioridadeTarefa
    {
        Baixa,
        Media,
        Alta
    }

    public class Tarefa
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int IdProjeto { get; set; }
        public bool Concluida { get; set; } = false;
        public PrioridadeTarefa Prioridade { get; set; }
        public DateTime DtCriacao { get; set; }

        public Projeto Projeto { get; set; }
        public ICollection<Historico> Historicos { get; set; }
    }
}

