using System;
using System.Globalization;

namespace exercicio10 {
    class Program {
        static void Main(string[] args) {

            int N;
            double n1, n2, n3, nFinal;
            string[] vet;

            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++) {
                vet = Console.ReadLine().Split(' ');

                n1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
                n2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
                n3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

                nFinal = n1 + n2 + n3;

                Console.WriteLine(nFinal.ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.ReadLine();
        }
    }
}
