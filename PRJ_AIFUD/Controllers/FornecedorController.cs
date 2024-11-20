using ProjetoPOOB.Services;
using ProjetoPOOB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProjetoPOOB.Controllers
{
    public class FornecedorController
    {
        DataBaseSqlServerService dataBase = new DataBaseSqlServerService();
        public int Inserir(Fornecedor fornecedor)
        {
            string queryInserir = "INSERT INTO FORNECEDOR (FOR_CNPJ, FOR_NOME,FOR_RAMO," +
                " FOR_TELEFONE, FOR_ENDERECO) VALUES (@CNPJ,@NOME,@RAMO, @TELEFONE," +
                " @ENDERECO)";

            dataBase.LimparParametros();
            dataBase.AdicionarParametros("@CNPJ", fornecedor.CNPJ);
            dataBase.AdicionarParametros("@NOME", fornecedor.Nome);
            dataBase.AdicionarParametros("@RAMO", fornecedor.Ramo);
            dataBase.AdicionarParametros("@TELEFONE", fornecedor.Telefone);
            dataBase.AdicionarParametros("@ENDERECO", fornecedor.Endereco);

            dataBase.ExecutarManipulacao(CommandType.Text, queryInserir);
           
            return Convert.ToInt32(dataBase.ExecutarConsultaScalar(
                CommandType.Text, "SELECT MAX(FOR_ID) FROM FORNECEDOR"));
        }
        public int Alterar(Fornecedor fornecedor)
        {
            string queryAlterar = "UPDATE FORNECEDOR SET " +
                 "FOR_CNPJ = @CNPJ," +
                 "FOR_NOME = @NOME, " +
                 "FOR_RAMO = @RAMO, " +
                 "FOR_TELEFONE  = @TELEFONE, " +
                 "FOR_ENDERECO = @ENDERECO " +
                 "WHERE FOR_ID = @Id";

            
            dataBase.LimparParametros();

            dataBase.AdicionarParametros("@Id", fornecedor.Id);
            dataBase.AdicionarParametros("@CNPJ", fornecedor.CNPJ);
            dataBase.AdicionarParametros("@NOME", fornecedor.Nome);
            dataBase.AdicionarParametros("@RAMO", fornecedor.Ramo);
            dataBase.AdicionarParametros("@TELEFONE", fornecedor.Telefone);
            dataBase.AdicionarParametros("@ENDERECO", fornecedor.Endereco);

            dataBase.ExecutarManipulacao(CommandType.Text, queryAlterar);
            return 0;
        }


        #region ConsultarPorNome
        public FornecedorCollection ConsultarPorNome(string nome)
        {
            
            FornecedorCollection colecao = new FornecedorCollection();
            string query =
                "SELECT * FROM FORNECEDOR " +
                "WHERE FOR_NOME LIKE '%' + @Nome + '%'";

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
                Fornecedor fornecedor = new Fornecedor();
                //Agora vou indetificar o valor da linha na coluna
                //e atribuir ao objeto
                //Todo dado precisa ser convertido
                //do SQL Server para C#
                fornecedor.Id = Convert.ToInt32(dataRow["FOR_ID"]);
                fornecedor.CNPJ = Convert.ToString(dataRow["FOR_CNPJ"]);
                fornecedor.Nome = Convert.ToString(dataRow["FOR_NOME"]);
                fornecedor.Ramo = Convert.ToString(dataRow["FOR_RAMO"]);
                fornecedor.Telefone = Convert.ToString(dataRow["FOR_TELEFONE"]);
                fornecedor.Endereco = Convert.ToString(dataRow["FOR_ENDERECO"]);
                //Somente irei popular o atributo DtNascimento
                //Se o valor no banco de dados 
                //não estiver NULL


                //Adicione o objeto cliente na Coleção de Clientes
                //Ou seja cada linha retorna será um objeto
                //E a Collection te²ra um objeto de cada linha
                colecao.Add(fornecedor);
            }
            return colecao;
        }
        #endregion

        #region ConsultarPorId
        public Fornecedor ConsultarPorId(int Id)
        {
           
            string query =
                "SELECT * FROM FORNECEDOR " +
                "WHERE FOR_ID = @Id";

            dataBase.LimparParametros();
            dataBase.AdicionarParametros("@Id", Id);

            DataTable dataTable = dataBase.ExecutarConsulta(
                CommandType.Text, query);

            if (dataTable.Rows.Count > 0)
            {
                Fornecedor fornecedor = new Fornecedor();
                //Agora vou indetificar o valor da linha na coluna
                //e atribuir ao objeto
                //Todo dado precisa ser convertido
                //do SQL Server para C#
                fornecedor.Id = Convert.ToInt32(dataTable.Rows[0]["FOR_ID"]);
                fornecedor.CNPJ = Convert.ToString(dataTable.Rows[0]["FOR_CNPJ"]);
                fornecedor.Nome = Convert.ToString(dataTable.Rows[0]["FOR_NOME"]);
                fornecedor.Ramo = Convert.ToString(dataTable.Rows[0]["FOR_RAMO"]);
                fornecedor.Telefone = Convert.ToString(dataTable.Rows[0]["FOR_TELEFONE"]);
                fornecedor.Endereco = Convert.ToString(dataTable.Rows[0]["FOR_ENDERECO"]);
                //Se o valor no banco de dados 
                //não estiver NULL

                return fornecedor;
            }
            else
                return null;
        }
        #endregion
        public int Excluir(int Id)
        {
            string query =
                "Delete from FORNECEDOR where FOR_ID = @Id";

            dataBase.LimparParametros();
            dataBase.AdicionarParametros("@Id", Id);

            return dataBase.ExecutarManipulacao(
               CommandType.Text, query);
        }
    }
}
