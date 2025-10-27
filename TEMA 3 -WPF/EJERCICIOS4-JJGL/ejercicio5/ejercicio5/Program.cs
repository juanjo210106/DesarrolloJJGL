using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5
{
    internal class Program
    {
        public class Juego
        {
            protected int vidas;

            public Juego(int vidas)
            {
                this.vidas = vidas;
            }

            public int getVidas() { return vidas; }

            public void setVidas(int vidas) {
                this.vidas = vidas;
            }

            public void MuestraVidasRestantes()
            {
                Console.WriteLine("Vidas restantes: " + vidas);
            }
        }

        static void Main(string[] args)
        {
             // Crear una instancia del juego con 5 vidas
            Juego juego1 = new Juego(5);
            juego1.MuestraVidasRestantes();

            // Restar una vida
            juego1.setVidas(juego1.getVidas() - 1);
            juego1.MuestraVidasRestantes();

            // Crear otra instancia del juego con 5 vidas
            Juego juego2 = new Juego(5);
            juego2.MuestraVidasRestantes();

            // Mostrar las vidas del primer juego nuevamente
            juego1.MuestraVidasRestantes();

            Console.ReadKey(); // Para pausar la consola
        }
    }
}
