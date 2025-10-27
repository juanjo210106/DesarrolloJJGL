using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("...... Introduce un número que quieras comprobar: ");
            int n = int.Parse(Console.ReadLine());

            comprobarPrimos(n);

            Console.WriteLine();
            Console.ReadKey();
        }

        

        public static void comprobarPrimos(int n)
        {
            Boolean esPrimo = true;

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    esPrimo = false;
                    
                }
            }

            if (esPrimo)
            {
                Console.Write(n + " - ES PRIMO");
            }
            else
            {
                Console.Write(n + " - NO ES PRIMO");
            }
        }
    }
}
