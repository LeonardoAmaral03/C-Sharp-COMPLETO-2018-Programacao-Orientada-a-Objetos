using System;
using System.Collections.Generic;
using System.Linq;
using course7.Entities;

namespace course7 {
    class Program {
        static void Main(string[] args) {

            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            // Função Select pega uma coleção e transforma essa coleção em outra

            List<string> result = list.Select(p => p.Name.ToUpper()).ToList(); // expressão lambda inline

            // Com função lambda
            //Func<Product, string> func = p => p.Name.ToUpper(); // ou
            //Func<Product, string> func = p => { return p.Name.ToUpper(); }; // com {} expressão lambda entende como comando, por isso deve se ter o return
            //List<string> result = list.Select(func).ToList();

            // delegate que faz referencia a uma função que recebe um Product e retorna uma string
            //Func<Product, string> func = NameUpper;
            //List<string> result = list.Select(func).ToList();

            //List<string> result = list.Select(NameUpper).ToList();

            foreach (string s in result) {
                Console.WriteLine(s);
            }

        }

        static string NameUpper(Product p) {
            return p.Name.ToUpper();
        }

    }
}
