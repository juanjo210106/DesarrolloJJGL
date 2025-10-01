using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio10
{
    class Cliente
    {
        private string nombre;
        private double cantidadTotal;


        // Constructor 
        public Cliente(String nombre)
        {
            this.nombre = nombre;
            this.cantidadTotal = 0;
        }

        // Metodo ingresar dinero
        public void Ingresar(double cantidad)
        {
            if (cantidad > 0)
            {
                cantidadTotal += cantidad;
            }
            else
            {
                Console.WriteLine("[ERROR]: No se puede ingresar esta cantidad...");
            }
        }

        // Método sacar dineroo
        public void Sacar(double cantidad)
        {
            if (cantidadTotal < cantidad)
            {
                Console.WriteLine("[ERROR]: Saldo insuficiente. No es posible sacar esa cantidad...");
            }
            else
            {
                cantidadTotal -= cantidad;
            }
        }

        // Metodo cantidad 
        public double GetCantidadTotal()
        {
            Console.WriteLine(cantidadTotal);
            return cantidadTotal;
        }

        // Metodo mostrar la información
        public void MostrarInformacion()
        {
            Console.WriteLine(nombre+": ....El saldo de la cuenta es de: " + cantidadTotal);
        }
    }

    class Banco
    {
        protected Cliente cliente1;
        protected Cliente cliente2;
        protected Cliente cliente3;

        public Banco()
        {
            cliente1 = new Cliente("Ana");
            cliente2 = new Cliente("Kirri");
            cliente3 = new Cliente("Alan");
        }

        public void Operar()
        {
            cliente1.Ingresar(50);
            cliente2.Ingresar(500);
            cliente3.Ingresar(1000);

            cliente1.Sacar(1000);
        }

        public void ObtenerEstado()
        {
            double totalBanco = cliente1.GetCantidadTotal() + cliente2.GetCantidadTotal() + cliente3.GetCantidadTotal();
            Console.WriteLine("El banco tiene un total de: " + totalBanco);

            cliente1.MostrarInformacion();
            cliente2.MostrarInformacion();
            cliente3.MostrarInformacion();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Banco banco = new Banco();
            banco.Operar();
            banco.ObtenerEstado();

        }
    }
}
