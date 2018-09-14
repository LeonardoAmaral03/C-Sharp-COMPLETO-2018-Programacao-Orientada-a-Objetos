using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1 {
    class Program {
        static void Main(string[] args) {

            int volInicial, vazBomba, tempo, volFinal;

            volInicial = int.Parse(Console.ReadLine());
            vazBomba = int.Parse(Console.ReadLine());
            tempo = int.Parse(Console.ReadLine());

            volFinal = volInicial - vazBomba * tempo;

            if (volFinal < 0) {
                Console.WriteLine("nao eh possivel");
            }
            else {
                Console.WriteLine(volFinal);
            }

            Console.ReadLine();

        }
    }
}
