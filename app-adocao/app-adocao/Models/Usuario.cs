using System.ComponentModel.DataAnnotations;

namespace app_adocao.Models
{
    public abstract class Usuario
    {
        [Key]
        [StringLength(10,ErrorMessage ="Limite de caracteres => 10")]
        public string? Login { get; set; }

        [Required(ErrorMessage = "Obrigatório o preenchimento do Nome!")]
        [StringLength(20,ErrorMessage = "Limite de caracteres => 20")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório o preenchimento do Senha!")]
        [StringLength(6,MinimumLength =6,ErrorMessage = "Quantidade de caracteres necessário => 6")]
        public string? Senha { get; set; }

        [Required(ErrorMessage = "Obrigatório o preenchimento da Cidade!")]
        [StringLength(10,ErrorMessage = "Limite de caracteres => 10")]
        public string? Cidade { get; set; }

        [Required(ErrorMessage = "Obrigatório o preenchimento da Estado!")]
        [StringLength(2,MinimumLength =2,ErrorMessage = "Quantidade de caracteres necessário => 2")]
        public string? Estado { get; set; }
    }
}
