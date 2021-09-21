using System;

namespace Loop_Do_While

    //LOOP DO WHILE (PRIMERO EJECUTA Y LUEGO VERIFICA)
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;

            do
            {
                Console.WriteLine("Numero: " + contador);
                contador++;
            } while (contador <= 10);

            Console.WriteLine();

            int largoDeTexto = 0;
            string textoCompleto = "";

            do
            {
                Console.WriteLine("Por favor, ingrese el nombre de un amigo: ");
                string nombreAmigo = Console.ReadLine();
                int largoActual = nombreAmigo.Length;
                largoDeTexto += largoActual;
                textoCompleto += nombreAmigo;
            } while (largoDeTexto < 20);
            Console.WriteLine("Muchas gracias, la lista de nombrew ingresados, es: " + textoCompleto);
         
            Console.Read();
        }
    }
}
