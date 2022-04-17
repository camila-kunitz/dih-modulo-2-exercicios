using System;
using System.Collections.Generic;

namespace ClinicaVeterinaria.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            Animals = new HashSet<Animal>();
        }

        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string? Endereco { get; set; }
        public string? Bairro { get; set; }
        public string? Cep { get; set; }
        public string? Cidade { get; set; }
        public string? Estado { get; set; }
        public string Telefone { get; set; } = null!;

        public virtual ICollection<Animal> Animals { get; set; }
    }
}
