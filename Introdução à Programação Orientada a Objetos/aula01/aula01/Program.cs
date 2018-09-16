using System;
using System.Globalization;
namespace curso {
    class Program {
        static void Main(string[] args) {
            double aX, bX, cX, aY, bY, cY;
            double areaX, areaY, p;
            aX = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            bX = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cX = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aY = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            bY = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cY = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p = (aX + bX + cX) / 2.0;
            areaX = Math.Sqrt(p * (p - aX) * (p - bX) * (p - cX));
            p = (aY + bY + cY) / 2.0;
            areaY = Math.Sqrt(p * (p - aY) * (p - bY) * (p - cY));
            Console.WriteLine("AREA DO TRIANGULO X: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("AREA DO TRIANGULO Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));
            if (areaX > areaY) {
                Console.WriteLine("TRIANGULO DE MAIOR AREA: X");
            }
            else if (
          areaY >
          areaX) {
                Console.WriteLine("TRIANGULO DE MAIOR AREA: Y");
            }
            else {
                Console.WriteLine("AREAS IGUAIS");
            }
            Console.ReadLine();
        }
    }
}