using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios1C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 2 - Bar
            const double precioHam = 4.60;
            const double preciopat = 1.20;
            const double preciobeb = 2.20;

            Console.Write("Introduce el número de hamburguesas......: ");
            int nham = int.Parse(Console.ReadLine());
            Console.Write("Introduce el número de paquetes de patatas......: ");
            int npat = int.Parse(Console.ReadLine());
            Console.Write("Introduce el número de bebidas consumidas......: ");
            int nbeb = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine(".......................................");
            double total = precioHam * nham;
            Console.WriteLine("Total precio hamburguesas.........: "+total);
            double preciototal = total;

            total = 0;
            total = preciopat * npat;
            preciototal = preciototal + total;
            Console.WriteLine("Total precio patatas.........: " + total);

            total = 0;
            total = preciobeb * nbeb;
            preciototal = preciototal + total;
            Console.WriteLine("Total precio bebidas.........: " + total);
            Console.WriteLine(".......................................");

            Console.WriteLine("TOTAL A PAGAR...: " + preciototal);
        }
    }
}
