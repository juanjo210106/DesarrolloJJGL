using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce un número del 1 al 9...: ");
            int num = int.Parse(Console.ReadLine());

            if (num < 1 || num > 9)
            {
                Console.WriteLine("El número se encuentra fuera del rango...");
            }
            else
            {
                for (int i = 0; i <= 10; i++)
                {
                    int resultado = num * i;
                    Console.WriteLine(num + "x" + i + "=" + resultado);
                }
            }
        }
    }
}
