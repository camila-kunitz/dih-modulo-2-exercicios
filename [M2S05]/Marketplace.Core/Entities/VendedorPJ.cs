namespace Marketplace.Core.Entities
{
    public class VendedorPJ : Vendedor
    {
        public string CNPJ { get; set; }

        public VendedorPJ(string nome, string email, string senha, string cnpj) : base(nome, email, senha)
        { 
            CNPJ = cnpj;
        }
    }
}
