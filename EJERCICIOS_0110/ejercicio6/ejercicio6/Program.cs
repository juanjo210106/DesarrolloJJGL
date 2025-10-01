using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write(".....Introduce el nombre de usuario: ");
                String user = Console.ReadLine();
                Console.Write(".....Introduce la contraseña del usuario: ");
                String password = Console.ReadLine();

                

                if (login(user, password))
                {
                    Console.WriteLine("| USUARIO Y CONTRASEÑA CORRECTOS... Accediendo");
                    Console.WriteLine();
                    break;
                }
                else
                {
                    Console.WriteLine("ERROR | USUARIO Y CONTRASEÑA INCORRECTOS... Prueba de nuevo (Intentos: "+(i+1)+")");
                    Console.WriteLine();
                }
            }

        }

        public static Boolean login(String user, String password)
        {
            Boolean comprobacion = false;

            if (user.Equals("usuario2DAM") && password.Equals("pass2DAM")){
                comprobacion = true;
            }
            return comprobacion;
        }
    }
}
