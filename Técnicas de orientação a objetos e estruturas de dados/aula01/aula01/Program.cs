using System;
using System.Globalization;

namespace curso {
    class Program {
        static void Main(string[] args) {
               
            // Classes são tipos referência
            //Produto P1, P2;
            //P1 = new Produto("TV", 1000.00, 0);
            //P2 = P1;
            //P2.RealizarEntrada(5);
            //Console.WriteLine(P1.QuantidadeEmEstoque);

            // Struct é um tipo valor, logo não precisa ser instanciado
            Ponto A, B;

            A.x = 10;
            A.y = 20;

            B = A;

            B.y = 30;

            Console.WriteLine(A);

            Console.ReadLine();

        }
    }
}
