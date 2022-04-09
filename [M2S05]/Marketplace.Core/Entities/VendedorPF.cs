namespace Marketplace.Core.Entities
{
    public class VendedorPF : Vendedor
    {
        public string CPF { get; set; }

        public VendedorPF(string nome, string email, string senha, string cpf) : base(nome, email, senha) 
        {
            CPF = cpf;
        }
    }
}
