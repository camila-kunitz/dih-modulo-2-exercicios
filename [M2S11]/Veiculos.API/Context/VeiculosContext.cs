using Microsoft.EntityFrameworkCore;
using Veiculos.API.Models;

namespace Veiculos.API.Context
{
    public class VeiculosContext : DbContext
    {
        public VeiculosContext(DbContextOptions<VeiculosContext> options) : base(options) { }

        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
    }
}
