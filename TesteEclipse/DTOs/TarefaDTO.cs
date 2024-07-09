using TesteEclipse.Models;

namespace TesteEclipse.DTOs
{
    public class TarefaDTO
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int IdProjeto { get; set; }
        public bool Concluida { get; set; }
        public PrioridadeTarefa Prioridade { get; set; }
        public DateTime DtCriacao { get; set; }
    }

    public class CreateTarefaDTO
    {
        public string Descricao { get; set; }
        public int IdProjeto { get; set; }
        public PrioridadeTarefa Prioridade { get; set; }
    }

    public class UpdateTarefaDTO
    {
        public string Descricao { get; set; }
        public bool Concluida { get; set; }
    }
}
