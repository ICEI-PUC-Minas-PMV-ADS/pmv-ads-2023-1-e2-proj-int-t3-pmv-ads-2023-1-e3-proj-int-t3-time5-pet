using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace app_web_adocao.Models
{
    [Table("Responsavel")]
    public class Responsavel: Usuario
    {
        [Required(ErrorMessage ="Obrigatório o preenchimento do contato!")]
        public string Contato { get; set; }
    }
}
