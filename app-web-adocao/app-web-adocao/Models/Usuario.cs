using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace app_web_adocao.Models
{
    public abstract class Usuario
    {
        [Key]
        public string Login { get; set; }

        [Required(ErrorMessage = "Obrigatório o preenchimento do Nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório o preenchimento do Senha!")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Obrigatório o preenchimento da Cidade!")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Obrigatório o preenchimento da Estado!")]
        public string Estado { get; set; }
    }
}
