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
    public partial class frmClienteColecao : Form
    {

        public Cliente clienteSelecao;
        public frmClienteColecao()
        {
            InitializeComponent();
            
            dgvClientes.AutoGenerateColumns = false;
         }

        private void Pesquisar()
        {
            int id = 0;

            ClienteController clienteController = new ClienteController();

            //O DataGrid somente exibe listas, portanto,
            //Não é possivel passar apenas um objeto do tipo
            //"Cliente" para ele. É nescessario que seum "ClineteCollection"
            //Lembrando que o "ClienteCollection" herda de "TList<>"
            ClienteCollection clienteCollection = new ClienteCollection();

            //"DataSource" é a propriedade do DataGrid que
            //que faz uma referencia o objeto que possui os dados
            //que serão exibidos. No caso ele´irá possuir, uma referencia
            //para o "ClienteCollection" 
            //Ou seja o "ClienteColletion" será a fonte de dados 
            //para o DataSource do DataGrid
            //Sempre é preciso limpar a grade ao realizar uma nova pesquisa

            dgvClientes.DataSource = null;

            //Validar se o valor informado para pesquisa é do tipo Int
            if (int.TryParse(txtPesquisa.Text, out id))
            {
                //Uma consulta por ID pode retornar no maximo 1 registro
                //ou nenhum registro, sendo nescessario validar se o registro
                //está nullo, se o registro não for nullo o adiconamos
                //a "ClienteCollection"
                Cliente cliente = clienteController.ConsultarPorId(id);
                if (cliente != null)
                    clienteCollection.Add(cliente);
            }
            else
                clienteCollection =
                    clienteController.ConsultarPorNome(txtPesquisa.Text);

            //Após popular a "clienteColletion" eu atribuo ao DataSource
            //da grade
            dgvClientes.DataSource = clienteCollection;

            //Executemos os comando abaixo para atualizar a DataGrid
            dgvClientes.Update(); //Atualizar fonte de dados
            dgvClientes.Refresh(); //Atulizar os dados exibidos
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }
        private void frmClienteColecao_Load(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadCliente frm = new frmCadCliente();
            frm.ShowDialog();
        }

        private void frmClienteColecao_Activated(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum registro selecionado.");
                return;
            }

            DialogResult resultado = MessageBox.Show(
                "Deseja realmente excluir o registro selecionado?",
                "Importante",
                MessageBoxButtons.OKCancel);

            if (resultado == DialogResult.OK)
            {
                Cliente clienteSelecionado = RecuperarCliente();

                if (clienteSelecionado != null)
                {
                    if (MessageBox.Show(
                        "Deseja realmente excluir o registro?",
                        "Confirmação", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning) == DialogResult.Yes)
                    {


                        ClienteController clienteController = new ClienteController();

                        if (clienteController.Excluir(clienteSelecionado.Id) > 0)
                        {
                            MessageBox.Show("Registro excluído com sucesso.",
                                "Informação", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            Pesquisar();
                        }
                        else
                            MessageBox.Show("Não foi possível excluir o regsitro.",
                                "Atenção", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private Cliente RecuperarCliente()
        {
            if (dgvClientes.SelectedRows.Count != 0)
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
                return dgvClientes.SelectedRows[0].DataBoundItem
                as Cliente;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
          ClienteController controller = new ClienteController();
            Cliente clienteSelecionado = 
                controller.ConsultarPorId(
                    Convert.ToInt32(dgvClientes.SelectedRows[0].
                    Cells["Id"].Value));

            frmCadCliente frm = new frmCadCliente(clienteSelecionado);
            frm.ShowDialog();

        }

    }
}
