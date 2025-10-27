using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("... Introduce un número para calcular el factorial: ");
            int num = int.Parse(Console.ReadLine());

            calcularFactorial(num);
            
        }

        public static void calcularFactorial(int num)
        {
            int resultado = num;
            Console.Write(num + "! = " + num + " x ");
            for (int i = num-1; i >= 1; i--)
            {
                resultado = resultado * i;
                if (i!=1)
                {
                    Console.Write(i + " x ");
                } else
                {
                    Console.Write(i + " = ");
                }
            }
            Console.Write(resultado);
        }
    }
}
