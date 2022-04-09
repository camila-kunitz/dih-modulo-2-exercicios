namespace LocadoraVeiculos.Core.Entities
{
    public class Caminhao : Veiculo
    {
        public int CapacidadeCarga { get; set; }

        public Caminhao(string modelo, string marca, string placa, int quilometragem, int capacidadeCarga) : base(modelo, marca, placa, quilometragem)
        {
            CapacidadeCarga = capacidadeCarga;
        }
        
        public override void Andar()
        {
            Console.WriteLine("Andando devagar");
        }
    }
}
