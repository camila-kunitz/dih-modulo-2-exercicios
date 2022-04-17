using System;
using System.Collections.Generic;

namespace ClinicaVeterinaria.Models
{
    public partial class Veterinario
    {
        public Veterinario()
        {
            Consulta = new HashSet<Consultum>();
        }

        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string? Endereco { get; set; }
        public string Telefone { get; set; } = null!;

        public virtual ICollection<Consultum> Consulta { get; set; }
    }
}
