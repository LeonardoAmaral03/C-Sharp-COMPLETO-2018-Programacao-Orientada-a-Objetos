using System;
using System.Globalization;

namespace curso {
    class Program {
        static void Main(string[] args) {

            Fornecedor f;
            Produto p;

            f = new Fornecedor("Lojas Ltda", "lojas@gmail.com", "4688-7645");

            p = new Produto("TV", 1000.00, f);

            Console.WriteLine(p);

            Console.ReadLine();

        }
    }
}
