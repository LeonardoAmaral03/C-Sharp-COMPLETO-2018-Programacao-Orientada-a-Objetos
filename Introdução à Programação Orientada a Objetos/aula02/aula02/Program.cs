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
            //P = new Produto(nome, preco); Sobrecarga

            Console.WriteLine(P.Nome);

            Console.ReadLine();

        }
    }
}
