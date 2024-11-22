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
            btnAlterar.Visible = false;
        }
        
        public frmCadFuncionarioView(Funcionarios funcionario)
        {
            InitializeComponent();
            btnSalvar.Visible = false;

            txtId.Text = Convert.ToString(funcionario.Id);
            txtNome.Text = funcionario.Nome;
            mskCPF.Text = funcionario.CPF;
            txtEndereco.Text = funcionario.Endereco;
            dtpNascimento.Text = Convert.ToString(funcionario.DtNascimento);
            mskTelefone.Text = funcionario.Telefone;
            txtTurno.Text = funcionario.Turno;
            txtFuncao.Text = funcionario.Funcao;
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Funcionarios funcionario = new Funcionarios();

            funcionario.Id = Convert.ToInt32(txtId.Text);
            funcionario.Nome = txtNome.Text;
            funcionario.CPF = mskCPF.Text;
            funcionario.Endereco = txtEndereco.Text;
            funcionario.DtNascimento = Convert.ToDateTime(dtpNascimento.Text);
            funcionario.Telefone = mskTelefone.Text;
            funcionario.Turno = txtTurno.Text;
            funcionario.Funcao = txtFuncao.Text;

            FuncionariosController controler = new FuncionariosController();
            controler.Alterar(funcionario);
            DialogResult resultado =
                MessageBox.Show("Funcionário "
               + " alterado com sucesso! Deseja fechar?", "Sucesso!",
               MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
