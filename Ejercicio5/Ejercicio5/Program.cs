using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
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

            double sumaT = num1 + num2;
            Console.WriteLine("La suma de los dos primeros números es: " + sumaT);

            double productoT = num3 * num4;
            Console.WriteLine("El producto total de " + num3 + " y de " + num4 + " es: " + productoT);
        }
    }
}
