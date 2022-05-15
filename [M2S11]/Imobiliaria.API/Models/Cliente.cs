using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Imobiliaria.API.Models
{
    public class Cliente
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("nome")]
        public string Nome { get; set; }
        [Column("sobrenome")]
        public string Sobrenome { get; set; }
        [Column("dataNascimento")]
        public DateTime DataNascimento { get; set; }
        [Column("status")]
        public string Status { get; set; }
        public int ImovelId { get; set; }
        public Imovel Imovel { get; set; }
    }
}
