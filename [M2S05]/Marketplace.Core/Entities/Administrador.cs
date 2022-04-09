
namespace Marketplace.Core.Entities
{
    public class Administrador : Usuario
    {
        public List<string>? Permissoes { get; set; }  

        public Administrador(string nome, string email, string senha) : base(nome, email, senha) { }
    }
}
