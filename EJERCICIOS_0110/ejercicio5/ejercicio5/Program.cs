using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de Potencia");

            
            Console.Write("Ingresa la base: ");
            double baseNum = double.Parse(Console.ReadLine());

            
            Console.Write("Ingresa el exponente: ");
            int exponente = int.Parse(Console.ReadLine());

            
            double resultadoIterativo = PotenciaIterativa(baseNum, exponente);
            Console.WriteLine("\nResultado iterativo: "+baseNum+"^"+exponente+" = "+resultadoIterativo);

            double resultadoRecursivo = PotenciaRecursiva(baseNum, exponente);
            Console.WriteLine("Resultado recursivo: "+baseNum+"^"+exponente+" = "+resultadoRecursivo);
        }

        
        public static double PotenciaIterativa(double baseNum, int exponente)
        {
            if (exponente == 0)
            {
                return 1; // Cualquier número elevado a la 0 es 1
            }

            double resultado = 1;
            if (exponente > 0)
            {
                for (int i = 0; i < exponente; i++)
                {
                    resultado *= baseNum;
                }
                return resultado;
            }
            else // exponente negativo
            {
                for (int i = 0; i < exponente; i++)
                {
                    resultado *= baseNum;
                }
                return 1 / resultado;
            }
        }

        
        public static double PotenciaRecursiva(double baseNum, int exponente)
        {
            if (exponente == 0)
            {
                return 1; // Caso base: cualquier número elevado a 0 es 1
            }
            // Caso recursivo para exponentes positivos
            if (exponente > 0)
            {
                return baseNum * PotenciaRecursiva(baseNum, exponente - 1);
            }
            // Caso recursivo para exponentes negativos
            else
            {
                return (1 / baseNum) * PotenciaRecursiva(baseNum, exponente + 1);
            }
        }
    }
    }
}
