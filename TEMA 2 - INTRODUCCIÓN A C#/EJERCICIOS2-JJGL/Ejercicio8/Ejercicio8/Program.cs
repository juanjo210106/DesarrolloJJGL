using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] array = new int[10];
            int[] array = {10, 3, 5, 8, 6, 1, 7, 2, 4};



            
            Console.WriteLine("ARRAY ORDENADO ASCENDENTE");
            Array.Sort(array);
            foreach (int n in array)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine();
            Console.WriteLine("ARRAY ORDENADO DESCENDENTE");
            Array.Reverse(array);
            foreach (int n in array)
            {
                Console.WriteLine(n);
            }
        }
    }
}
