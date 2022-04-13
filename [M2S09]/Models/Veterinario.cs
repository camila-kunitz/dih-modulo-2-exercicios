using System.ComponentModel.DataAnnotations;

namespace ClinicaVeterinaria.Models
{
    public class Veterinario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome precisa ser informado.")]
        [StringLength(maximumLength: 50, MinimumLength = 3, ErrorMessage = "O campo Nome precisa ter entre 3 e 20 caracteres.")]
        public string Nome { get; set; }

        [StringLength(maximumLength: 150)]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "O campo telefone precisa ser informado.")]
        public string Telefone { get; set; }
    }
}
