using BCrypt.Net;
using System.ComponentModel.DataAnnotations;

namespace app_adocao.Models
{
    public class Usuario
    {
        [Key]
        [StringLength(10,ErrorMessage ="Limite de caracteres => 10")]
        public string? Login { get; set; }

        [Required(ErrorMessage = "Obrigatório o preenchimento do Nome!")]
        [StringLength(20,ErrorMessage = "Limite de caracteres => 20")]
        public string? Nome { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Obrigatório o preenchimento do Senha!")]
        public string? Senha { get; set; }

        [Required(ErrorMessage = "Obrigatório o preenchimento da Cidade!")]
        [StringLength(10,ErrorMessage = "Limite de caracteres => 10")]
        public string? Cidade { get; set; }

        [Required(ErrorMessage = "Obrigatório o preenchimento da Estado!")]
        [StringLength(2,MinimumLength =2,ErrorMessage = "Quantidade de caracteres necessário => 2")]
        public string? Estado { get; set; }
    }
}
