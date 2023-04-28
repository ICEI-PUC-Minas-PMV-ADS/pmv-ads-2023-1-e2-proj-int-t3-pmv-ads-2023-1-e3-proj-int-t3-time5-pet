using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app_adocao.Models
{
    [Table("Responsavel")]
    public class Responsavel: Usuario
    {
        [Required(ErrorMessage = "Obrigatório o preenchimento do contato!")]
        [StringLength(11,MinimumLength =11,ErrorMessage ="Quantidade de caracteres necessário => 11")]
        public string? Contato { get; set; }
    }
}
