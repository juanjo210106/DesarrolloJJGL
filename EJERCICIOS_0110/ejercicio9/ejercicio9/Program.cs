using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = {5, 8, 7, 16, 9, 12};

            
            posicionMenor(numeros);
        }

        public static void posicionMenor(int[] numeros)
        {
            int numeroMenor = numeros.Min(); 
            
            int posicion = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] <= numeroMenor)
                {
                    posicion = i;
                }
            }
            Console.WriteLine(".... La posicion del número más pequeño es: " + posicion);
            
        }
    }
}
