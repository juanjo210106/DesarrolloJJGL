using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("| Introduce un número entero: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("| Introduce un número entero: ");
            int num2 = int.Parse(Console.ReadLine());

            esMultiplo(num1, num2);
        }

        public static void esMultiplo(int num1, int num2)
        {
            if (num1 % num2 == 0)
            {
                Console.WriteLine("EL " + num1 + " ES MÚLTIPLO DE " + num2);
            }
            else
            {
                Console.WriteLine("ERROR: EL " + num1 + " NO ES MÚLTIPLO DE " + num2);
            }
        }
    }
}
