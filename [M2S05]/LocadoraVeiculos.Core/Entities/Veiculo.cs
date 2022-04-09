namespace LocadoraVeiculos.Core.Entities
{
    public abstract class Veiculo
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Placa { get; set; }
        public int Quilometragem { get; set; }

        public Veiculo(string modelo, string marca, string placa, int quilometragem)
        {
            Modelo = modelo;
            Marca = marca;
            Placa = placa;
            Quilometragem = quilometragem;
        }

        public abstract void Andar();
    }
}
