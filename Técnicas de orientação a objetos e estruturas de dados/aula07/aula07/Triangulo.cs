using System;

namespace curso {
    class Triangulo : Figura {

        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangulo(double a, double b, double c, string cor) : base(cor) {
            A = a;
            B = b;
            C = c;
        }

        public override double Area() {
            double p = (A + B + C) / 2.0;

            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public override double Perimetro() {
            return A + B + C;
        }

    }
}
