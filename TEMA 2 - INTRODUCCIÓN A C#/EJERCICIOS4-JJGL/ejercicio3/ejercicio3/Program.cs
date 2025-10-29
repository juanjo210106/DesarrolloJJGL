using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    internal class Program
    {
        public class Cancion
        {
            protected String titulo;
            protected String autor;

            public Cancion(string titulo, string autor)
            {
                this.titulo = titulo;
                this.autor = autor;
            }

            public Cancion()
            {
                this.titulo = null;
                this.autor = null;
            }

            public String dameTitulo()
            {
                return titulo;
            }

            public String dameAutor()
            {
                return autor;
            }

            public void ponTitulo(String nombreTitulo)
            {
                this.titulo = nombreTitulo;
            }

            public void ponAutor(String nombreAutor)
            {
                this.autor = nombreAutor;
            }
        }

        static void Main(string[] args)
        {
            Cancion song1 = new Cancion("Una noche en miami", "Bad Bunny");
            Cancion song2 = new Cancion();

            Console.WriteLine("Obteniendo el título de la canción de la song1...");
            Console.WriteLine(song1.dameTitulo());

            Console.WriteLine("Obteniendo el nombre del autor de la song1");
            Console.WriteLine(song1.dameAutor());

            Console.WriteLine("Poiendo el título de la canción en song2...");
            song2.ponTitulo("El día del señor");
            song2.ponAutor("Alfonso López Cortés");

            Console.WriteLine(song2.dameTitulo());
            Console.WriteLine(song2.dameAutor());

            Console.WriteLine("Modificando el nombre de la song1 y mostrandolo...");
            song1.ponTitulo("Caro");
            Console.WriteLine(song1.dameTitulo());


        }
    }
}
