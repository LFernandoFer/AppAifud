using ProjetoPOOB.Models;
using ProjetoPOOB.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPOOB
{
    public partial class frmCadCliente : Form
    {
        public frmCadCliente()
        {
            InitializeComponent();
        }
        ClienteController controler = new ClienteController();

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = txtNome.Text;
            cliente.Telefone = mskTelefone.Text.ToString();
            cliente.CPF = ConverterCPF(mskCPF.Text);
            cliente.Endereco = txtEndereco.Text;
            cliente.DtNascimento = Convert.ToDateTime(txtDtNascimento.Text);


           
            controler.Inserir(cliente);

        }

        public string ConverterCPF(string CPF)
        {
            string cpfFormatado = "";
            int i = 0;
                while(CPF.Length > i)
                {
                    if (CPF[i] != '.' && CPF[i] != '-')
                    {
                        cpfFormatado += Convert.ToChar(CPF[i]);
                        i++;
                    }
                    else i++;
                }

         return cpfFormatado;
        }
    }
}
