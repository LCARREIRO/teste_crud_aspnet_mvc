using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TesteScription.Dominio.Modelo
{
    public class ContatoModelo : ClasseId
    {
        [Required(ErrorMessage = "O Nome é obrigatório")]
        [Display(Name = "Nome :")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O Telefone é obrigatório")]
        [Display(Name = "Telefone :")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "O E-mail é obrigatório")]        
        [Display(Name = "E-mail :")]
        public string Email { get; set; }
    }
}
