using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce el tamaño del array: ");
            int tamano = int.Parse(Console.ReadLine());
            int suma = 0;
            int[] array_n = new int[tamano];
            for (int i = 0; i < array_n.Length; i++)
            {
                Console.Write("|..... INTRODUCE EL NÚMERO (" + (i+1) + "): ");
                int n = int.Parse(Console.ReadLine());
                array_n[i] = n;
                suma = suma + n;
            }
            double media = suma / tamano;

            Console.WriteLine("LA SUMA TOTAL ES...: "+suma);
            Console.WriteLine("LA MEDIA TOTAL ES.....: " + media);
        }
    }
}
