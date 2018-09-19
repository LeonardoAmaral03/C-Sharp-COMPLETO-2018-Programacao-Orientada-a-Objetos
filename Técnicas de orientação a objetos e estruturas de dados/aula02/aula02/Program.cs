using System;
using System.Globalization;

namespace curso {
    class Program {
        static void Main(string[] args) {

            // Vetor com tipo valor / struct (vetor de double)
            // Vetor com tipo referência / classe (vetor de Produto)
            // Votores precisam ser instanciados

            //double[] vet;
            Produto[] vet;
            double soma, media;
            int N;

            N = int.Parse(Console.ReadLine());
            //vet = new double[N];
            vet = new Produto[N];

            for (int i = 0; i < N; i++) {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vet[i] = new Produto(nome, preco);
            }

            soma = 0.0;

            for (int i = 0; i < N; i++) {
                //soma += vet[i];
                soma += vet[i].Preco;
            }

            media = soma / N;

            //Console.WriteLine("ALTURA MEDIA = " + media.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PREÇO MÉDIO = R$ " + media.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}
