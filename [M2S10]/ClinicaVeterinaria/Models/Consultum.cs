using System;
using System.Collections.Generic;

namespace ClinicaVeterinaria.Models
{
    public partial class Consultum
    {
        public Consultum()
        {
            Exames = new HashSet<Exame>();
        }

        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string? Historico { get; set; }
        public int IdTratamento { get; set; }
        public int IdVeterinario { get; set; }

        public virtual Tratamento IdTratamentoNavigation { get; set; } = null!;
        public virtual Veterinario IdVeterinarioNavigation { get; set; } = null!;
        public virtual ICollection<Exame> Exames { get; set; }
    }
}
