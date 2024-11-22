using ProjetoPOOB.Models;
using ProjetoPOOB.Services;
using System.Data;
using System;
using ProjetoPOOB.Views;

namespace ProjetoPOOB.Controllers
{
    public class ProdutosController
    {
       
        DataBaseSqlServerService dataBase = new DataBaseSqlServerService();

        public int Inserir(Produto produto)
        {
           
            string queryInserir =
                "INSERT INTO PRODUTO (PROD_NOME, PROD_DESCRICAO, " +
                "PROD_PRECO, PROD_ESTOQUE, PROD_UNIDMED, PROD_RESTAURANTE)" +
                " VALUES (@Nome, " +
                " @Descricao, @Preco, @Estoque, @UnMed, @RESTAURANTE)";

            dataBase.LimparParametros();

            
            dataBase.AdicionarParametros("@Nome", produto.NomeProduto);
            dataBase.AdicionarParametros("@Descricao", produto.Descricao);
            dataBase.AdicionarParametros("@Preco", produto.PrecoVenda);
            dataBase.AdicionarParametros("@Estoque", produto.EstoqueAtual);
            dataBase.AdicionarParametros("@UnMed", produto.UnMedida);
            dataBase.AdicionarParametros("@RESTAURANTE", produto.Restaurante);
           
            dataBase.ExecutarManipulacao(CommandType.Text, queryInserir);
            
            return Convert.ToInt32(dataBase.ExecutarConsultaScalar(
                CommandType.Text, "SELECT MAX(PROD_ID) FROM produto"));
        }

        public int Alterar(Produto produto)
        {
            string queryAlterar = "UPDATE PRODUTO SET " +
                 "PROD_NOME = @Nome," +
                 "PROD_DESCRICAO = @DESCRICAO," +
                 "PROD_PRECO = @PRECO," +
                 "PROD_ESTOQUE = @ESTOQUE," +
                 "PROD_UNIDMED = @UNMED, " +
                 "PROD_RESTAURANTE = @RESTAURANTE " +
                 "WHERE PROD_ID = @IdProduto";

            DataBaseSqlServerService dataBase = new DataBaseSqlServerService();

            dataBase.LimparParametros();

            dataBase.AdicionarParametros("@IdProduto", produto.IdProduto);
            dataBase.AdicionarParametros("@NOME", produto.NomeProduto);
            dataBase.AdicionarParametros("@DESCRICAO", produto.Descricao);
            dataBase.AdicionarParametros("@PRECO", produto.PrecoVenda);
            dataBase.AdicionarParametros("@ESTOQUE", produto.EstoqueAtual);
            dataBase.AdicionarParametros("@UNMED", produto.UnMedida);
            dataBase.AdicionarParametros("@RESTAURANTE", produto.Restaurante);

            dataBase.ExecutarManipulacao(CommandType.Text, queryAlterar);
            return 0;
        }
        #region ConsultarPorNome
        public ProdutoCollection ConsultarPorNome(string nome)
        {
            ProdutoCollection colecao = new ProdutoCollection();
            string query =
                "SELECT * FROM PRODUTO " +
                "WHERE PROD_NOME LIKE '%' + @Nome + '%'";

            dataBase.LimparParametros();
            dataBase.AdicionarParametros("@Nome", nome.Trim());

            DataTable dataTable = dataBase.ExecutarConsulta(
                CommandType.Text, query);
           

            foreach (DataRow dataRow in dataTable.Rows)
            {
                Produto produto = new Produto();
               
                produto.IdProduto = Convert.ToInt32(dataRow["PROD_ID"]);
                produto.NomeProduto = Convert.ToString(dataRow["PROD_NOME"]);
                produto.Descricao = Convert.ToString(dataRow["PROD_DESCRICAO"]);
                produto.PrecoVenda = Convert.ToDecimal(dataRow["PROD_PRECO"]);
                produto.EstoqueAtual = Convert.ToInt32(dataRow["PROD_ESTOQUE"]);
                produto.UnMedida = Convert.ToString(dataRow["PROD_UNIDMED"]);

                if (!(dataRow["PROD_RESTAURANTE"] is DBNull))
                    produto.Restaurante = Convert.ToInt32(dataRow["PROD_RESTAURANTE"]);
                else { produto.Restaurante = -1; }
                colecao.Add(produto);
            }
            return colecao;
        }
        #endregion

