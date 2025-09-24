using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce una cadena de texto: ");
            String cadena = Console.ReadLine();

            Console.WriteLine("LA LONGITUD DE LA CADENA ES: " + cadena.Length);
            Console.WriteLine("LA CADENA EN MAYÚSCULAS ES: "+cadena.ToUpper());
            Console.WriteLine("LA CADENA EN MAYÚSCULAS ES: " + cadena.ToLower());
            Console.WriteLine("");

            Console.WriteLine("¿La cadena contiene Hola? - "+ cadena.Contains("Hola"));
            Console.WriteLine("Cadena que remplaza la H por a: " + cadena.Replace("H", "a"));
            Console.WriteLine("Elimina el caracter de la posicion 1: " + cadena.Remove(1, 1));
        }
    }
}
