using System;

namespace curso {
    class Triangulo {

        public double a, b, c;

        public double area() {
            double p = (a + b + c) / 2.0;

            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

    }
}
