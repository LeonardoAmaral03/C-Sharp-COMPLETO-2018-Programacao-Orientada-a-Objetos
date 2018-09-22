using System;
using System.Collections.Generic;

namespace fix5 {
    class Program {
        static void Main(string[] args) {

            int qtd, aluno;
            char[] cursos = new char[] { 'A', 'B', 'C' };
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();

            for (int i = 0; i < 3; i++) {
                Console.Write("O curso " + cursos[i] + " possui quantos alunos? ");
                qtd = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite os códigos dos alunos do curso " + cursos[i] + ":");

                for (int j = 0; j < qtd; j++) {
                    aluno = int.Parse(Console.ReadLine());
                    if (i == 0) {
                        A.Add(aluno);
                    }
                    else if (i == 1) {
                        B.Add(aluno);
                    }
                    else {
                        C.Add(aluno);
                    }
                }
            }

            B.UnionWith(C);
            A.UnionWith(B);

            Console.Write("Total de alunos: " + A.Count);

            Console.ReadLine();
        }
    }
}
