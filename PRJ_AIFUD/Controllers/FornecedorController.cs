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
        public int Inserir(Fornecedor fornecedor)
        {
            string queryInserir = "INSERT INTO FORNECEDOR (FOR_CNPJ, FOR_NOME,FOR_RAMO," +
                " FOR_TELEFONE, FOR_ENDERECO) VALUES (@CNPJ,@NOME,@RAMO, @TELEFONE," +
                " @ENDERECO)";

            DataBaseSqlServerService dataBase = new DataBaseSqlServerService();

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

        
    }
}
