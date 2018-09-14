using System;
using System.Globalization;

namespace curso {
    class Program {
        static void Main(string[] args) {

            string x;
            int y;
            double z;
            char w;

            x = Console.ReadLine();
            y = int.Parse(Console.ReadLine());
            z = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            w = char.Parse(Console.ReadLine());

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(w);

            //Console.ReadLine();

            // Para ler vários dados na mesma linha

            string a;
            int b;
            double c;

            string[] vet = Console.ReadLine().Split(' ');

            a = vet[0];
            b = int.Parse(vet[1]);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            Console.ReadLine();
        }
    }
}