using ProjetoPOOB.Controllers;
using ProjetoPOOB.Models;
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
    public partial class frmCadRestauranteView : Form
    {
        public frmCadRestauranteView()
        {
            InitializeComponent();

            btnAlterar.Visible = false;
        }
        public frmCadRestauranteView(Restaurante restaurante)
        {
            InitializeComponent();
            txtId.Text = Convert.ToString(restaurante.Id);
            txtFornecedor.Text = restaurante.Nome;
            mskCNPJ.Text = restaurante.CNPJ;
            txtEndereco.Text = restaurante.Endereco;
            txtTema.Text = restaurante.Tema;
            mskTelefone.Text = restaurante.Telefone; 

            btnSalvar.Visible = false;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Restaurante restaurante = new Restaurante();
            restaurante.Nome = txtFornecedor.Text;
            restaurante.CNPJ = mskCNPJ.Text;
            restaurante.Telefone = mskTelefone.Text;
            restaurante.Tema = txtTema.Text;
            restaurante.Endereco = txtEndereco.Text;

            RestauranteController controller = new RestauranteController();
            MessageBox.Show("Restaurante nº " +
            controller.Inserir(restaurante) +
            " cadastrado com sucesso!", "Sucesso!");

            txtFornecedor.Clear();
            mskCNPJ.Clear();
            mskTelefone.Clear();
            txtTema.Clear();
            txtEndereco.Clear();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Restaurante restaurante = new Restaurante();

            restaurante.Id = Convert.ToInt32(txtId.Text);
            restaurante.Nome = txtFornecedor.Text;
            restaurante.CNPJ = mskCNPJ.Text;
            restaurante.Telefone = mskTelefone.Text;
            restaurante.Tema = txtTema.Text;
            restaurante.Endereco = txtEndereco.Text;

            RestauranteController controller = new RestauranteController();
            controller.Alterar(restaurante);
            DialogResult resultado =
                MessageBox.Show("Restaurante alterado com sucesso!" +
                " Deseja fechar?", "Sucesso!", MessageBoxButtons.YesNo);
            if(resultado == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
