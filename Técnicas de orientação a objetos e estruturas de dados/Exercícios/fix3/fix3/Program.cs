using System;

namespace fix3 {
    class Program {
        static void Main(string[] args) {

            int M, N, X, l = 0, c = 0;
            int[,] mat;

            string[] MN = Console.ReadLine().Split(' ');

            M = int.Parse(MN[0]);
            N = int.Parse(MN[1]);

            mat = new int[M, N];

            for (int i = 0; i < M; i++) {
                string[] linha = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    mat[i, j] = int.Parse(linha[j]);
                }
            }

            X = int.Parse(Console.ReadLine());

            for (int i = 0; i < M; i++) {
                for (int j = 0; j < N; j++) {
                    if (mat[i, j] == X) {
                        l = i;
                        c = j;
                    }
                }
            }

            if (c != 0) {
                Console.WriteLine("ESQUERDA: " + mat[l, c - 1]);
            }

            if (c != N-1) {
                Console.WriteLine("DIREITA: " + mat[l, c + 1]);
            }

            if (l != 0) {
                Console.WriteLine("ACIMA: " + mat[l - 1, c]);
            }

            if (l != M - 1) {
                Console.WriteLine("ABAIXO: " + mat[l + 1, c]);
            }

            Console.ReadLine();
        }
    }
}
