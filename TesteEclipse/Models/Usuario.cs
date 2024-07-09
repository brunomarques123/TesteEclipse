namespace TesteEclipse.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public ICollection<Projeto> Projetos { get; set; }
        public ICollection<Historico> Historicos { get; set; }
    }
}
