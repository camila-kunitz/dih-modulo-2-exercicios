using System.ComponentModel.DataAnnotations;

namespace ClinicaVeterinaria.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome precisa ser informado.")]
        [StringLength(maximumLength: 50, MinimumLength = 3, ErrorMessage = "O campo Nome precisa ter entre 3 e 20 caracteres.")]
        public string Nome { get; set; }

        [StringLength(maximumLength: 150)]
        public string Endereco { get; set; }

        [StringLength(maximumLength: 100)]
        public string Bairro { get; set; }

        public string CEP { get; set; }

        [StringLength(maximumLength: 30)]
        public string Cidade { get; set; }

        [StringLength(maximumLength: 2, MinimumLength = 2)]
        public string Estado { get; set; }

        [Required(ErrorMessage = "O campo Telefone precisa ser informado.")]
        public string Telefone { get; set; }
    }
}
