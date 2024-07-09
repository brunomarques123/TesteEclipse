namespace TesteEclipse.DTOs
{
    public class ProjetoDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DtCriacao { get; set; }
    }

    public class CreateProjetoDTO
    {
        public string Nome { get; set; }
        public int IdUsuario { get; set; }
    }
}
