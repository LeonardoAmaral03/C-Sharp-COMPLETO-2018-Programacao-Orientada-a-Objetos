using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using fix.Entidades;

namespace fix {
    class Program {
        static void Main(string[] args) {

            string caminhoOrigem = @"C:\Users\Leonardo\Documents\Leonardo\Git\C#\C# Completo 2018 - Programação Orientada a Objetos\Trabalhando com arquivos\Exercícios\origem\arquivo.csv";
            string caminhoDestino = @"C:\Users\Leonardo\Documents\Leonardo\Git\C#\C# Completo 2018 - Programação Orientada a Objetos\Trabalhando com arquivos\Exercícios\origem\";

            List<Produto> produtos = new List<Produto>();

            try {
                using (StreamReader sr = File.OpenText(caminhoOrigem)) {
                    while (!sr.EndOfStream) {
                        string[] vet = sr.ReadLine().Split(',');

                        string nome = vet[0];
                        double preco = double.Parse(vet[1], CultureInfo.InvariantCulture);
                        int quantidade = int.Parse(vet[2]);

                        Produto produto = new Produto(nome, preco, quantidade);

                        produtos.Add(produto);
                    }

                    Directory.CreateDirectory(caminhoDestino + @"\out");

                    using (StreamWriter sw = File.AppendText(caminhoDestino + @"\out\summary.csv")) {
                        foreach (Produto produto in produtos) {
                            sw.WriteLine(produto.Nome + "," + produto.ValorTotal().ToString("F2", CultureInfo.InvariantCulture));
                        }
                    }
                }
            }
            catch (IOException e) {
                Console.WriteLine("Um erro ocorreu");
                Console.WriteLine(e.Message);
            }
        }
    }
}
