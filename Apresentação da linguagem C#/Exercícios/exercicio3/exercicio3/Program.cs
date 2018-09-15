using System;

namespace exercicio3 {
    class Program {
        static void Main(string[] args) {

            int largFoto, altFoto, largPortRetrato, altPortRetrato;

            string[] vetFoto = Console.ReadLine().Split(' ');
            largFoto = int.Parse(vetFoto[0]);
            altFoto = int.Parse(vetFoto[1]);

            string[] vetPortRetrato = Console.ReadLine().Split(' ');
            largPortRetrato = int.Parse(vetPortRetrato[0]);
            altPortRetrato = int.Parse(vetPortRetrato[1]);

            if (largFoto <= largPortRetrato && altFoto <= altPortRetrato) {
                Console.WriteLine("SIM");
            }
            else {
                if (largFoto <= altPortRetrato && altFoto <= largPortRetrato) {
                    Console.WriteLine("SIM");
                }
                else {
                    Console.WriteLine("NAO");
                }
            }

            Console.ReadLine();
        }
    }
}
