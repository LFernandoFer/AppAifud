using ProjetoPOOB.Controllers;
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
using System.Security.Cryptography.X509Certificates;

namespace ProjetoPOOB.Views
{
    public partial class frmCadFornecedorView : Form
    {
        public frmCadFornecedorView()
        {
            InitializeComponent();

            btnAlterar.Visible = false;
        }

        public frmCadFornecedorView(Fornecedor fornecedor)
        {
            InitializeComponent();

            mskCNPJ.Text = fornecedor.CNPJ;
            txtFornecedor.Text = fornecedor.Nome;
            txtRamo.Text = fornecedor.Ramo;
            txtEndereco.Text = fornecedor.Endereco;
            mskTelefone.Text = fornecedor.Telefone;

            txtId.Text = Convert.ToString(fornecedor.Id);
            btnSalvar.Visible = false;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor();

            fornecedor.Nome = txtFornecedor.Text;
            fornecedor.CNPJ = mskCNPJ.Text;
            fornecedor.Telefone = mskTelefone.Text;
            fornecedor.Ramo = txtRamo.Text;
            fornecedor.Endereco = txtEndereco.Text;

            FornecedorController controller = new FornecedorController();

            MessageBox.Show("Fornecedor nº " + controller.Inserir(fornecedor)+
                " cadastrado com sucesso! Deseja fechar?", "Sucesso!");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            
            Fornecedor fornecedor = new Fornecedor();

            fornecedor.Id = Convert.ToInt32(txtId.Text);
            fornecedor.Nome = txtFornecedor.Text;
            fornecedor.CNPJ = mskCNPJ.Text;
            fornecedor.Telefone = mskTelefone.Text;
            fornecedor.Ramo = txtRamo.Text;
            fornecedor.Endereco = txtEndereco.Text;

            FornecedorController controller = new FornecedorController();

            controller.Alterar(fornecedor);
            DialogResult resultado
                =MessageBox.Show("Fornecedor alterado com sucesso!"
                , "Sucesso!",MessageBoxButtons.YesNo);
            if(resultado == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
