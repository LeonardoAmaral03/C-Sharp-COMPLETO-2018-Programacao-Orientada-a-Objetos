using System.Globalization;

namespace fix1 {
    class ContaBancaria {

        public string NumeroConta { get; private set; }
        public string NomeTitular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(string numeroConta, string nomeTitular, double depositoInicial) {
            this.NumeroConta = numeroConta;
            this.NomeTitular = nomeTitular;
            this.Saldo = depositoInicial;
        }

        public ContaBancaria(string numeroConta, string nomeTitular) {
            this.NumeroConta = numeroConta;
            this.NomeTitular = nomeTitular;
            this.Saldo = 0;
        }

        public void Deposito(double deposito) {
            this.Saldo += deposito;
        }

        public void Saque(double saque) {
            this.Saldo -= (saque + 5.00);
        }

        public override string ToString() {
            return "Conta: "
                + this.NumeroConta
                + ", Titular: "
                + this.NomeTitular
                + ", Saldo: $ "
                + this.Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
