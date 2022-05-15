using Imobiliaria.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Imobiliaria.API.Context
{
    public class ImobiliariaContext : DbContext
    {
        public ImobiliariaContext(DbContextOptions<ImobiliariaContext> options) : base(options) { }

        public DbSet<Imovel> Imoveis { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
    }
}
