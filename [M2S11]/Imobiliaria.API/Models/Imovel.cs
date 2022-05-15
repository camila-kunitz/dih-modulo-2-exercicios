using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Imobiliaria.API.Models
{
    public class Imovel
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("titulo")]
        public string Titulo { get; set; }
        [Column("descricaoCurta")]
        public string DescricaoCurta { get; set; }
        [Column("descricaoLonga")]
        public string DescricaoLonga { get; set; }
        [Column("tipo")]
        public Tipo Tipo { get; set; }
        [Column("valor")]
        public double Valor { get; set; }
    }
}
