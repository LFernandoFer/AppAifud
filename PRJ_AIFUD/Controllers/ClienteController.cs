using ProjetoPOOB.Services;
using ProjetoPOOB.Models;
using System.Data;
using System;

namespace ProjetoPOOB.Controllers
{
    public class ClienteController
    {
        //Criar instancia global para acessar a classe DataBase
        DataBaseSqlServerService dataBase = new DataBaseSqlServerService();

        //Método Inserir 
        //Ira inserir o cadastro do cliente no banco de dados
        //Nesse caso receberá via parametros o objeto Cliente

        public int Inserir(Cliente cliente)
        {
            //Iremos montar a nossa sql
            //Variavel local que armazena o comando que será
            //executado no banco de dados
            //O "@" indica para o SQL a utilização de 
            //parametros
            string queryInserir =
                "INSERT INTO cliente (CLI_NOME, CLI_CPF, " +
                "CLI_DataNascimento, CLI_ENDERECO,CLI_TELEFONE) VALUES (@Nome, " +
                " @CPF, @DataNascimento,@Endereco ,@Telefone)";
            
            //Limpar qualquer sujeiro do objeto que armezana
            //os parametros
            dataBase.LimparParametros();

            //Adiona os valores de cada parametro que esta sendo utilizado
            dataBase.AdicionarParametros("@Nome", cliente.Nome);
            dataBase.AdicionarParametros("@CPF", cliente.CPF);
            dataBase.AdicionarParametros("@DataNascimento", cliente.DtNascimento);
            dataBase.AdicionarParametros("@Endereco", cliente.Endereco);
            dataBase.AdicionarParametros("@Telefone", cliente.Telefone);

            //Solicita a camada de banco de dados a execução da query
            dataBase.ExecutarManipulacao(CommandType.Text, queryInserir);
            //Nesse momento o meu comando é executado no banco de dados

            //Executar um comando no banco de dados, para recupear o ID criado
            //pelo Identity
            //SELECT MAX(id_cliente) FROM cliente
            return Convert.ToInt32(dataBase.ExecutarConsultaScalar(
                CommandType.Text, "SELECT MAX(CLI_ID) FROM cliente"));
        }
    }
}
