namespace Veiculos.API.Models
{
    public class Veiculo
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public decimal Preco { get; set; }
        public string Motor { get; set; }
        public decimal Quilometragem { get; set; }

    }
}
