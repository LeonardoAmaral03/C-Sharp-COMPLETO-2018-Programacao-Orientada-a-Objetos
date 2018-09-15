using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio11 {
    class Program {
        static void Main(string[] args) {

            int V, CA;

            V = int.Parse(Console.ReadLine());
            CA = int.Parse(Console.ReadLine());

            while (CA != 0) {

                V += CA;

                if (V > 100) {
                    V = 100;
                    Console.WriteLine(V);
                }
                else {
                    if (V < 0) {
                        V = 0;
                        Console.WriteLine(V);
                    }
                    else {
                        Console.WriteLine(V);
                    }
                }

                CA = int.Parse(Console.ReadLine());
            }

            Console.ReadLine();

        }
    }
}
