using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app_adocao.Models
{
    [Table("Requerente")]
    public class Requerente: Usuario
    {
        [Required(ErrorMessage ="Obrigatória Escolha do Tipo de Pet!")]
        [StringLength(12,ErrorMessage = "Limite de caracteres => 12")]
        public string? Tipo { get; set; }
        
        [DisplayName("Raça")]
        [StringLength(20, ErrorMessage = "Limite de caracteres => 20")]
        public string? Raca { get; set; }

        public ICollection<Adocao>? Adocoes { get; set; }
    }
}
