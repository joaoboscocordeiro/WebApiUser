using AutoMapper;
using WebApiUser.Dtos.Usuario;
using WebApiUser.Models;

namespace WebApiUser.Profiles
{
    public class ProfileAutoMapper : Profile
    {
        public ProfileAutoMapper()
        {
            CreateMap<UsuarioCriacaoDto, UsuarioModel>().ReverseMap();
        }
    }
}
