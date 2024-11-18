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
    public partial class frmFuncionarioColecao : Form
    {
        public frmFuncionarioColecao()
        {
            InitializeComponent();

            Pesquisar();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }
        private void Pesquisar()
        {
            int id = 0;

            FuncionariosController controler = new FuncionariosController();

            //O DataGrid somente exibe listas, portanto,
            //Não é possivel passar apenas um objeto do tipo
            //"Cliente" para ele. É nescessario que seum "ClineteCollection"
            //Lembrando que o "ClienteCollection" herda de "TList<>"
            FuncionarioCollections collections = new FuncionarioCollections();

            //"DataSource" é a propriedade do DataGrid que
            //que faz uma referencia o objeto que possui os dados
            //que serão exibidos. No caso ele´irá possuir, uma referencia
            //para o "ClienteCollection" 
            //Ou seja o "ClienteColletion" será a fonte de dados 
            //para o DataSource do DataGrid
            //Sempre é preciso limpar a grade ao realizar uma nova pesquisa

            dgvFuncionarios.DataSource = null;

            //Validar se o valor informado para pesquisa é do tipo Int
            if (int.TryParse(txtPesquisa.Text, out id))
            {
                //Uma consulta por ID pode retornar no maximo 1 registro
                //ou nenhum registro, sendo nescessario validar se o registro
                //está nullo, se o registro não for nullo o adiconamos
                //a "ClienteCollection"
                Funcionarios funcionario = controler.ConsultarPorId(id);
                if (funcionario != null)
                    collections.Add(funcionario);
            }
            else
                collections =
                   controler.ConsultarPorNome(txtPesquisa.Text);

            //Após popular a "clienteColletion" eu atribuo ao DataSource
            //da grade
            dgvFuncionarios.DataSource = collections;
            //EFuncionarioss os comando abaixo para atualizar a DataGrid
            dgvFuncionarios.Update(); //Atualizar fonte de dados
            dgvFuncionarios.Refresh(); //Atulizar os dados exibidos
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadFuncionarioView frm = new frmCadFuncionarioView();
            frm.ShowDialog();
        }
    }
}