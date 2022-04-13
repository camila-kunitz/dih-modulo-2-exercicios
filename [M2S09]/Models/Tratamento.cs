using System.ComponentModel.DataAnnotations;

namespace ClinicaVeterinaria.Models
{
    public class Tratamento
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Data Inicial do Tratamento")]
        public DateTime DataInicial { get; set; }

        [Display(Name = "Data Final do Tratamento")]
        public DateTime DataFinal { get; set; }

        public Animal Animal { get; set; }
    }
}
