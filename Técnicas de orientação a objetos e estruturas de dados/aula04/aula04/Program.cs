using System;
using System.Collections.Generic;

namespace curso {
    class Program {
        static void Main(string[] args) {

            /*
            List<string> lista = new List<string>();
            lista.Add("João");
            lista.Add("Maria");
            lista.Add("Ana");
            lista.Add("José");
            //lista.Remove("Maria"); remove pelo objeto
            //lista.RemoveAt(0); remove pelo index
            int pos = lista.FindIndex(x => x == "Maria");
            Console.WriteLine("Posição da Maria = " + pos);
            for (int i = 0; i < lista.Count; i++) {
                Console.WriteLine(lista[i]);
            }
            */

            List<Produto> lista = new List<Produto>();

            lista.Add(new Produto("TV", 900.00));
            lista.Add(new Produto("Aspirador", 400.00));
            lista.Add(new Produto("Geladeira", 2000.00));

            //int pos = lista.FindIndex(x => x.Nome == "Aspirador");
            //int pos = lista.FindIndex(x => x.Preco > 1000.00); so encontra a primeira ocorrencia
            //int pos = lista.FindIndex(x => x.Preco < 1000.00);
            int pos = lista.FindIndex(x => x.Preco > 3000.00); // ira retornar -1 pois não encontra ninguem
            Console.WriteLine("Posição encontrada = " + pos);

            for (int i = 0; i < lista.Count; i++) {
                Console.WriteLine(lista[i]);
            }

            Console.ReadLine();
        }
    }
}
