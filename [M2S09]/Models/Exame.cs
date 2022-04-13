using System.ComponentModel.DataAnnotations;

namespace ClinicaVeterinaria.Models
{
    public class Exame
    {
        [Key]
        public int Id { get; set; }

        [StringLength(maximumLength: 200)]
        public string Descricao { get; set; }

        public Consulta Consulta { get; set; }
    }
}
