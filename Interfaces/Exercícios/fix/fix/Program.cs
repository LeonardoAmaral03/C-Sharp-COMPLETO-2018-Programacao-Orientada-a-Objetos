using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using fix.Entities;
using fix.Services;

namespace fix {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int numberInstallments = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, value);

            ContractProcessingService contractProcessingService = new ContractProcessingService(numberInstallments, new PaypalQuotaService());

            contractProcessingService.ProcessContract(contract);

            Console.WriteLine("Installments:");
            Console.WriteLine(contract);
        }
    }
}
