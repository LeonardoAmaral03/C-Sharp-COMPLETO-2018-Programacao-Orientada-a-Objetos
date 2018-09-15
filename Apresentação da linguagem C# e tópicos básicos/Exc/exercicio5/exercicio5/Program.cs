using System;
using System.Globalization;

namespace exercicio5 {
    class Program {
        static void Main(string[] args) {

            double d1, d2, d3;

            string[] vet = Console.ReadLine().Split(' ');

            d1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            d2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
            d3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            if (d1 > d2) {
                if (d1 > d3) {
                    Console.WriteLine(d1.ToString("F2", CultureInfo.InvariantCulture));
                }
                else {
                    Console.WriteLine(d3.ToString("F2", CultureInfo.InvariantCulture));
                }
            }
            else {
                if (d2 > d3) {
                    Console.WriteLine(d2.ToString("F2", CultureInfo.InvariantCulture));
                }
                else {
                    Console.WriteLine(d3.ToString("F2", CultureInfo.InvariantCulture));
                }
            }

            Console.ReadLine();

        }
    }
}
