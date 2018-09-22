using System;
using System.Collections.Generic;
using System.Globalization;

namespace curso {
    class Program {
        static void Main(string[] args) {

            List<Figura> lista = new List<Figura>();

            Console.Write("Quantas figuras você vai digitar? ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++) {
                Console.Write("Figura " + i + " - triângulo ou retângulo (t/r)? ");
                char ch = char.Parse(Console.ReadLine());

                if (ch == 'r') {
                    Figura f = Tela.LerRetangulo();
                    lista.Add(f);
                }
                else {
                    Figura f = Tela.LerTriangulo();
                    lista.Add(f);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Áreas das figuras: ");

            for (int i = 0; i < N; i++) {
                Console.WriteLine("Figura " + (i + 1) + "(" + lista[i].Cor + "): " + lista[i].Area().ToString("F1", CultureInfo.InvariantCulture));
            }

            Console.ReadLine();
        }
    }
}
