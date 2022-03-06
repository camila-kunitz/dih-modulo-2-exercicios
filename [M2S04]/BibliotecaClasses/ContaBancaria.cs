namespace BibliotecaClasses
{
    public class ContaBancaria
    {
        private int contaNumero;
        private int contaDigito;
        private string nomeTitular;
        private string agencia;
        private string endereco;
        private decimal saldo;

        public ContaBancaria(int contaNumero, int contaDigito, string nomeTitular,
                        string agencia, string endereco, decimal saldo)
        {
            this.contaNumero = contaNumero;
            this.contaDigito = contaDigito;
            this.nomeTitular = nomeTitular;
            this.agencia = agencia;
            this.endereco = endereco;
            this.saldo = saldo;
        }


        public int ContaNumero
        {
            get { return contaNumero; }
        }
        public int ContaDigito
        {
            get { return contaDigito; }
        }
        public string NomeTitular
        {
            get { return nomeTitular; }
        }
        public string Agencia
        {
            get { return agencia; }
        }
        public string Endereco
        {
            get { return endereco; }
        }
        public decimal Saldo
        {
            get { return saldo; }
        }


    }
}
