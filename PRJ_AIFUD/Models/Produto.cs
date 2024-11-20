namespace ProjetoPOOB.Models
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public string Descricao { get; set; }
        public decimal PrecoVenda { get; set; }
        public int EstoqueAtual { get; set; }
        public string UnMedida { get; set; }
        public int Restaurante { get; set; }
    }
}
