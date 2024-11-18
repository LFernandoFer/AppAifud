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
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadCliente frm = new frmCadCliente();
            frm.ShowDialog();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCadProduto frm = new frmCadProduto();
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
            frmPedidoView frm = new frmPedidoView();
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
            frmConsultarPedidoView frm = new frmConsultarPedidoView();
            frm.ShowDialog();
        }
    }
}
