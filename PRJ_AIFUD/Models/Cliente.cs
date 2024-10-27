﻿using System;

namespace ProjetoPOOB.Models
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Rg { get; set; }
        public string CPF { get; set; }
        public DateTime DtNascimento { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
    }
}
