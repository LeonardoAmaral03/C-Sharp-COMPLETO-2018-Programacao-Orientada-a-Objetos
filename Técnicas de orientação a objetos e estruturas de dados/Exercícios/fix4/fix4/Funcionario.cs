using System;
using System.Globalization;

namespace fix4 {
    class Funcionario {

        public string Cpf { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Funcionario(string cpf, string nome, double salario) {
            Cpf = cpf;
            Nome = nome;
            Salario = salario;
        }

        public void AumentoSalario(double porcentagem) {
            Salario += Salario * (porcentagem / 100);
        }

        public override string ToString() {
            return Cpf + ", " + Nome + ", " + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
