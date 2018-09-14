using System;
using System.Globalization;

namespace testes_while {
    class Program {
        static void Main(string[] args) {
            int idade, soma, cont;
            double media;

            soma = 0;
            cont = 0;

            idade = int.Parse(Console.ReadLine());

            while (idade >= 0) {
                soma += idade;
                cont++;

                idade = int.Parse(Console.ReadLine());
            }

            if (cont == 0) {
                Console.WriteLine("IMPOSSIVEL CALCULAR!");
            }
            else {
                media = (double)soma / cont;

                Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.ReadLine();
        }
    }
}
