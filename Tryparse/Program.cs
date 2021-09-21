using System;

namespace Tryparse // CONVERTIR STRINGS EN TIPOS DE DATOS ENTEROS
                   // EL PARSING FALLA CUANDO EL STRING NO PUEDE CONVERTIRSE EN EL TIPO DE DATOS DESEADO/REQUERIDO
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese un valor numerico");
            string numeroComoString = Console.ReadLine(); 
            int valorParseado; // EN LUGAR DE INT, TAMBIEN PODRIA USAR FLOAT, DOUBLE

            bool exito = int.TryParse(numeroComoString, out valorParseado);

            if (exito)
                Console.WriteLine("Parsing exitoso - el numero es " + valorParseado);
            else
                Console.WriteLine("Parsing fallido");

            Console.Read();
        }
    }
}
