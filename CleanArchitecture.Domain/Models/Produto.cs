namespace CleanArchitecture.Domain.Models
{
    public class Produto
    {
        public long MyProperty { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataCadastro { get; set; }

        #region Navigation Properties
        //1 produto para 1 categoria
        public Categoria Categoria { get; set; }
        #endregion
    }
}
