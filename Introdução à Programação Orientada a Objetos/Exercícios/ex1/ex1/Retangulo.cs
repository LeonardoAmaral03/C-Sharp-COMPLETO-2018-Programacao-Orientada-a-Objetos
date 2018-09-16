using System;
using System.Globalization;

namespace ex1 {
    class Retangulo {

        public double largura, altura;

        public double Area() {
            return largura * altura;
        }

        public double Perimetro() {
            return largura * 2 + altura * 2;
        }

        public double Diagonal() {
            return Math.Sqrt((Math.Pow(largura, 2) + Math.Pow(altura, 2)));
        }

        public override string ToString() {
            return "AREA = " + Area().ToString("F2", CultureInfo.InvariantCulture) + "\n"
                + "PERIMETRO = " + Perimetro().ToString("F2", CultureInfo.InvariantCulture) + "\n"
                + "DIAGONAL = " + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
