using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TesteScription.Dominio.Modelo
{
    public class UsuarioModelo: ClasseId
    {
        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Usuário")]
        public string Login { get; set; }


        [Required(ErrorMessage = "Campo obrigatório")]
        public string Senha { get; set; }
    }
}
