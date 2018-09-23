namespace aula10 {
    class Conta {

        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }
        public double LimiteDeSaque { get; set; }

        public Conta(int numero, string titular, double limiteDeSaque) {
            Numero = numero;
            Titular = titular;
            LimiteDeSaque = limiteDeSaque;
            Saldo = 0.0;
        }

        public void Depositar(double valor) {
            Saldo += valor;
        }

        public void Sacar(double valor) {
            if (Saldo < valor) {
                throw new OperacaoException("Não há saldo suficiente! Saque cancelado.");
            }
            if (valor > LimiteDeSaque) {
                throw new OperacaoException("Valor de saque é superior ao limite da conta! Saque cancelado.");
            }
            Saldo -= valor;
        }
    }
}
