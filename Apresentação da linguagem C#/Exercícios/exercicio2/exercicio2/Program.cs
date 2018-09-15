using System;
using System.Globalization;

namespace exercicio2 {
    class Program {
        static void Main(string[] args) {

            double n1, n2, n3, nFinal;

            string[] vet = Console.ReadLine().Split(' ');

            n1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            n2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
            n3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            nFinal = n1 + n2 + n3;

            if(nFinal < 60.00) {
                Console.WriteLine(nFinal.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("DEPENDENCIA");
            }
            else {
                Console.WriteLine(nFinal.ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.ReadLine();

        }
    }
}
