using System.ComponentModel.DataAnnotations;

namespace WebApiUser.Dtos.Usuario
{
    public class UsuarioCriacaoDto
    {
        [Required(ErrorMessage = "Digite o usuário")]
        public string Usuario { get; set; } = string.Empty;
        [Required(ErrorMessage = "Digite o nome")]
        public string Nome { get; set; } = string.Empty;
        [Required(ErrorMessage = "Digite o sobrenome")]
        public string Sobrenome { get; set; } = string.Empty;
        [Required(ErrorMessage = "Digite o e-mail")]
        public string Email { get; set; } = string.Empty;
        [Required(ErrorMessage = "Digite a senha")]
        public string Senha { get; set; } = string.Empty;
        [Required(ErrorMessage = "Confirme a senha"), Compare("Senha", ErrorMessage = "As senhas não são iguais!")]
        public string ConfirmaSenha { get; set; } = string.Empty;
    }
}
