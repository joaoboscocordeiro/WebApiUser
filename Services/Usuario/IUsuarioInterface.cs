using WebApiUser.Dtos.Login;
using WebApiUser.Dtos.Usuario;
using WebApiUser.Models;

namespace WebApiUser.Services.Usuario
{
    public interface IUsuarioInterface
    {
        Task<ResponseModel<List<UsuarioModel>>> ListarUsuarios();
        Task<ResponseModel<UsuarioModel>> BuscarUsuarioPorId(int id);
        Task<ResponseModel<UsuarioModel>> RemoverUsuario(int id);
        Task<ResponseModel<UsuarioModel>> RegistrarUsuario(UsuarioCriacaoDto criacaoCriacaoDto);
        Task<ResponseModel<UsuarioModel>> EditarUsuario(UsuarioEdicaoDto usuarioEdicaoDto);
        Task<ResponseModel<UsuarioModel>> Login(UsuarioLoginDto usuarioLoginDto);
    }
}
