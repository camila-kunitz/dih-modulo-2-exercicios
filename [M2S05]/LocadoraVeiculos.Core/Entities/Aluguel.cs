namespace LocadoraVeiculos.Core.Entities
{
    public class Aluguel
    {
        public int CodigoLocacao { get; set; }
        public Veiculo VeiculoLocado { get; set; }
        public Cliente Cliente { get; set; }

        public Aluguel(int codigoLocacao, Veiculo veiculoLocado, Cliente cliente)
        {
            CodigoLocacao = codigoLocacao;
            VeiculoLocado = veiculoLocado;
            Cliente = cliente;
        }
    }
}
