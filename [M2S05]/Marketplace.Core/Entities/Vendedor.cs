namespace Marketplace.Core.Entities
{
    public abstract class Vendedor : Usuario
    {
        public string? Endereco { get; set; }
        public List<string>? Produtos { get; set; }

        public Vendedor(string nome, string email, string senha) : base(nome, email, senha) { }
    }
}
