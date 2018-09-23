using System;
using System.Globalization;

namespace aula10 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Nome do titular: ");
            string titular = Console.ReadLine();
            Console.Write("Limite de saque: ");
            double limite = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Conta c = new Conta(numero, titular, limite);

            Console.WriteLine();
            Console.Write("Informe um valor para depósito: ");
            double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Depositar(valorDeposito);
            Console.WriteLine("Novo saldo = R$ " + c.Saldo.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();
            Console.Write("Informe um valor para saque: ");
            double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            try {
                c.Sacar(valorSaque);
                Console.WriteLine("Novo saldo = R$ " + c.Saldo.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (OperacaoException e) {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
