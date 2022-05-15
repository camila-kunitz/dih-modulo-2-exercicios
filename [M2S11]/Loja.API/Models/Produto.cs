using System;
using System.Collections.Generic;

namespace Loja.API.Models
{
    public partial class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string Descricao { get; set; } = null!;
        public decimal Preco { get; set; }
        public string Status { get; set; } = null!;
        public int IdFabricante { get; set; }

        public virtual Fabricante IdFabricanteNavigation { get; set; } = null!;
    }
}
