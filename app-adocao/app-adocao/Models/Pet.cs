using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app_adocao.Models
{
    public class Pet
    {
        [Key]
        public int ID { get; set; }

        [StringLength(10, ErrorMessage = "Limite de caracteres => 10")]
        public string? Dono { get; set; }

        [Required]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Obrigatório o preenchimento do Nome!")]
        [StringLength(15, ErrorMessage = "Limite de caracteres => 15")]
        public string? Nome { get; set; }

        [Required]
        public string? Status { get; set; }

        [Required(ErrorMessage = "Obrigatória escolha do Tipo de Pet!")]
        [StringLength(12, ErrorMessage = "Limite de caracteres => 12")]
        public string? Tipo { get; set; }

       // [Required(ErrorMessage = "Obrigatória a descrição mínima do histórico do Pet!")]
        [StringLength(100, ErrorMessage = "Limite de caracteres => 100")]
        public string? Historico { get; set; }

        [StringLength(20, ErrorMessage = "Limite de caracteres => 20")]
        public string? Sexo { get; set; }

        [Required(ErrorMessage = "Obrigatória escolha da cor do Pet!")]
        [StringLength(10, ErrorMessage = "Limite de caracteres => 10")]
        public string? Cor { get; set; }



    }
}
