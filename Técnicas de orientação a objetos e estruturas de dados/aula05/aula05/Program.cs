using System;
using System.Collections.Generic;

namespace aula05 {
    class Program {
        static void Main(string[] args) {

            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();

            A.Add(3);
            A.Add(5);
            A.Add(8);
            A.Add(9);

            B.Add(3);
            B.Add(4);
            B.Add(5);

            //B.Remove(4);

            //Diferença entre conjuntos (A - B)
            //A.ExceptWith(B);

            //União entre conjuntos (A u B)
            //A.UnionWith(B);

            //Intersecção entre conjuntos (A ∩ B)
            A.IntersectWith(B);

            foreach (int x in A) {
                Console.WriteLine(x);
            }

            /*
            Console.WriteLine("Digite um valor inteiro: ");
            int N = int.Parse(Console.ReadLine());

            if (B.Contains(N)) {
                Console.WriteLine(N + " pertence ao conjunto B");
            }
            else {
                Console.WriteLine(N + " não pertence ao conjunto B");
            }
            */

            Console.ReadLine();
        }
    }
}
