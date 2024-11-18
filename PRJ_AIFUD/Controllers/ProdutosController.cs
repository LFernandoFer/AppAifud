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
                "PROD_PRECO, PROD_QUANTIDADE, PROD_UNIMED) VALUES (@Nome, " +
                " @Descricao, @Preco, @Estoque, @UnMed)";

            //Limpar qualquer sujeiro do objeto que armezana
            //os parametros
            dataBase.LimparParametros();

            //Adiona os valores de cada parametro que esta sendo utilizado
            dataBase.AdicionarParametros("@Nome", produto.NomeProduto);
            dataBase.AdicionarParametros("@Descricao", produto.Descricao);
            dataBase.AdicionarParametros("@Preco", produto.PrecoVenda);
            dataBase.AdicionarParametros("@Estoque",produto.EstoqueAtual);
            dataBase.AdicionarParametros("@UnMed", produto.UnMedida);

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
            string queryAlterar = "UPDATE PRODUTO SET" +
                 "PROD_NOME = @Nome" +
                 "PROD_DESCRICAO = @DESCRICAO" +
                 "PROD_PRECO = @PRECO" +
                 "PROD_QUANTIDADE = @ESTOQUE" +
                 "PROD_UNIMED = @UNMED" +
                 "WHERE PROD_ID = @IdProduto";

            DataBaseSqlServerService dataBase = new DataBaseSqlServerService();

            dataBase.LimparParametros();

            dataBase.AdicionarParametros("@NOME", produto.NomeProduto);
            dataBase.AdicionarParametros("@DESCRICAO", produto.Descricao);
            dataBase.AdicionarParametros("@PRECO", produto.PrecoVenda);
            dataBase.AdicionarParametros("@ESTOQUE", produto.EstoqueAtual);
            dataBase.AdicionarParametros("@UNMED", produto.UnMedida);

            return 0;
        }
    }
}
