using System;
using System.Collections.Generic;

namespace Bank.API.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            ContaCorrentes = new HashSet<ContaCorrente>();
        }

        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string Sobrenome { get; set; } = null!;
        public DateTime DataNascimento { get; set; }
        public bool Ativo { get; set; }

        public virtual ICollection<ContaCorrente> ContaCorrentes { get; set; }
    }
}
