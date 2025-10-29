using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("....: Introduce un número entero: ");
            int numeroIngresado = int.Parse(Console.ReadLine());

            // Llamo a la función auxiliar para obtener la suma de los dígitos.
            int resultado = SumarDigitosNumero(numeroIngresado);

            // Muestra el resultado al usuario.
            Console.WriteLine("= "+resultado);


        }

        public static int SumarDigitosNumero(int numero)
        {
            int longitud = numero.ToString().Length;
            int i = longitud;
            int suma = 0;
            int[] digit = new int[longitud]; // Inicialización de la variable 'digit'
            // Dividimos entre 10 mientras no sea cero  y vamos extrayendo cada digito
            while (numero != 0)
            {
                // numero % 10 obtiene el último dígito del número.
                int numObtenido = numero % 10;


                Console.Write(numObtenido+" + ");

                suma += numObtenido;
                digit[i - 1] = numObtenido;

                // numero / 10 elimina el último dígito del número.
                numero /= 10;
                i--;
            }
            return suma;
        }
    }
}
