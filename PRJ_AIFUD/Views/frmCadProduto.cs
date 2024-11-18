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

namespace ProjetoPOOB
{
    public partial class frmCadProduto : Form
    {
        public frmCadProduto()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ProdutosController controler = new ProdutosController();
            Produto produto = new Produto();

            produto.NomeProduto = txtNomeProd.Text;
            produto.Descricao = txtDescricao.Text;
            produto.UnMedida = txtUnMedida.Text;
            produto.PrecoVenda = Convert.ToDecimal(mskPreco.Text);
            produto.EstoqueAtual = Convert.ToInt32(mskEstoque.Text);

            MessageBox.Show("Poduto nº" + controler.Inserir(produto));
            
            txtDescricao.Clear();
            txtNomeProd.Clear();
            txtUnMedida.Clear();
            mskPreco.Clear();
            mskEstoque.Clear();
        }
    }
}
