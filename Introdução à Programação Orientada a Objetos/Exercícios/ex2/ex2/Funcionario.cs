using System.Globalization;

namespace ex2 {
    class Funcionario {

        public string nome;
        public double salarioBruto, desconto;

        public double SalarioLiquido() {
            return salarioBruto - desconto;
        }

        public void AumentarSalario(double porcentagem) {
            salarioBruto += salarioBruto * porcentagem / 100;
        }

        public override string ToString() {
            return "Dados do funcionário: " 
                + nome
                + ", R$ "
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
