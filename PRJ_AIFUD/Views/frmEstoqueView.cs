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
    public partial class frmEstoqueView : Form
    {
        public frmEstoqueView()
        {
            InitializeComponent();
            Pesquisar();
        }
        #region CarregarTela
        private void frmEstoqueView_Load(object sender, EventArgs e)
        {
            Pesquisar();
        }
        private void frmEstoqueView_Activated(object sender, EventArgs e)
        {
            Pesquisar();
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }
        #endregion
        public void Pesquisar()
        {
            int id = 0;

            ProdutosController controller = new ProdutosController();

            //O DataGrid somente exibe listas, portanto,
            //Não é possivel passar apenas um objeto do tipo
            //"Cliente" para ele. É nescessario que seum "ClineteCollection"
            //Lembrando que o "ClienteCollection" herda de "TList<>"
            ProdutoCollection collection = new ProdutoCollection();

            //"DataSource" é a propriedade do DataGrid que
            //que faz uma referencia o objeto que possui os dados
            //que serão exibidos. No caso ele´irá possuir, uma referencia
            //para o "ClienteCollection" 
            //Ou seja o "ClienteColletion" será a fonte de dados 
            //para o DataSource do DataGrid
            //Sempre é preciso limpar a grade ao realizar uma nova pesquisa

            dgvProdutos.DataSource = null;

            //Validar se o valor informado para pesquisa é do tipo Int
            if (int.TryParse(txtPesquisa.Text, out id))
            {
                //Uma consulta por ID pode retornar no maximo 1 registro
                //ou nenhum registro, sendo nescessario validar se o registro
                //está nullo, se o registro não for nullo o adiconamos
                //a "ClienteCollection"
                Produto produto = controller.ConsultarPorId(id);
                if (produto != null)
                    collection.Add(produto);
            }
            else
                collection =
                    controller.ConsultarPorNome(txtPesquisa.Text);

            //Após popular a "clienteColletion" eu atribuo ao DataSource
            //da grade
            dgvProdutos.DataSource = collection;

            //Executemos os comando abaixo para atualizar a DataGrid
            dgvProdutos.Update(); //Atualizar fonte de dados
            dgvProdutos.Refresh(); //Atulizar os dados exibidos
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            ProdutosController controller = new ProdutosController();
            Produto ProdutoSelecionado =
                controller.ConsultarPorId(
                    Convert.ToInt32(dgvProdutos.SelectedRows[0].
                    Cells["Id"].Value));

            frmCadProdutoView frm = new frmCadProdutoView(ProdutoSelecionado);
            frm.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Produto produtoSelecionado = RecuperarProduto();

            if (produtoSelecionado != null)
            {
                if (MessageBox.Show(
                    "Deseja realmente excluir o prododuto?",
                    "Confirmação", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {


                    ProdutosController controller = new ProdutosController();

                    if (controller.Excluir(produtoSelecionado.IdProduto) > 0)
                    {
                        MessageBox.Show("Registro excluído com sucesso.",
                            "Informação", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        Pesquisar();
                    }
                    else
                        MessageBox.Show("Não foi possível excluir o produto.",
                            "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                }
            }
        }

        private Produto RecuperarProduto()
        {
            if (dgvProdutos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum registro selecionado.",
                    "Informação", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return null;
            }
            else
            {
                //Este método recupera o objeto da linha 
                //selecionada na Grade
                return dgvProdutos.SelectedRows[0].DataBoundItem
                as Produto;
            }
        }
    }
}
