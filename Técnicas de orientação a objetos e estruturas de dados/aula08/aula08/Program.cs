using System;

namespace curso {
    class Program {
        static void Main(string[] args) {

            int X, Y, Z, resultado;

            X = int.Parse(Console.ReadLine());
            Y = int.Parse(Console.ReadLine());
            Z = int.Parse(Console.ReadLine());

            resultado = Util.MenorDentreTres(X, Y, Z); // Método estático

            Console.WriteLine("MENOR = " + resultado);

            Console.ReadLine();
        }
    }
}
