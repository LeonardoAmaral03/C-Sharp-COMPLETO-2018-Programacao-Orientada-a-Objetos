using System;
using System.Globalization;

namespace ex3 {
    class Aluno {

        public string nome;
        public double nota1;
        public double nota2;
        public double nota3;

        public double NotaFinal() {
            return nota1 + nota2 + nota3;
        }

        public bool Aprovado() {
            if(NotaFinal() < 60.00) {
                return false;
            }
            else {
                return true;
            }
        }

        public double PontosFaltantes() {
            return 60.00 - NotaFinal();
        }

        public override string ToString() {
            string saida;

            saida = "NOTA FINAL = " + NotaFinal().ToString("F2", CultureInfo.InvariantCulture) + "\n";

            if (Aprovado()) {
                return saida
                    + "APROVADO";
            }
            else {
                return saida
                    + "REPROVADO" + "\n"
                    + "FALTARAM " + PontosFaltantes().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS";
            }
        }

    }
}
