using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce un número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Introduce otro número: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("Introduce otro número: ");
            double num3 = double.Parse(Console.ReadLine());

            Console.Write("Introduce otro número: ");
            double num4 = double.Parse(Console.ReadLine());

            double sumaT = num1 + num2 + num3 + num4;
            Console.WriteLine("LA SUMA TOTAL DE LOS 4 NÚMEROS ES: " + sumaT);

            double promedio = sumaT / 4;
            Console.WriteLine("EL PROMEDIO DE LOS 4 NÚMEROS ES: " + promedio);
        }
    }
}
