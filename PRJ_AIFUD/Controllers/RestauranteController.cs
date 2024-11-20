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
    public class RestauranteController
    {
        DataBaseSqlServerService dataBase = new DataBaseSqlServerService();
        public int Inserir(Restaurante restaurante)
        {
            string queryInserir = "INSERT INTO RESTAURANTE (RES_CNPJ, RES_NOME,RES_TEMA," +
                " RES_TELEFONE, RES_ENDERECO) VALUES (@CNPJ,@NOME,@TEMA, @TELEFONE," +
                " @ENDERECO)";

            dataBase.LimparParametros();
            dataBase.AdicionarParametros("@CNPJ", restaurante.CNPJ);
            dataBase.AdicionarParametros("@NOME", restaurante.Nome);
            dataBase.AdicionarParametros("@TEMA", restaurante.Tema);
            dataBase.AdicionarParametros("@TELEFONE", restaurante.Telefone);
            dataBase.AdicionarParametros("@ENDERECO", restaurante.Endereco);

            dataBase.ExecutarManipulacao(CommandType.Text, queryInserir);

            return Convert.ToInt32(dataBase.ExecutarConsultaScalar(
                CommandType.Text, "SELECT MAX(RES_ID) FROM RESTAURANTE"));
        }
        public int Alterar(Restaurante restaurante)
        {
            string queryAlterar ="UPDATE RESTAURANTE SET " +
                 "RES_CNPJ = @CNPJ," +
                 "RES_NOME = @NOME, " +
                 "RES_TEMA = @TEMA, " +
                 "RES_TELEFONE  = @TELEFONE, " +
                 "RES_ENDERECO = @ENDERECO " +
                 "WHERE RES_ID = @Id";


            dataBase.LimparParametros();

            dataBase.AdicionarParametros("@Id",   restaurante.Id);
            dataBase.AdicionarParametros("@CNPJ", restaurante.CNPJ);
            dataBase.AdicionarParametros("@NOME", restaurante.Nome);
            dataBase.AdicionarParametros("@TEMA", restaurante.Tema);
            dataBase.AdicionarParametros("@TELEFONE", restaurante.Telefone);
            dataBase.AdicionarParametros("@ENDERECO", restaurante.Endereco);

            dataBase.ExecutarManipulacao(CommandType.Text, queryAlterar);
            return 0;
        }


        #region ConsultarPorNome
        public RestauranteCollection ConsultarPorNome(string nome)
        {

            RestauranteCollection colecao = new RestauranteCollection();
            string query =
                "SELECT * FROM RESTAURANTE " +
                "WHERE RES_NOME LIKE '%' + @Nome + '%'";

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
                Restaurante restaurante = new Restaurante();
                //Agora vou indetificar o valor da linha na coluna
                //e atribuir ao objeto
                //Todo dado precisa ser convertido
                //do SQL Server para C#
                restaurante.Id = Convert.ToInt32(dataRow["RES_ID"]);
                restaurante.CNPJ = Convert.ToString(dataRow["RES_CNPJ"]);
                restaurante.Nome = Convert.ToString(dataRow["RES_NOME"]);
                restaurante.Tema = Convert.ToString(dataRow["RES_TEMA"]);
                restaurante.Telefone = Convert.ToString(dataRow["RES_TELEFONE"]);
                restaurante.Endereco = Convert.ToString(dataRow["RES_ENDERECO"]);
                //Somente irei popular o atributo DtNascimento
                //Se o valor no banco de dados 
                //não estiver NULL


                //Adicione o objeto cliente na Coleção de Clientes
                //Ou seja cada linha retorna será um objeto
                //E a Collection te²ra um objeto de cada linha
                colecao.Add(restaurante);
            }
            return colecao;
        }
        #endregion

        #region ConsultarPorId
        public Restaurante ConsultarPorId(int Id)
        {

            string query =
                "SELECT * FROM RESTAURANTE " +
                "WHERE RES_ID = @Id";

            dataBase.LimparParametros();
            dataBase.AdicionarParametros("@Id", Id);

            DataTable dataTable = dataBase.ExecutarConsulta(
                CommandType.Text, query);

            if (dataTable.Rows.Count > 0)
            {
                Restaurante restaurante = new Restaurante();
                //Agora vou indetificar o valor da linha na coluna
                //e atribuir ao objeto
                //Todo dado precisa ser convertido
                //do SQL Server para C#
                restaurante.Id = Convert.ToInt32(dataTable.Rows[0]["RES_ID"]);
                restaurante.CNPJ = Convert.ToString(dataTable.Rows[0]["RES_CNPJ"]);
                restaurante.Nome = Convert.ToString(dataTable.Rows[0]["RES_NOME"]);
                restaurante.Tema = Convert.ToString(dataTable.Rows[0]["RES_TEMA"]);
                restaurante.Telefone = Convert.ToString(dataTable.Rows[0]["RES_TELEFONE"]);
                restaurante.Endereco = Convert.ToString(dataTable.Rows[0]["RES_ENDERECO"]);
                //Se o valor no banco de dados 
                //não estiver NULL

                return restaurante;
            }
            else
                return null;
        }
        #endregion
        public int Excluir(int Id)
        {
            string query =
                "Delete from RESTAURANTE where RES_ID = @Id";

            dataBase.LimparParametros();
            dataBase.AdicionarParametros("@Id", Id);

            return dataBase.ExecutarManipulacao(
               CommandType.Text, query);
        }
    }
}
