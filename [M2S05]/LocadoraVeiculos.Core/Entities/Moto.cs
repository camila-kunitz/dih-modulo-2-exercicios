namespace LocadoraVeiculos.Core.Entities
{
    public class Moto : Veiculo
    {
        public Moto(string modelo, string marca, string placa, int quilometragem) : base(modelo, marca, placa, quilometragem) { }
            
        public override void Andar()
        {
            Console.WriteLine("Andando muito rápido");
        }
    }
}
