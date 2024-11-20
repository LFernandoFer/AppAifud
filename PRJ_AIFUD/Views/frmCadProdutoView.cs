using ProjetoPOOB.Controllers;
using ProjetoPOOB.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPOOB
{
    public partial class frmCadProdutoView : Form
    {
        public frmCadProdutoView()
        {
            InitializeComponent();
            btnAtualizar.Visible = false;
        }

        public frmCadProdutoView(Produto produto)
        {
            InitializeComponent();
            btnSalvar.Visible = false;

            txtId.Text = Convert.ToString(produto.IdProduto);
            txtNomeProd.Text = produto.NomeProduto;
            mskPreco.Text = Convert.ToString(produto.PrecoVenda);
            txtDescricao.Text = produto.Descricao;
            mskEstoque.Text = Convert.ToString(produto.EstoqueAtual);
            txtUnMedida.Text = produto.UnMedida;
            
            btnSalvar.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            ProdutosController controler = new ProdutosController();
            Produto produto = new Produto();

            produto.NomeProduto = txtNomeProd.Text;
            produto.Descricao = txtDescricao.Text;
            produto.UnMedida = txtUnMedida.Text;
            produto.PrecoVenda = Math.Round(Convert.ToDecimal(mskPreco.Text), 2);
            produto.EstoqueAtual = Convert.ToInt32(mskEstoque.Text);
            produto.Restaurante = GetIdRestaurante(cmbRestaurante.Text);
            MessageBox.Show("Poduto nº" + controler.Inserir(produto));
            ApagarCampos();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.IdProduto = Convert.ToInt32(txtId.Text);
            produto.NomeProduto = txtNomeProd.Text;
            produto.Descricao = txtDescricao.Text;
            produto.UnMedida = txtUnMedida.Text;
            produto.PrecoVenda = Math.Round(Convert.ToDecimal(mskPreco.Text), 2);
            produto.EstoqueAtual = Convert.ToInt32(mskEstoque.Text);

            ProdutosController controller = new ProdutosController();
            controller.Alterar(produto);

            DialogResult resultado = MessageBox.Show("Produto alterado " +
                "com sucesso! Deseja fechar?", "Sucesso!",
                MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                Close();
            }
        }
        void ApagarCampos()
        {
            txtDescricao.Clear();
            txtNomeProd.Clear();
            txtUnMedida.Clear();
            mskPreco.Clear();
            mskEstoque.Clear();
        }

        private void frmCadProdutoView_Load(object sender, EventArgs e)
        {

            RestauranteController controller = new RestauranteController();


            RestauranteCollection collection = controller.ConsultarPorNome("");

            // Verifica se a coleção de clientes não está vazia
            if (collection.Count > 0)
            {
                // Itera sobre todos os clientes da coleção
                foreach (Restaurante restaurante in collection)
                {
                    cmbRestaurante.Items.Add(restaurante.Nome);
                }
            }
        }
        int GetIdRestaurante(string restaurante)
        { // Criando o controller e buscando o restaurante
            RestauranteController controller = new RestauranteController();
            RestauranteCollection collection = controller.ConsultarPorNome(restaurante);

            if (collection.Count > 0)
            {   
                return collection[0].Id;
            }
            return -1;
        }
    }
}
