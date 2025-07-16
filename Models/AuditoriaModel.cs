namespace WebApiUser.Models
{
    public class AuditoriaModel
    {
        public int Id { get; set; }
        public string Acao { get; set; } = string.Empty;
        public DateTime Data { get; set; } = DateTime.Now;
        public string UsuarioId { get; set; } = string.Empty;
        public string DadosAlterados { get; set; } = string.Empty;
    }
}
