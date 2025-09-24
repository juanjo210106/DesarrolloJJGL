using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce tu estado civil (C,S,V,D)...: ");
            String estado = Console.ReadLine();

            switch (estado.ToUpper())
            {
                case "C":
                    Console.WriteLine("Tu estado civil es: Casado");
                    break;

                case "S":
                    Console.WriteLine("Tu estado civil es: Soltero");
                    break;

                case "V":
                    Console.WriteLine("Tu estado civil es: Viudo");
                    break;

                case "D":
                    Console.WriteLine("Tu estado civil es: Divorciado");
                    break;

                default:
                    Console.WriteLine("No has introducido una opción correcta...");
                    break;
            }
        }
    }
}
