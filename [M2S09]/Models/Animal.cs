using System.ComponentModel.DataAnnotations;

namespace ClinicaVeterinaria.Models
{
    public class Animal
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome do animal precisa ser informado.")]
        [StringLength(maximumLength: 50, MinimumLength = 3, ErrorMessage = "O campo Nome precisa ter entre 3 e 20 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Idade do animal precisa ser informado.")]
        [Range(0, 30, ErrorMessage = "O intervalo de Idade deve ser entre 0 e 30 anos")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "O campo Sexo do animal precisa ser informado.")]
        [RegularExpression("(M|F)", ErrorMessage = "Informe as siglas M ou F")]
        public string Sexo { get; set; }

        public Cliente Cliente { get; set; }

        public Especie Especie { get; set; }
    }
}
