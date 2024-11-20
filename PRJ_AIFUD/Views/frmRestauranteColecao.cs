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
    public partial class frmRestauranteColecao : Form
    {
        public frmRestauranteColecao()
        {
            InitializeComponent();
            Pesquisar();
        }
        #region CarregarTela
        private void frmRestauranteColecao_Load(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void frmRestauranteColecao_Activated(object sender, EventArgs e)
        {
            Pesquisar();
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadRestauranteView frm = new frmCadRestauranteView();
            frm.ShowDialog();
        }
        #endregion
        public void Pesquisar()
        {
            int id = 0;

            RestauranteController controller = new RestauranteController();
            RestauranteCollection collection = new RestauranteCollection();

            dgvRestaurantes.DataSource = null;

            if (int.TryParse(txtPesquisa.Text, out id))
            {
                Restaurante restaurante
                    = controller.ConsultarPorId(id);
                if (restaurante != null)
                    collection.Add(restaurante);
            }
            else
                collection =
                    controller.ConsultarPorNome(txtPesquisa.Text);

            dgvRestaurantes.DataSource = collection;

            dgvRestaurantes.Update(); //Atualizar fonte de dados
            dgvRestaurantes.Refresh(); //Atulizar os dados exibidos
        }
        private Restaurante RecuperarRestaurante()
        {
            if (dgvRestaurantes.SelectedRows.Count == 0)
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
                return dgvRestaurantes.SelectedRows[0].DataBoundItem
                as Restaurante;
            }
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            RestauranteController controller = new RestauranteController();
            Restaurante restauranteSelecionado =
                controller.ConsultarPorId(
                    Convert.ToInt32(dgvRestaurantes.SelectedRows[0].
                    Cells["Id"].Value));

            restauranteSelecionado.Id = Convert.ToInt32(dgvRestaurantes.SelectedRows[0].
                    Cells["Id"].Value);

            frmCadRestauranteView frm = new frmCadRestauranteView(restauranteSelecionado);
            frm.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Restaurante restauranteSelecionado = RecuperarRestaurante();

            if (restauranteSelecionado != null)
            {
                if (MessageBox.Show(
                    "Deseja realmente excluir o registro?",
                    "Confirmação", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {


                    RestauranteController controller = new RestauranteController();

                    if (controller.Excluir(restauranteSelecionado.Id) > 0)
                    {
                        MessageBox.Show("Registro excluído com sucesso.",
                            "Informação", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        Pesquisar();
                    }
                    else
                        MessageBox.Show("Não foi possível excluir o registro.",
                            "Atenção", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                }
            }
        }
    }
}
