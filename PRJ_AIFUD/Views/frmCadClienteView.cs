using ProjetoPOOB.Controllers;
using ProjetoPOOB.Models;
using System;
using System.Windows.Forms;

namespace ProjetoPOOB
{
    public partial class frmCadClienteView : Form
    {
        public frmCadClienteView()
        {
            InitializeComponent();
            btnAtualizar.Visible = false;
        }

        public frmCadClienteView(Cliente cliente)
        {
            InitializeComponent();

            btnSalvar.Visible = false;

            txtId.Text = Convert.ToString(cliente.Id);
            txtNome.Text = cliente.Nome;
            txtEndereco.Text = cliente.Endereco;
            mskCPF.Text = cliente.CPF;
            dtpNascimento.Value = cliente.DtNascimento;
            mskTelefone.Text = cliente.Telefone;

        }
        ClienteController controler = new ClienteController();

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = txtNome.Text;
            cliente.Telefone = mskTelefone.Text.ToString();
            cliente.CPF = mskCPF.Text;
            cliente.Endereco = txtEndereco.Text;
            cliente.DtNascimento = Convert.ToDateTime(dtpNascimento.Text);

            MessageBox.Show("Cliente nº " + controler.Inserir(cliente)
                + " cadastrado com sucesso");

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            cliente.Id = Convert.ToInt32(txtId.Text);
            cliente.Nome = txtNome.Text;
            cliente.Telefone = mskTelefone.Text.ToString();
            cliente.CPF = mskCPF.Text;
            cliente.Endereco = txtEndereco.Text;
            cliente.DtNascimento = Convert.ToDateTime(dtpNascimento.Text);

            ClienteController controller = new ClienteController();
            
            controller.Alterar(cliente);

            MessageBox.Show("Alteração realizada com sucesso!", "Sucesso!");
        }
    }
}
