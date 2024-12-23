﻿using ProjetoPOOB.Controllers;
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
    public partial class frmFornecedorColecao : Form
    {
        public frmFornecedorColecao()
        {
            InitializeComponent();

            Pesquisar();
        }
        #region CarregarTela
        private void frmFornecedorColecao_Load(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }
        private void frmFornecedorColecao_Activated(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadFornecedorView frm = new frmCadFornecedorView();
            frm.ShowDialog();
        }
        #endregion
        public void Pesquisar()
        {
            int id = 0;

            FornecedorController controller = new FornecedorController();
            FornecedorCollection collection = new FornecedorCollection();

            dgvFornecedores.DataSource = null;

            if (int.TryParse(txtPesquisa.Text, out id))
            {
                Fornecedor fornecedor
                    = controller.ConsultarPorId(id);
                if (fornecedor != null)
                    collection.Add(fornecedor);
            }
            else
                collection =
                    controller.ConsultarPorNome(txtPesquisa.Text);

            dgvFornecedores.DataSource = collection;

            dgvFornecedores.Update(); //Atualizar fonte de dados
            dgvFornecedores.Refresh(); //Atulizar os dados exibidos
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            FornecedorController controller = new FornecedorController();
            Fornecedor fornecedorSelecionado =
                controller.ConsultarPorId(
                    Convert.ToInt32(dgvFornecedores.SelectedRows[0].
                    Cells["Id"].Value));
                
            fornecedorSelecionado.Id = Convert.ToInt32(dgvFornecedores.SelectedRows[0].
                    Cells["Id"].Value);

            frmCadFornecedorView frm = new frmCadFornecedorView(fornecedorSelecionado);
            frm.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedorSelecionado = RecuperarFornecedor();

            if (fornecedorSelecionado != null)
            {
                if (MessageBox.Show(
                    "Deseja realmente excluir o registro?",
                    "Confirmação", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {


                    FornecedorController controller = new FornecedorController();

                    if (controller.Excluir(fornecedorSelecionado.Id) > 0)
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

        private Fornecedor RecuperarFornecedor()
        {
            if (dgvFornecedores.SelectedRows.Count == 0)
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
                return dgvFornecedores.SelectedRows[0].DataBoundItem
                as Fornecedor;
            }
        }
    }
}
