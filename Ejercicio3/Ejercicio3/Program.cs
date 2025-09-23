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
            Console.Write("Introduce un número por teclado...: ");
            double num = double.Parse(Console.ReadLine());

            const double numExtra = 2;

            Console.WriteLine("|--- VALOR ABSOLUTO ---|");
            Console.WriteLine("El valor absoluto del número es: "+Math.Abs(num));
            Console.WriteLine();

            Console.WriteLine("|--- POTENCIA AL CUBO ---|");
            Console.WriteLine("La potencia del cubo del número introducido elevado a "+numExtra+" es: " + Math.Pow(num, 2));
            Console.WriteLine();

            Console.WriteLine("|--- RAÍZ CUADRADA ---|");
            Console.WriteLine("La raíz cuadrada del número introducido es: " + Math.Sqrt(num));
            Console.WriteLine();

            Console.WriteLine("|--- SENO ---|");
            Console.WriteLine("El seno del número introducido es: " + Math.Sin(num));
            Console.WriteLine();

            Console.WriteLine("|--- COSENO ---|");
            Console.WriteLine("El coseno del número introducido es: " + Math.Cos(num));
            Console.WriteLine();

            Console.WriteLine("|--- NÚMERO MÁXIMO ---|");
            Console.WriteLine("Número máximo del número introducido comparandolo con "+numExtra+" es: " + Math.Max(num, numExtra));
            Console.WriteLine();

            Console.WriteLine("|--- NÚMERO MÍNIMO ---|");
            Console.WriteLine("Número minimo del número introducido comparandolo con "+numExtra+" es: " + Math.Min(num, numExtra));
        }
    }
}
