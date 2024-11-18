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

namespace ProjetoPOOB.Views
{
    public partial class frmCadFornecedorView : Form
    {
        public frmCadFornecedorView()
        {
            InitializeComponent();
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
                " cadastrado com sucesso!", "Sucesso!");
        }
    }
}
