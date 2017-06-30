using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TesteScription.Dominio.Modelo
{
    public class ClasseId
    {
        [Display(Name = "Código")]
        public int ID { get; set; }
    }
}
