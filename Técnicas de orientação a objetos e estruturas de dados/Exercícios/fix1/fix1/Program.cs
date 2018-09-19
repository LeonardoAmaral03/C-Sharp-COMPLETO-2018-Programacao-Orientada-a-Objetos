using System;
using System.Globalization;

namespace fix1 {
    class Program {
        static void Main(string[] args) {

            ContaBancaria conta;
            string numConta, nomeTitular;
            char resp;
            double depositoInicial, deposito, saque;

            Console.Write("Digite o número da conta: ");
            numConta = Console.ReadLine();
            Console.Write("Digite o nome do titular da conta: ");
            nomeTitular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            resp = char.Parse(Console.ReadLine());

            if (resp == 's') {
                Console.Write("Digite o valor do depósito inicial: ");
                depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                conta = new ContaBancaria(numConta, nomeTitular, depositoInicial);
            }
            else {
                conta = new ContaBancaria(numConta, nomeTitular);
            }

            Console.WriteLine();

            Console.WriteLine("Conta criada:");
            Console.WriteLine(conta);

            Console.WriteLine();

            Console.Write("Digite um valor para depósito: ");
            deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(deposito);

            Console.WriteLine("Conta atualizada:");
            Console.WriteLine(conta);

            Console.WriteLine();

            Console.Write("Digite um valor para saque: ");
            saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(saque);

            Console.WriteLine("Conta atualizada:");
            Console.WriteLine(conta);

            Console.ReadLine();

        }
    }
}
