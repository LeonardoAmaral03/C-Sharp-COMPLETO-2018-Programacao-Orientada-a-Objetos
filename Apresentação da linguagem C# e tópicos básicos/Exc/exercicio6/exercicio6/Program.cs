using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio6 {
    class Program {
        static void Main(string[] args) {

            int n1, n2, somaImpares;

            string[] vet = Console.ReadLine().Split(' ');

            n1 = int.Parse(vet[0]);
            n2 = int.Parse(vet[1]);

            somaImpares = 0;

            for (int i = n1; i <= n2; i++) {
                if (i % 2 != 0) {
                    somaImpares += i;
                }
            }

            Console.WriteLine(somaImpares);

            Console.ReadLine();
            
        }
    }
}
