using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using course.Entities;

namespace course {
    class Program {
        static void Main(string[] args) {

            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));

            //Referência simples de método como parâmetro
            // usando referência para a função (delegate)
            //list.Sort(compareProducts);

            //Referência de método atribuído a uma variável tipo delegate
            // variavel comp recebendo a referência para a função compareProducts
            //Comparison<Product> comp = compareProducts;
            //list.Sort(comp);

            //Expressão lambda atricuída a uma variável tipo delegate
            // utilizando expressão lambda (função anônima - não precisa declarar a função)
            //Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
            //list.Sort(comp);

            //Expressão lambda inline
            // utilizando expressão lambda diretamente no Sort()
            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

            foreach (Product p in list) {
                Console.WriteLine(p);
            }

        }

        // função com a assinatura casando com a do Comparison<T> na chamada do Sort(Comparison<T>)
        //static int compareProducts(Product p1, Product p2) {
        //    return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        //}

    }
}
