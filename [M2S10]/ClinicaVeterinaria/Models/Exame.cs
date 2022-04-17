using System;
using System.Collections.Generic;

namespace ClinicaVeterinaria.Models
{
    public partial class Exame
    {
        public int Id { get; set; }
        public string? Descricao { get; set; }
        public int IdConsulta { get; set; }

        public virtual Consultum IdConsultaNavigation { get; set; } = null!;
    }
}
