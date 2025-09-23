using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(":: Introduce el precio del producto...: ");
            double precio = double.Parse(Console.ReadLine());

            Console.Write(":: Introduce la cantidad total........: ");
            int cantidad = int.Parse(Console.ReadLine());

            double costeT = precio * cantidad;
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("TOTAL ES DE: " + costeT);
        }
    }
}
