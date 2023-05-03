using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace app_adocao.Models
{
    public enum StatusAdocao
    {
        Negociação,
        Finalizada,
        Cancelada
    }
    [Table("Adocao")]
    public class Adocao
    {
        [Key]
        public int AdocaoId { get; set; }

        [Required(ErrorMessage = "Obrigatória Escolha da data de Adoção!")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage ="Status obrigatório para o Processo de Adoção!")]
        public StatusAdocao Status { get; set; }

        
        [StringLength(10, ErrorMessage = "Limite de caracteres => 10")]
        public string? Adotante { get; set; }

        [ForeignKey("Adotante")]
        public Requerente? Requerente { get; set; }

        
        public int? IdPet { get; set; }

        [ForeignKey("IdPet")]
        public Pet? Pet { get; set; }
    }
}
