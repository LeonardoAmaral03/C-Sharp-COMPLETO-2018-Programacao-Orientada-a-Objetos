using System;
using System.Globalization;

namespace curso {
    class Tela {

        public static Retangulo LerRetangulo() {
            Console.Write("Largura: ");
            double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Altura: ");
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            return new Retangulo(largura, altura, "preta");
        }

        public static Triangulo LerTriangulo() {
            Console.Write("Lado a: ");
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Lado b: ");
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Lado c: ");
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            return new Triangulo(a, b, c, "vermelha");
        }

    }
}
