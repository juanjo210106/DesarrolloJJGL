using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write(".....Introduce la cadena: ");
            String cadena = Console.ReadLine();

            Console.WriteLine("|----- LA CANTIDAD DE ESPACIOS EN BLANCO ES DE: "+Calcular(cadena));
        }

        public static int Calcular(String cadena)
        {
            int contador = 0;
            foreach (char caracter in cadena)
            {
                if (caracter.Equals(' '))
                {
                    contador++;
                }
            }
            return contador;
        }
    }
}
