using System;
using System.Globalization;

namespace ex3 {
    class Program {
        static void Main(string[] args) {

            Aluno aluno;
            aluno = new Aluno();

            aluno.nome = Console.ReadLine();
            aluno.nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(aluno);

            Console.ReadLine();

        }
    }
}
