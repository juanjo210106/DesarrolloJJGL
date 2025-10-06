using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ejercicio2
{
    internal class Program
    {
        public class Contacto
        {
            protected String nombre;
            protected String telefono;

            public Contacto(String nombre, String telefono)
            {
                this.nombre = nombre;
                this.telefono = telefono;
            }

            public String getNombre()
            {
                return nombre;
            }

            public String getTelefono()
            {
                return telefono;
            }

            
            public String toString()
            {
                return "...........................\nNombre: " + nombre + ", Teléfono: " + telefono + "\n...........................";
            }
        }

        public class Agenda
        {
            protected List<Contacto> contactos;
            protected int capacidad;

            public Agenda(int capacidad = 10)
            {
                this.capacidad = capacidad;
                contactos = new List<Contacto>();
            }

            public void AñadirContacto(Contacto c)
            {
                if (AgendaLlena())
                {
                    Console.WriteLine("| ERROR |: La agenda se encuentra llena... No es posible añadir más contactos");
                    return;
                }

                if (ExisteContacto(c))
                {

                    Console.WriteLine("Ya existe un contacto con ese nombre.");
                    return;
                }

                contactos.Add(c);
                Console.WriteLine("Contacto añadido correctamente.");
            }

            public bool ExisteContacto(Contacto contacto)
            {
                foreach (Contacto c in contactos)
                {
                    if (c.getNombre() == contacto.getNombre())
                    {
                        return true;
                    }
                }
                return false;
            }

            public void ListarContactos()
            {
                if (contactos.Count == 0)
                {
                    Console.WriteLine("[ERROR]: La agenda se encuentra vacía...");
                    return;
                }

                Console.WriteLine("| Lista de contactos |");
                foreach (Contacto c in contactos)
                {
                    Console.WriteLine("Nombre: "+c.getNombre() + "\nTeléfono: "+c.getTelefono());
                }
            }

            public void BuscarContacto(string nombre)
            {
                foreach (Contacto c in contactos)
                {
                    if (c.getNombre().Equals(nombre))
                    {
                        Console.WriteLine("Nombre: " + c.getNombre() + "\nTeléfono: " + c.getTelefono());
                    }
                }

            }

            public void EliminarContacto(String nombre)
            {
                foreach (Contacto c in contactos)
                {
                    if (c.getNombre().Equals(nombre))
                    {
                        Console.WriteLine("Eliminando a "+nombre);
                        contactos.Remove(c);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("No se encontró el contacto para eliminar.");
                    }
                }
            }

            public bool AgendaLlena()
            {
                if (contactos.Count() == 10)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }

            public int HuecosLibres()
            {
                return capacidad - contactos.Count();
            }
        }

        static void Main(string[] args)
        {
            Agenda agenda = new Agenda();
            int opcion;

            do
            {
                Console.WriteLine("\n===== AGENDA TELEFÓNICA =====");
                Console.WriteLine("1. Añadir contacto");
                Console.WriteLine("2. Listar contactos");
                Console.WriteLine("3. Buscar contacto");
                Console.WriteLine("4. Eliminar contacto");
                Console.WriteLine("5. Comprobar si la agenda está llena");
                Console.WriteLine("6. Mostrar huecos libres");
                Console.WriteLine("7. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());


                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese el nombre: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Ingrese el teléfono: ");
                        string telefono = Console.ReadLine();
                        agenda.AñadirContacto(new Contacto(nombre, telefono));
                        break;

                    case 2:
                        agenda.ListarContactos();
                        break;

                    case 3:
                        Console.Write("Ingrese el nombre a buscar: ");
                        string nombreBuscar = Console.ReadLine();
                        agenda.BuscarContacto(nombreBuscar);
                        break;

                    case 4:
                        Console.Write("Ingrese el nombre del contacto a eliminar: ");
                        string nombreEliminar = Console.ReadLine();
                        agenda.EliminarContacto(nombreEliminar);
                        break;

                    case 5:
                        if (agenda.AgendaLlena())
                        {
                            Console.WriteLine("[ERROR]: La agenda se encuentra llena...");
                        } else
                        {
                            Console.WriteLine("Aún queda espacio en la agenda...");
                        }

                        break;

                    case 6:
                        Console.WriteLine("Huecos libres: "+agenda.HuecosLibres());
                        break;

                    case 7:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

            } while (opcion != 7);
        }
    }
}
