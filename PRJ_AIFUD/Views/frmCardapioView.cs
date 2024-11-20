using ProjetoPOOB.Models;
using System;
using ProjetoPOOB.Controllers;
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
    public partial class frmCardapioView : Form
    {
        public frmCardapioView()
        {
            InitializeComponent();
        }

        private void frmPedidoView_Load(object sender, EventArgs e)
        {

            RestauranteController controller = new RestauranteController();
            RestauranteCollection collection = controller.ConsultarPorNome("");

            if (collection.Count > 0)
            {
                // Itera sobre todos os clientes da coleção
                foreach (Restaurante restaurante in collection)
                {
                    cmbRestaurante.Items.Add(restaurante.Nome);
                }
                Pesquisar();
            }
            else
            {
                MessageBox.Show("Nenhum restaurante encontrado.");
            }
        }
        private void Pesquisar()
        {
            int id = 0;

            ProdutosController produtoController = new ProdutosController();
            ProdutoCollection produtoCollection = new ProdutoCollection(); // Corrigindo a digitação
            dgvProdutos.DataSource = null;

            RestauranteController controller = new RestauranteController();
            RestauranteCollection collection = controller.ConsultarPorNome(cmbRestaurante.Text);

            int restaurante = collection[0].Id;
            if (restaurante >= 0)  
            {
                // Aqui você deve passar o ID do restaurante, não a variável 'id' (que está com valor 0)
                ProdutoCollection produtos = produtoController.ConsultarPorRestaurante(restaurante);

                if (produtos != null && produtos.Count > 0)
                {
                    // Adiciona os produtos retornados à coleção
                    produtoCollection.AddRange(produtos); // Usando AddRange para adicionar toda a coleção de uma vez
                }
            }
            else
            {
                // Caso o restaurante não tenha sido encontrado, consulta por nome
                produtoCollection = produtoController.ConsultarPorNome(cmbRestaurante.Text.Trim());
            }

            dgvProdutos.DataSource = produtoCollection;
            dgvProdutos.Update();
            dgvProdutos.Refresh();
        }
    }
}

