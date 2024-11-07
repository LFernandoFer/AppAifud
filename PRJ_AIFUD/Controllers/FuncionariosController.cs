using ProjetoPOOB.Models;
using ProjetoPOOB.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPOOB.Controllers
{
    public class FuncionariosController
    {
        //Criar instancia global para acessar a classe DataBase
        DataBaseSqlServerService dataBase = new DataBaseSqlServerService();

        //Método Inserir 
        //Ira inserir o cadastro do cliente no banco de dados
        //Nesse caso receberá via parametros o objeto Cliente

        public int Inserir(Funcionarios funcionario)
        {
            //Iremos montar a nossa sql
            //Variavel local que armazena o comando que será
            //executado no banco de dados
            //O "@" indica para o SQL a utilização de 
            //parametros
            string queryInserir =
                "INSERT INTO FUNCIONARIO (FUNC_NOME, FUNC_CPF, " +
                "FUNC_DataNascimento, FUNC_ENDERECO,FUNC_TELEFONE , FUNC_TURNO, FUNC_FUNCAO) VALUES (@Nome, " +
                " @CPF, @DataNascimento,@Endereco ,@Telefone,@Turno ,@Funcao)";

            //Limpar qualquer sujeiro do objeto que armezana
            //os parametros
            dataBase.LimparParametros();

            //Adiona os valores de cada parametro que esta sendo utilizado
            dataBase.AdicionarParametros("@Nome", funcionario.Nome);
            dataBase.AdicionarParametros("@CPF", funcionario.CPF);
            dataBase.AdicionarParametros("@DataNascimento", funcionario.DtNascimento);
            dataBase.AdicionarParametros("@Endereco", funcionario.Endereco);
            dataBase.AdicionarParametros("@Telefone", funcionario.Telefone);
            dataBase.AdicionarParametros("@Turno", funcionario.Turno);
            dataBase.AdicionarParametros("@Funcao", funcionario.Funcao);

            //Solicita a camada de banco de dados a execução da query
            dataBase.ExecutarManipulacao(CommandType.Text, queryInserir);
            //Nesse momento o meu comando é executado no banco de dados

            //Executar um comando no banco de dados, para recupear o ID criado
            //pelo Identity
            //SELECT MAX(id_cliente) FROM cliente
            return Convert.ToInt32(dataBase.ExecutarConsultaScalar(
                CommandType.Text, "SELECT MAX(CLI_ID) FROM cliente"));
        }
        public int Alterar(Funcionarios funcionario)
        {
            string queryAlterar =
                "UPDATE cliente SET " +
                "FUNC_NOME = @Nome, " +
                "FUNC_CPF = @CPF, " +
                "FUNC_DataNascimento = @DataNascimento, " +
                "FUNC_ENDERECO = @Endereco" +
                "FUNC_TELEFONE = @telefone " +
                "FUNC_FUNCAO = @Funcao"+
                "FUNC_TURNO = @Turno" +
                "WHERE Func_Id = @FuncId";

            dataBase.LimparParametros();
            dataBase.AdicionarParametros("@Nome", funcionario.Nome);
            dataBase.AdicionarParametros("@CPF", funcionario.CPF);
            dataBase.AdicionarParametros("@DataNascimento", funcionario.DtNascimento);
            dataBase.AdicionarParametros("@Endereco", funcionario.Endereco);
            dataBase.AdicionarParametros("@Telefone", funcionario.Telefone);
            dataBase.AdicionarParametros("@Funcao", funcionario.Funcao);
            dataBase.AdicionarParametros("@Turno", funcionario.Turno);
            dataBase.AdicionarParametros("@FuncId", funcionario.IdCliente);

            return dataBase.ExecutarManipulacao(
                CommandType.Text, queryAlterar);
        }
        #region ConsultarPorNome
        public ClienteCollection ConsultarPorNome(string nome)
        {
            ClienteCollection clienteColecao = new ClienteCollection();
            string query =
                "SELECT * FROM CLIENTE " +
                "WHERE CLI_NOME LIKE '%' + @Nome + '%'";

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
                Cliente cliente = new Cliente();
                //Agora vou indetificar o valor da linha na coluna
                //e atribuir ao objeto
                //Todo dado precisa ser convertido
                //do SQL Server para C#
                cliente.IdCliente = Convert.ToInt32(dataRow["CLI_ID"]);
                cliente.Nome = Convert.ToString(dataRow["CLI_NOME"]);
                cliente.CPF = Convert.ToString(dataRow["CLI_CPF"]);
                cliente.Endereco = Convert.ToString(dataRow["CLI_ENDERECO"]);
                //Somente irei popular o atributo DtNascimento
                //Se o valor no banco de dados 
                //não estiver NULL
                if (!(dataRow["CLI_DataNascimento"] is DBNull))
                    cliente.DtNascimento =
                        Convert.ToDateTime(dataRow["CLI_DataNascimento"]);
                cliente.Telefone = Convert.ToString(dataRow["CLI_TELEFONE"]);

                //Adicione o objeto cliente na Coleção de Clientes
                //Ou seja cada linha retorna será um objeto
                //E a Collection tera um objeto de cada linha
                clienteColecao.Add(cliente);
            }
            return clienteColecao;
        }
        #endregion

        #region ConsultarPorId
        public Cliente ConsultarPorId(int IdCliente)
        {
            string query =
                "SELECT * FROM CLIENTE " +
                "WHERE CLI_ID = @IdCliente";

            dataBase.LimparParametros();
            dataBase.AdicionarParametros("@IdCliente", IdCliente);

            DataTable dataTable = dataBase.ExecutarConsulta(
                CommandType.Text, query);

            if (dataTable.Rows.Count > 0)
            {
                Cliente cliente = new Cliente();
                //Agora vou indetificar o valor da linha na coluna
                //e atribuir ao objeto
                //Todo dado precisa ser convertido
                //do SQL Server para C#
                cliente.IdCliente = Convert.ToInt32(dataTable.Rows[0]["CLI_ID"]);
                cliente.Nome = Convert.ToString(dataTable.Rows[0]["CLI_NOME"]);
                cliente.CPF = Convert.ToString(dataTable.Rows[0]["CLI_CPF"]);
                //Somente irei popular o atributo DtNascimento
                //Se o valor no banco de dados 
                //não estiver NULL
                if (!(dataTable.Rows[0]["CLI_DataNascimento"] is DBNull))
                    cliente.DtNascimento =
                        Convert.ToDateTime(dataTable.Rows[0]["CLI_DataNascimento"]);
                cliente.Telefone = Convert.ToString(dataTable.Rows[0]["CLI_TELEFONE"]);

                //Adicione o objeto cliente na Coleção de Clientes
                //Ou seja cada linha retorna será um objeto
                //E a Collection tera um objeto de cada linha
                return cliente;
            }
            else
                return null;
        }
        #endregion

        public int Excluir(int IdCliente)
        {

            string query =
                "Delete from Cliente where CLI_ID = @CLI_Id";

            dataBase.LimparParametros();
            dataBase.AdicionarParametros("@CLI_Id", IdCliente);

            return dataBase.ExecutarManipulacao(
               CommandType.Text, query);
        }
    }
}
