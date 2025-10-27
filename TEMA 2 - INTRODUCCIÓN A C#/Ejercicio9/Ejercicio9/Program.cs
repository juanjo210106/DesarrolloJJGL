using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce una cadena: ");
            String cadena = Console.ReadLine();

            if (cadena.StartsWith("www")){
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
