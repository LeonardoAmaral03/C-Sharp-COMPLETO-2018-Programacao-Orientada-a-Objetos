using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fix2 {
    class Program {
        static void Main(string[] args) {

            int alugueis, quarto;
            string nome, email;
            Aluguel[] vetQuartos = new Aluguel[10];

            Console.Write("Quantos aluguéis serão registrados? ");
            alugueis = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int aluguel = 1; aluguel <= alugueis; aluguel++) {
                Console.WriteLine("Dados do " + aluguel + "° aluguel:");

                Console.Write("Nome: ");
                nome = Console.ReadLine();
                Console.Write("Email: ");
                email = Console.ReadLine();
                Console.Write("Quarto: ");
                quarto = int.Parse(Console.ReadLine());

                vetQuartos[quarto] = new Aluguel(nome, email);

                Console.WriteLine();
            }

            Console.WriteLine("Quartos ocupados:");

            for (int i = 0; i < 10; i++) {
                if (vetQuartos[i] != null) {
                    Console.WriteLine(i + ": " + vetQuartos[i]);
                }
            }

            Console.ReadLine();
        }
    }
}
