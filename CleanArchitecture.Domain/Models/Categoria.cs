namespace CleanArchitecture.Domain.Models
{
    public class Categoria
    {
        #region Properties
        public long IdCategoria { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }
        #endregion


        #region Navigation Properties
        //1 Categoria, varios produtos
        public List<Produto> Produtos { get; set; }
        #endregion
    }
}
