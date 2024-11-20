using System;
using ProjetoPOOB.Views;
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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            AtualizaDataHora();
        }

        public void AtualizaDataHora()
        {
            timer1.Start();
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblData.Text = DateTime.Now.ToLongDateString();
        }

           private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadClienteView frm = new frmCadClienteView();
            frm.ShowDialog();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCadProdutoView frm = new frmCadProdutoView();
            frm.ShowDialog();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClienteColecao frm = new frmClienteColecao();
            frm.ShowDialog();
        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmCadFuncionarioView frm = new frmCadFuncionarioView();
            frm.ShowDialog();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmFuncionarioColecao frm = new frmFuncionarioColecao();
            frm.ShowDialog();
        }

        private void fazerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadRestauranteView frm = new frmCadRestauranteView();
            frm.ShowDialog();
        }

        private void cadastrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmCadFornecedorView frm = new frmCadFornecedorView();
            frm.ShowDialog();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstoqueView frm = new frmEstoqueView();
            frm.ShowDialog();
        }

        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmFornecedorColecao frm = new frmFornecedorColecao();
            frm.ShowDialog();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRestauranteColecao frm = new frmRestauranteColecao();
            frm.ShowDialog();
        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            AtualizaDataHora();
        }

        private void consultarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCardapioView frm = new frmCardapioView();
            frm.ShowDialog();
        }
    }
}
