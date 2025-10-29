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
            Console.Write("Indica el tamaño del array: ");
            int tamano = int.Parse(Console.ReadLine());


            int[] array = new int[tamano];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Introduce el número ("+i+"): ");
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    Console.WriteLine("PAR: " + array[i]);
                }
                else
                {
                    Console.WriteLine("IMPAR: " + array[i]);
                }
            }
        }
    }
}
