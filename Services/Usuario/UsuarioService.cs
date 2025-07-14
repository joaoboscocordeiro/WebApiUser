using Microsoft.EntityFrameworkCore;
using WebApiUser.Data;
using WebApiUser.Dtos.Usuario;
using WebApiUser.Models;

namespace WebApiUser.Services.Usuario
{
    public class UsuarioService : IUsuarioInterface
    {
        private readonly AppDbContext _context;

        public UsuarioService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<ResponseModel<UsuarioModel>> BuscarUsuarioPorId(int id)
        {
            ResponseModel<UsuarioModel> response = new ResponseModel<UsuarioModel>();

            try
            {
                var usuario = await _context.Usuarios.FindAsync(id);

                if (usuario == null)
                {
                    response.Mensagem = "Usuário não localizado!";
                    return response;
                }

                response.Dados = usuario;
                response.Mensagem = "Usuários localizado!";
                return response;
            }
            catch (Exception ex)
            {
                response.Mensagem = ex.Message;
                response.Status = false;
                return response;
            }
        }

        public async Task<ResponseModel<List<UsuarioModel>>> ListarUsuarios()
        {
            ResponseModel<List<UsuarioModel>> response = new ResponseModel<List<UsuarioModel>>();

            try
            {
                var usuarios = await _context.Usuarios.ToListAsync();

                if (usuarios.Count() == 0)
                {
                    response.Mensagem = "Nenhum usuário cadastrado!";
                    return response;
                }

                response.Dados = usuarios;
                response.Mensagem = "Usuários localizados!";
                return response;
            }
            catch (Exception ex)
            {
                response.Mensagem = ex.Message;
                response.Status = false;
                return response;
            }
        }

        public Task<ResponseModel<UsuarioModel>> RegistrarUsuario(UsuarioCriacaoDto criacaoCriacaoDto)
        {
            throw new NotImplementedException();
        }
    }
}