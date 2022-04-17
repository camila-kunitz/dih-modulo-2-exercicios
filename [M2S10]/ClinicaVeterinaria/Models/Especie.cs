using System;
using System.Collections.Generic;

namespace ClinicaVeterinaria.Models
{
    public partial class Especie
    {
        public Especie()
        {
            Animals = new HashSet<Animal>();
        }

        public int Id { get; set; }
        public string? Descricao { get; set; }

        public virtual ICollection<Animal> Animals { get; set; }
    }
}
