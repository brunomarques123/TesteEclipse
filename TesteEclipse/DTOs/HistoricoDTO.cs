namespace TesteEclipse.DTOs
{
    public class HistoricoDTO
    {
        public int Id { get; set; }
        public int IdTarefa { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DtAlteracao { get; set; }
        public string DescricaoOld { get; set; }
        public string DescricaoNew { get; set; }
        public bool ConcluidaOld { get; set; }
        public bool ConcluidaNew { get; set; }
    }
}
