using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoPOOB.Controllers;
using ProjetoPOOB.Models;
namespace ProjetoPOOB.Views
{
    public partial class frmCadFuncionarioView : Form
    {
        public frmCadFuncionarioView()
        {
            InitializeComponent();
        }
     
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Funcionarios funcionario = new Funcionarios();

            funcionario.Nome = txtNome.Text;
            funcionario.CPF = mskCPF.Text;
            funcionario.Endereco = txtEndereco.Text;
            funcionario.DtNascimento = Convert.ToDateTime(dtpNascimento.Text);
            funcionario.Telefone = mskTelefone.Text;
            funcionario.Turno = txtTurno.Text;
            funcionario.Funcao = txtFuncao.Text;

            FuncionariosController controler = new FuncionariosController();
          
            MessageBox.Show("Funcionário nº " + controler.Inserir(funcionario)
                + " cadastrado com sucesso");
        }
    }
}
