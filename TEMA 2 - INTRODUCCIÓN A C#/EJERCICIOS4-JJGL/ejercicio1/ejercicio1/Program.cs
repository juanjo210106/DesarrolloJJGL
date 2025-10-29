using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    internal class Program
    {
        public class Cuenta
        {
            protected String titular;
            protected double cantidad;

            public Cuenta(String titular, double cantidad)
            {
                this.titular = titular;
                this.cantidad = 0;
            }

            public String getTitular()
            {
                return titular;
            }

            public void setTitular(String titular)
            {
                this.titular = titular;
            }

            public double getCantidad()
            {
                return cantidad;
            }

            public void setCantidad(double cantidad)
            {
                this.cantidad = cantidad;
            }

            public void Ingresar(double cantidadIngresar)
            {
                Console.WriteLine("La cantidad que se va a ingresar es de: " + cantidadIngresar);
                Console.WriteLine("Contando dinero...");

                if (cantidadIngresar < 0)
                {
                    Console.WriteLine("[ERROR]: No es posible realizar la operación... La cantidad que intentas ingresar es negativa");
                }
                else
                {
                    Console.WriteLine("| Ingresando el dinero en tu cuenta...");
                    cantidad += cantidadIngresar;
                }
            }

            public void Retirar(double cantidadRetirar)
            {
                Console.WriteLine("Realizando la retirada del dinero...");
                if (cantidadRetirar > cantidad)
                {
                    Console.WriteLine("[ERROR]: Estás intentando retirar una cantidad más grande de la que tienes en la cuenta...");
                }
                else
                {
                    Console.WriteLine("Se esta contando la cantidad a retirar (" + cantidadRetirar + "€)...");
                    cantidad -= cantidadRetirar;
                }
            }

            public String toString()
            {
                return "---------------------\nNombre del Titular: " + titular + "\nCantidad en la cuenta: " + cantidad+"\n----------------------------";
            }
        }

        static void Main(string[] args)
        {
            Cuenta cuentaPepe = new Cuenta("Pepe", 0);

            cuentaPepe.Ingresar(100);
            cuentaPepe.Ingresar(-10);

            cuentaPepe.Retirar(200);
            cuentaPepe.Retirar(100);

            Console.WriteLine(cuentaPepe.toString());
        }
    }
}
