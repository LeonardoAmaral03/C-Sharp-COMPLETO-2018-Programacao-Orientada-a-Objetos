using System;
using System.Globalization;

namespace curso {
    class Program {
        static void Main(string[] args) {

            Produto P;
            P = new Produto();

            Console.WriteLine("Digite os dados do produto:");
            Console.Write("Nome: ");
            P.nome = Console.ReadLine();
            Console.Write("Preço: ");
            P.preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade em estoque: ");
            P.quantidadeEmEstoque = int.Parse(Console.ReadLine());

            Console.WriteLine("Você digitou: " + P.nome + ", " + 
                P.preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + P.quantidadeEmEstoque);

            Console.ReadLine();

        }
    }
}
