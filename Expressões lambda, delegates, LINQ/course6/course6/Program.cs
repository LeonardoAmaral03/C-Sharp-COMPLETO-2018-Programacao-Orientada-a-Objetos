using System;
using System.Collections.Generic;
using course6.Entities;

namespace course6 {
    class Program {
        static void Main(string[] args) {

            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            list.ForEach(p => { p.Price += p.Price * 0.1; }); // função lambda inline

            //Action<Product> act = p => { p.Price += p.Price * 0.1; }; // {} significa que não haverá retorno da função lambda (void)
            //list.ForEach(act);

            //Action<Product> act = UpdatePrice; // Criando um objeto do tipo delegate Action<>
            //list.ForEach(act);

            //list.ForEach(UpdatePrice);

            foreach (Product p in list) {
                Console.WriteLine(p);
            }

        }

        static void UpdatePrice(Product p) {
            p.Price += p.Price * 0.1;
        }

    }
}
