using System;
using System.Collections.Generic;

namespace Bank.API.Models
{
    public partial class ContaCorrente
    {
        public int Id { get; set; }
        public string Descricao { get; set; } = null!;
        public decimal Rendimento { get; set; }
        public string Codigo { get; set; } = null!;
        public bool Ativo { get; set; }
        public int IdCliente { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; } = null!;
    }
}
