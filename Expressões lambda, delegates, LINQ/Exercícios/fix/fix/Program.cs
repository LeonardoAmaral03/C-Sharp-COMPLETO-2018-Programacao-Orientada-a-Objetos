using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;
using fix.Entities;

namespace fix {
    class Program {
        static void Main(string[] args) {

            List<Employee> employees = new List<Employee>();

            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            Console.Write("Enter salary: ");
            double referenceSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            using (StreamReader sr = File.OpenText(path)) {
                while (!sr.EndOfStream) {
                    string[] fields = sr.ReadLine().Split(',');

                    string name = fields[0];
                    string email = fields[1];
                    double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);

                    employees.Add(new Employee(name, email, salary));
                }
            }

            Console.WriteLine("Email of people whose salary is more than " + referenceSalary.ToString("F2", CultureInfo.InvariantCulture) + ":");
            var emails = employees.Where(p => p.Salary > referenceSalary).OrderBy(p => p.Email).Select(p => p.Email);

            foreach (string email in emails) {
                Console.WriteLine(email);
            }

            Console.Write("Sum of salary of people whose name starts with 'M': ");

            var salarySum = employees.Where(p => p.Name[0] == 'M').Select(p => p.Salary).DefaultIfEmpty(0.0).Sum();

            Console.WriteLine(salarySum.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
