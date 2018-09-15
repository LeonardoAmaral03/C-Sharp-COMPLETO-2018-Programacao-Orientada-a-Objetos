using System;
using System.Globalization;

namespace exercicio4 {
    class Program {
        static void Main(string[] args) {

            double valGlicose;

            valGlicose = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (valGlicose <= 100.0) {
                Console.WriteLine("Normal");
            }
            else {
                if (valGlicose > 100 && valGlicose <= 140) {
                    Console.WriteLine("Elevado");
                }
                else {
                    Console.WriteLine("Diabetes");
                }
            }

            Console.ReadLine();

        }
    }
}
