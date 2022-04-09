namespace LocadoraVeiculos.Core.Entities
{
    public class Carro : Veiculo
    {
        public int Assentos { get; set; }
        public bool IsAutomatico { get; set; }

        public Carro(string modelo, string marca, string placa, int quilometragem, int assentos, bool isAutomatico) : base(modelo, marca, placa, quilometragem)
        {
            Assentos = assentos;
            IsAutomatico = isAutomatico;
        }
        
        public override void Andar()
        {
            Console.WriteLine("Andando rápido");
        }
    }
}
