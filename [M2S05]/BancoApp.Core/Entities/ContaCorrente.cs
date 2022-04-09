namespace BancoApp.Core.Entities
{
    public class ContaCorrente : ContaBancaria
    {
        public double ChequeEspecial { get; }

        public ContaCorrente(int numero, int agencia, Cliente cliente, double saldo, double rendaMensal, double chequeEspecial) : base(numero, agencia, cliente, saldo, rendaMensal)
        {
            ChequeEspecial = chequeEspecial;
        }
    }
}
