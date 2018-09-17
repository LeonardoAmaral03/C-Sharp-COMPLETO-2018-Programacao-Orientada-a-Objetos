using System;
using System.Globalization;

namespace curso {
    class Program {
        static void Main(string[] args) {

            int qte, quantidadeEstoque;
            string nome;
            double preco;
            Produto P;

            Console.WriteLine("Digite os dados do produto:");
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Preço: ");
            preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade em estoque: ");
            quantidadeEstoque = int.Parse(Console.ReadLine());

            P = new Produto(nome, preco, quantidadeEstoque);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + P);

            Console.WriteLine();
            Console.Write("Digite a quantidade de produtos que entraram no estoque: ");
            qte = int.Parse(Console.ReadLine());
            P.RealizarEntrada(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + P);

            Console.WriteLine();
            Console.Write("Digite a quantidade de produtos que saíram do estoque: ");
            qte = int.Parse(Console.ReadLine());
            P.RealizarSaida(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + P);

            Console.ReadLine();

        }
    }
}
