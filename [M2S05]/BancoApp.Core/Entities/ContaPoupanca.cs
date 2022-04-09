namespace BancoApp.Core.Entities
{
    public class ContaPoupanca : ContaBancaria
    {
        public double ValorPoupanca { get; set; }

        public ContaPoupanca(int numero, int agencia, Cliente cliente, double saldo, double rendaMensal, double valorPoupanca) : base(numero, agencia, cliente, saldo, rendaMensal)
        {
            ValorPoupanca = valorPoupanca;
        }
    }
}
