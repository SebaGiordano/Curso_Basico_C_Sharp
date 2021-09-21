using System;

namespace If_Anidados
{
    class Program
    {
        //CASO PRACTICO CON IF ANIDADOS
        static void Main(string[] args)
        {
            bool esAdmin = false;
            bool estaRegistrado = true;
            string nombreUsuario = "";

            Console.WriteLine("Por favor, ingrese su nombre de usuario: ");
            nombreUsuario = Console.ReadLine();
            Console.WriteLine();

            if (estaRegistrado)
            {
                Console.WriteLine("Felicidades, eres un usuario registrado!!!");
                if (nombreUsuario != "")
                {
                    if (nombreUsuario.Equals("Admin"))
                    {
                        Console.WriteLine("Hola Admin!!!");
                    }
                    else
                    {
                        Console.WriteLine("Hola " + nombreUsuario);
                    }
                }
            }

            //UNA FORMA MAS SIMPLIFICADA DE RESOLVER ESTE EJERCICIO CON IF

            if (estaRegistrado && nombreUsuario != "" && nombreUsuario.Equals("Admin"))
            {
                Console.WriteLine("Felicidades, eres un usuario registrado!!!");
                Console.WriteLine("Hola " + nombreUsuario);
                Console.WriteLine("Hola Admin!!!");
            }

            if (esAdmin || estaRegistrado)
            {
                Console.WriteLine("Usted se encuentra loguado!");
            }

            Console.Read();
        }
    }
}
