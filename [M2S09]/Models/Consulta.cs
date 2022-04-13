using System.ComponentModel.DataAnnotations;

namespace ClinicaVeterinaria.Models
{
    public class Consulta
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Data da Consulta")]
        public DateTime Data { get; set; }

        [StringLength(maximumLength: 500)]
        public string Historico { get; set; }

        public Tratamento Tratamento { get; set; }

        public Veterinario Veterinario { get; set; }
    }
}
