using System;
using System.Collections.Generic;

namespace ClinicaVeterinaria.Models
{
    public partial class Animal
    {
        public Animal()
        {
            Tratamentos = new HashSet<Tratamento>();
        }

        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public int Idade { get; set; }
        public string Sexo { get; set; } = null!;
        public int IdEspecie { get; set; }
        public int IdCliente { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; } = null!;
        public virtual Especie IdEspecieNavigation { get; set; } = null!;
        public virtual ICollection<Tratamento> Tratamentos { get; set; }
    }
}
