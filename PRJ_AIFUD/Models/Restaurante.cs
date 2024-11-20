﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPOOB.Models
{
    public class Restaurante
    {
        public int Id { get; set; }
        public string CNPJ { get; set; }
        public string Nome { get; set; }
        public string Tema { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
    }
}
