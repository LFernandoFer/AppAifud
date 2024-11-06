﻿using ProjetoPOOB.Controllers;
using ProjetoPOOB.Models;
using System;
using System.Windows.Forms;

namespace ProjetoPOOB
{
    public partial class frmCadCliente : Form
    {
        public frmCadCliente()
        {
            InitializeComponent();
        }

        public frmCadCliente(Cliente cliente)
        {
            InitializeComponent();

            txtNome.Text = cliente.Nome;
            txtEndereco.Text = cliente.Endereco;
            mskCPF.Text = cliente.CPF;
            dtpNascimento.Value = cliente.DtNascimento;
            mskTelefone.Text = cliente.Telefone;

        }
        ClienteController controler = new ClienteController();

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = txtNome.Text;
            cliente.Telefone = mskTelefone.Text.ToString();
            cliente.CPF = mskCPF.Text;
            cliente.Endereco = txtEndereco.Text;
            cliente.DtNascimento = Convert.ToDateTime(dtpNascimento.Text);

            MessageBox.Show("Cliente nº " + controler.Inserir(cliente)
                + " cadastrado com sucesso");

        }

    }
}
