using System;
using System.Collections.Generic;

namespace ClinicaVeterinaria.Models
{
    public partial class Tratamento
    {
        public Tratamento()
        {
            Consulta = new HashSet<Consultum>();
        }

        public int Id { get; set; }
        public DateTime? DataInicial { get; set; }
        public DateTime? DataFinal { get; set; }
        public int IdAnimal { get; set; }

        public virtual Animal IdAnimalNavigation { get; set; } = null!;
        public virtual ICollection<Consultum> Consulta { get; set; }
    }
}
