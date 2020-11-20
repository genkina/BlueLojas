using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace blueLojas.Models
{
    public class UsuarioModel
    {
        
        [DisplayName("Primeiro Nome")]
            [StringLength(50, ErrorMessage = "O campo Nome permite no máximo 50 caracteres!")]
            public string nome { get; set; }
            [Required]
            public string telefone { get; set; }
            [StringLength(50)]
            [Required(ErrorMessage = "Informe o Email")]
            [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email inválido.")]
            public string email { get; set; }
        
    }
}
