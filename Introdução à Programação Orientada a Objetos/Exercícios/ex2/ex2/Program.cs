using System;
using System.Globalization;

namespace ex2 {
    class Program {
        static void Main(string[] args) {

            double porcentagem;
            Funcionario func;
            func = new Funcionario();

            Console.Write("Nome: ");
            func.nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            func.salarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Desconto: ");
            func.desconto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine(func);
            Console.WriteLine();

            Console.Write("Deseja aumentar o salário em qual porcentagem? ");
            porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            func.AumentarSalario(porcentagem);

            Console.WriteLine();
            Console.WriteLine(func);

            Console.ReadLine();

        }
    }
}
