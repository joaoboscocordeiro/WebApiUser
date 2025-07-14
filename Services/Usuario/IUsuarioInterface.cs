using WebApiUser.Dtos.Usuario;
using WebApiUser.Models;

namespace WebApiUser.Services.Usuario
{
    public interface IUsuarioInterface
    {
        Task<ResponseModel<List<UsuarioModel>>> ListarUsuarios();
        Task<ResponseModel<UsuarioModel>> BuscarUsuarioPorId(int id);
        Task<ResponseModel<UsuarioModel>> RemoverUsuario(int id);
    }
}
