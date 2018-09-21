using System;
using System.Globalization;
using System.Collections.Generic;

namespace fix4 {
    class Program {
        static void Main(string[] args) {

            int N, pos;
            string cpf, nome;
            double salario, porcentagem;
            List<Funcionario> listaFuncionarios = new List<Funcionario>();

            Console.Write("Quantos funcionários serão cadastrados? ");
            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++) {
                Console.WriteLine("Dados do " + i + " ° funcionário:");
                Console.Write("CPF: ");
                cpf = Console.ReadLine();
                Console.Write("Nome: ");
                nome = Console.ReadLine();
                Console.Write("Salario: ");
                salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                listaFuncionarios.Add(new Funcionario(cpf, nome, salario));

                Console.WriteLine();
            }

            Console.Write("Digite o CPF do funcionário que terá aumento: ");
            cpf = Console.ReadLine();

            pos = listaFuncionarios.FindIndex(x => x.Cpf == cpf);

            if (pos != -1) {
                Console.Write("Digite a porcentagem de aumento: ");
                porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                listaFuncionarios[pos].AumentoSalario(porcentagem);
            }
            else {
                Console.WriteLine("CPF INEXISTENTE");
            }

            Console.WriteLine();
            Console.WriteLine("Listagem atualizada de funcionários:");

            for (int i = 0; i < N; i++) {
                Console.WriteLine(listaFuncionarios[i]);
            }

            Console.ReadLine();
        }
    }
}
