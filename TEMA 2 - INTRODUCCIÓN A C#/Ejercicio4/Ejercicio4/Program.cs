using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce el valor de la longitud del lado del cuadrado...: ");
            double lado = double.Parse(Console.ReadLine());

            double perimetroT = lado * 4;

            Console.WriteLine("EL PERIMETRO DEL CUADRADO ES: " + perimetroT);
        }
    }
}
