using ProjetoPOOB.Models;
using ProjetoPOOB.Services;
using System.Data;
using System;

namespace ProjetoPOOB.Controllers
{
    public class ProdutosController
    {
        //Criar instancia global para acessar a classe DataBase
        DataBaseSqlServerService dataBase = new DataBaseSqlServerService();

        //Método Inserir 
        //Ira inserir o cadastro do cliente no banco de dados
        //Nesse caso receberá via parametros o objeto Cliente

        public int Inserir(Produto produto)
        {
            //Iremos montar a nossa sql
            //Variavel local que armazena o comando que será
            //executado no banco de dados
            //O "@" indica para o SQL a utilização de 
            //parametros
            string queryInserir =
                "INSERT INTO PRODUTO (PROD_NOME, PROD_DESCRICAO, " +
                "PROD_PRECO, PROD_ESTOQUE, PROD_UNIDMED, PROD_RESTAURANTE)" +
                " VALUES (@Nome, " +
                " @Descricao, @Preco, @Estoque, @UnMed, @RESTAURANTE)";

            //Limpar qualquer sujeiro do objeto que armezana
            //os parametros
            dataBase.LimparParametros();

            //Adiona os valores de cada parametro que esta sendo utilizado
            dataBase.AdicionarParametros("@Nome", produto.NomeProduto);
            dataBase.AdicionarParametros("@Descricao", produto.Descricao);
            dataBase.AdicionarParametros("@Preco", produto.PrecoVenda);
            dataBase.AdicionarParametros("@Estoque",produto.EstoqueAtual);
            dataBase.AdicionarParametros("@UnMed", produto.UnMedida);
            dataBase.AdicionarParametros("@RESTAURANTE", produto.Restaurante);
            //Solicita a camada de banco de dados a execução da query
            dataBase.ExecutarManipulacao(CommandType.Text, queryInserir);
            //Nesse momento o meu comando é executado no banco de dados

            //Executar um comando no banco de dados, para recupear o ID criado
            //pelo Identity
            //SELECT MAX(id_cliente) FROM cliente
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
                 "PROD_RESTAURANTE = @RESTAURANTE" +
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
            //Neste momento o SELECT foi executado 
            //E o banco retornou um DataTable
            //Agora precisamos converter esse DataTable
            //para ClienteCollection

            foreach (DataRow dataRow in dataTable.Rows)
            {
                Produto produto = new Produto();
                //Agora vou indetificar o valor da linha na coluna
                //e atribuir ao objeto
                //Todo dado precisa ser convertido
                //do SQL Server para C#
                produto.IdProduto = Convert.ToInt32(dataRow["PROD_ID"]);
                produto.NomeProduto = Convert.ToString(dataRow["PROD_NOME"]);
                produto.Descricao = Convert.ToString(dataRow["PROD_DESCRICAO"]);
                produto.PrecoVenda = Convert.ToDecimal(dataRow["PROD_PRECO"]);
                produto.EstoqueAtual = Convert.ToInt32(dataRow["PROD_ESTOQUE"]);
                produto.UnMedida = Convert.ToString(dataRow["PROD_UNIDMED"]);
                produto.Restaurante = Convert.ToInt32(dataRow["PROD_RESTAURANTE"]);
                //Somente irei popular o atributo DtNascimento
                //Se o valor no banco de dados 
                //não estiver NULL
               

                //Adicione o objeto cliente na Coleção de Clientes
                //Ou seja cada linha retorna será um objeto
                //E a Collection te²ra um objeto de cada linha
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
                produto.Restaurante = Convert.ToInt32(dataTable.Rows[0]["PROD_RESTAURANTE"]);
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
    }
}
