using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPOOB.Models
{
    public class Funcionarios : Cliente
    {
        public string Funcao { get; set; }
        public string Turno { get; set; }
    }
}
