using System;
using System.Globalization;

namespace exercicio9 {
    class Program {
        static void Main(string[] args) {

            double tempoTotal, tempoJogando, tempoRestante;
            int N;

            tempoTotal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            N = int.Parse(Console.ReadLine());

            tempoRestante = tempoTotal;

            for (int i = 0; i < N; i++) {
                tempoJogando = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                tempoRestante -= tempoJogando;

                if (tempoRestante < 0) {
                    Console.WriteLine("recarregar");
                }
                else {
                    Console.WriteLine(tempoRestante.ToString("F1", CultureInfo.InvariantCulture));
                }
            }

            Console.ReadLine();

        }
    }
}
