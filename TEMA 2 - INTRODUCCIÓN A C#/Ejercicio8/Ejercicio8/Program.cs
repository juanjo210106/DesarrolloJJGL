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
            Console.Write(":: Introduce la primera nota de examen...: ");
            double notaE1 = double.Parse(Console.ReadLine());
            Console.Write(":: Introduce la segunda nota de examen...: ");
            double notaE2 = double.Parse(Console.ReadLine());

            Console.Write(":: Introduce la primera nota de trabajo...: ");
            double notaT1 = double.Parse(Console.ReadLine());

            Console.Write(":: Introduce la nota de actitud...: ");
            double notaActitud = double.Parse(Console.ReadLine());

            double promedioExamenes = ((notaE1 + notaE2) / 2) * 0.5;
            double promedioTrabajos = notaT1 * 0.3;
            double promedioActitud = notaActitud * 0.2;

            double nfinal = (promedioExamenes + promedioTrabajos + promedioActitud);

            Console.WriteLine("LA NOTA FINAL ES DE: " + nfinal);
        }
    }
}
