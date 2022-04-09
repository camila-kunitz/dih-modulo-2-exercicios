namespace BancoApp.Core.Entities
{
    public abstract class ContaBancaria
    {
        public int Numero { get; set; }
        public int Agencia { get; set; }
        public Cliente Cliente { get; set; }
        public double Saldo { get; set; }
        public double RendaMensal { get; set; }

        public ContaBancaria(int numero, int agencia, Cliente cliente, double saldo, double rendaMensal)
        {
            Numero = numero;
            Agencia = agencia;
            Cliente = cliente;
            Saldo = saldo;
            RendaMensal = rendaMensal;
        }
    }
}
