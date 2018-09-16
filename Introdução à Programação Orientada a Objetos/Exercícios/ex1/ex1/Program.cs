using System;
using System.Globalization;

namespace ex1 {
    class Program {
        static void Main(string[] args) {

            Retangulo ret;
            ret = new Retangulo();

            ret.largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ret.altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(ret);

            Console.ReadLine();
        }
    }
}
