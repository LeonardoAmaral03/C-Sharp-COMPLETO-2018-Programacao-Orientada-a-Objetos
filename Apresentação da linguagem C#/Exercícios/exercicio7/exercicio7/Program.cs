using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio7 {
    class Program {
        static void Main(string[] args) {

            int num;

            num = int.Parse(Console.ReadLine());

            while (num != 0) {

                Console.WriteLine(num * num);

                num = int.Parse(Console.ReadLine());
            }

            Console.ReadLine();

        }
    }
}
