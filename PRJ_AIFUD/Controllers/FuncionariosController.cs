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
                CommandType.Text, "SELECT MAX(FUNC_ID) FROM FUNCIONARIO"));
        }
        #region
        public int Alterar(Funcionarios funcionario)
        {
            string queryAlterar =
                "UPDATE FUNCIONARIO SET " +
                "FUNC_NOME = @Nome, " +
                "FUNC_CPF = @CPF, " +
                "FUNC_DataNascimento = @DataNascimento, " +
                "FUNC_ENDERECO = @Endereco, " +
                "FUNC_TELEFONE = @telefone, " +
                "FUNC_FUNCAO = @Funcao, "+
                "FUNC_TURNO = @Turno " +
                "WHERE Func_Id = @FuncId";

            dataBase.LimparParametros();
            dataBase.AdicionarParametros("@Nome", funcionario.Nome);
            dataBase.AdicionarParametros("@CPF", funcionario.CPF);
            dataBase.AdicionarParametros("@DataNascimento", funcionario.DtNascimento);
            dataBase.AdicionarParametros("@Endereco", funcionario.Endereco);
            dataBase.AdicionarParametros("@Telefone", funcionario.Telefone);
            dataBase.AdicionarParametros("@Funcao", funcionario.Funcao);
            dataBase.AdicionarParametros("@Turno", funcionario.Turno);
            dataBase.AdicionarParametros("@FuncId", funcionario.Id);

            dataBase.ExecutarManipulacao(
                CommandType.Text, queryAlterar);
            return 0;
        }
        #endregion
        #region ConsultarPorNome
        public FuncionarioCollections ConsultarPorNome(string nome)
        {
            FuncionarioCollections funcionariosColecao = new FuncionarioCollections();
            string query =
                "SELECT * FROM FUNCIONARIO " +
                "WHERE FUNC_NOME LIKE '%' + @Nome + '%'";

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
                Funcionarios funcionario = new Funcionarios();
                //Agora vou indetificar o valor da linha na coluna
                //e atribuir ao objeto
                //Todo dado precisa ser convertido
                //do SQL Server para C#
                funcionario.Id = Convert.ToInt32(dataRow["FUNC_ID"]);
                funcionario.Nome = Convert.ToString(dataRow["FUNC_NOME"]);
                funcionario.CPF = Convert.ToString(dataRow["FUNC_CPF"]);
                funcionario.Endereco = Convert.ToString(dataRow["FUNC_ENDERECO"]);
                funcionario.Turno = Convert.ToString(dataRow["FUNC_TURNO"]);
                funcionario.Funcao = Convert.ToString(dataRow["FUNC_Funcao"]);

                //Somente irei popular o atributo DtNascimento
                //Se o valor no banco de dados 
                //não estiver NULL
                if (!(dataRow["FUNC_DataNascimento"] is DBNull))
                    funcionario.DtNascimento =
                        Convert.ToDateTime(dataRow["FUNC_DataNascimento"]);
                funcionario.Telefone = Convert.ToString(dataRow["FUNC_TELEFONE"]);

                //Adicione o objeto cliente na Coleção de Clientes
                //Ou seja cada linha retorna será um objeto
                //E a Collection tera um objeto de cada linha
                funcionariosColecao.Add(funcionario);
            }
            return funcionariosColecao;
        }
        #endregion

        #region ConsultarPorId
        public Funcionarios ConsultarPorId(int idFuncionario)
        {
            string query =
                "SELECT * FROM FUNCIONARIO " +
                "WHERE FUNC_ID = @Id";

            dataBase.LimparParametros();
            dataBase.AdicionarParametros("@Id", idFuncionario);

            DataTable dataTable = dataBase.ExecutarConsulta(
                CommandType.Text, query);

            if (dataTable.Rows.Count > 0)
            {
                Funcionarios funcionario = new Funcionarios();
                //Agora vou indetificar o valor da linha na coluna
                //e atribuir ao objeto
                //Todo dado precisa ser convertido
                //do SQL Server para C#
                funcionario.Id = Convert.ToInt32(dataTable.Rows[0]["FUNC_ID"]);
                funcionario.Nome = Convert.ToString(dataTable.Rows[0]["FUNC_NOME"]);
                funcionario.CPF = Convert.ToString(dataTable.Rows[0]["FUNC_CPF"]);
                funcionario.Endereco = Convert.ToString(dataTable.Rows[0]["FUNC_ENDERECO"]);
                funcionario.Turno = Convert.ToString(dataTable.Rows[0]["FUNC_TURNO"]);
                funcionario.Funcao = Convert.ToString(dataTable.Rows[0]["FUNC_Funcao"]);

                //Somente irei popular o atributo DtNascimento
                //Se o valor no banco de dados 
                //não estiver NULL
                if (!(dataTable.Rows[0]["FUNC_DataNascimento"] is DBNull))
                    funcionario.DtNascimento =
                        Convert.ToDateTime(dataTable.Rows[0]["FUNC_DataNascimento"]);
                funcionario.Telefone = Convert.ToString(dataTable.Rows[0]["FUNC_TELEFONE"]);

                //Adicione o objetFUNCliente na Coleção de Clientes
                //Ou seja cada linha retorna será um objeto
                //E a Collection tera um objeto de cada linha
                return funcionario;
            }
            else
                return null;
        }
        #endregion

        public int Excluir(int Id)
        {

            string query =
                "Delete from FUNCIONARIO where FUNC_ID = @FUNC_Id";

            dataBase.LimparParametros();
            dataBase.AdicionarParametros("@FUNC_Id", Id);

            return dataBase.ExecutarManipulacao(
               CommandType.Text, query);
        }
    }
}