        #region ConsultarPorId
        public Produto ConsultarPorId(int Id)
        {
            string query =
                "SELECT * FROM PRODUTO " +
                "WHERE PROD_ID = @Id";

            dataBase.LimparParametros();
            dataBase.AdicionarParametros("@Id", Id);

            DataTable dataTable = dataBase.ExecutarConsulta(
                CommandType.Text, query);

            if (dataTable.Rows.Count > 0)
            {
                Produto produto = new Produto();
                //Agora vou indetificar o valor da linha na coluna
                //e atribuir ao objeto
                //Todo dado precisa ser convertido
                //do SQL Server para C#
                produto.IdProduto = Convert.ToInt32(dataTable.Rows[0]["PROD_ID"]);
                produto.NomeProduto = Convert.ToString(dataTable.Rows[0]["PROD_NOME"]);
                produto.Descricao = Convert.ToString(dataTable.Rows[0]["PROD_DESCRICAO"]);
                produto.PrecoVenda = Convert.ToDecimal(dataTable.Rows[0]["PROD_PRECO"]);
                produto.EstoqueAtual = Convert.ToInt32(dataTable.Rows[0]["PROD_ESTOQUE"]);
                produto.UnMedida = Convert.ToString(dataTable.Rows[0]["PROD_UNIDMED"]);

                if (!(dataTable.Rows[0]["PROD_RESTAURANTE"] is DBNull))
                { produto.Restaurante = Convert.ToInt32(dataTable.Rows[0]["PROD_RESTAURANTE"]); }
                else { produto.Restaurante = -1; }
                //Somente irei popular o atributo DtNascimento
                //Se o valor no banco de dados 
                //não estiver NULL

                return produto;
            }
            else
                return null;
        }
        #endregion

        public int Excluir(int Id)
        {
            string query =
                "Delete from PRODUTO where PROD_ID = @Id";

            dataBase.LimparParametros();
            dataBase.AdicionarParametros("@Id", Id);

            return dataBase.ExecutarManipulacao(
               CommandType.Text, query);
        }

        public ProdutoCollection ConsultarPorRestaurante(int Id)
        {
            ProdutoCollection collection = new ProdutoCollection();
            string query =
                "SELECT * FROM PRODUTO " +
                "WHERE PROD_RESTAURANTE = @Id";

            dataBase.LimparParametros();
            dataBase.AdicionarParametros("@Id", Id);

            DataTable dataTable = dataBase.ExecutarConsulta(
                CommandType.Text, query);

            if (dataTable.Rows.Count > 0)
            {
                Produto produto = new Produto();

                foreach (DataRow row in dataTable.Rows)
                {
                    produto.IdProduto = Convert.ToInt32(dataTable.Rows[0]["PROD_ID"]);
                    produto.NomeProduto = Convert.ToString(dataTable.Rows[0]["PROD_NOME"]);
                    produto.Descricao = Convert.ToString(dataTable.Rows[0]["PROD_DESCRICAO"]);
                    produto.PrecoVenda = Convert.ToDecimal(dataTable.Rows[0]["PROD_PRECO"]);
                    produto.EstoqueAtual = Convert.ToInt32(dataTable.Rows[0]["PROD_ESTOQUE"]);
                    produto.UnMedida = Convert.ToString(dataTable.Rows[0]["PROD_UNIDMED"]);
                    produto.Restaurante = Convert.ToInt32(dataTable.Rows[0]["PROD_RESTAURANTE"]);

                    collection.Add(produto);
                }
                return collection;
            }
            else
                return null;
        }
    }
}
