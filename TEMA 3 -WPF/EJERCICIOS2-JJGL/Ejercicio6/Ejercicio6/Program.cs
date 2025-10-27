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
            Random random = new Random();

            int numAleatorio = random.Next(10, 30);
            Console.WriteLine("EL NÚMERO ALEATORIO GENERADO ES: " + numAleatorio);
        }
    }
}
