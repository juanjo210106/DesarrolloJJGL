using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    public class Cancion
    {
        protected string Titulo;
        protected string Artista;

        public Cancion(string titulo = "Desconocido", string artista = "Desconocido")
        {
            Titulo = titulo;
            Artista = artista;
        }

        public override string ToString()
        {
            return "Título: " + Titulo + " - Artista: " + Artista;
        }
    }

    public class CD
    {
        protected Cancion[] canciones;
        protected int contador;

        public CD(int capacidad = 10)
        {
            canciones = new Cancion[capacidad];
            contador = 0;
        }

        public int NumeroCanciones()
        {
            return contador;
        }

        public Cancion DameCancion(int posicion)
        {
            if (posicion >= 0 && posicion < contador)
                return canciones[posicion];
            else
                return null;
        }

        public void GrabaCancion(int posicion, Cancion nuevaCancion)
        {
            if (posicion >= 0 && posicion < contador)
                canciones[posicion] = nuevaCancion;
        }

        public void Agrega(Cancion nuevaCancion)
        {
            if (contador < canciones.Length)
            {
                canciones[contador] = nuevaCancion;
                contador++;
            }
            else
            {
                Console.WriteLine("No hay espacio para más canciones.");
            }
        }

        public void Elimina(int posicion)
        {
            if (posicion >= 0 && posicion < contador)
            {
                for (int i = posicion; i < contador - 1; i++)
                {
                    canciones[i] = canciones[i + 1];
                }
                canciones[contador - 1] = null;
                contador--;
            }
        }

        public void MostrarCD()
        {
            Console.WriteLine("\nContenido del CD:");
            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine((i + 1) + ". " + canciones[i]);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            CD miCD = new CD();

            miCD.Agrega(new Cancion("Imagine", "John Lennon"));
            miCD.Agrega(new Cancion("Billie Jean", "Michael Jackson"));
            miCD.Agrega(new Cancion("Bohemian Rhapsody", "Queen"));

            miCD.MostrarCD();

            Console.WriteLine("\nNúmero de canciones: " + miCD.NumeroCanciones());

            Console.WriteLine("\nReemplazando la canción 2...");
            miCD.GrabaCancion(1, new Cancion("Thriller", "Michael Jackson"));
            miCD.MostrarCD();

            Console.WriteLine("\nEliminando la canción 1...");
            miCD.Elimina(0);
            miCD.MostrarCD();

            Console.ReadKey();
        }
    }
}
