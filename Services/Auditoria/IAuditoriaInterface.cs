using WebApiUser.Models;

namespace WebApiUser.Services.Auditoria
{
    public interface IAuditoriaInterface
    {
        Task RegistrarAuditoriaAsync(string acao, string usuarioId, string dadosAlterados);
        Task<List<AuditoriaModel>> BuscarAuditoria();
    }
}
