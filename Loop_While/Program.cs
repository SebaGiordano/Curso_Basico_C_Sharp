using System;

namespace Loop_While
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int contador = 0;

            while (contador < 10)
            {
                Console.WriteLine("Numero: " + contador);
                contador++;
            }
            */

            // EJERCICIO: CREAR UN PROGRAMA QUE PERMITA IR CONTANDO 1 EN 1. UN PROFESOR VA CONTANDO SUS ALUMNOS DE A UNO A MEDIDA QUE SUBEN AL BUS,
            // EL PROFESOR DEBE PRESIONAR ENTER CADA VEZ QUE UN ALUMNO SUBE AL BUS. PARA FINALIZAR PRESIONE OTRA TECLA.

            int contador = 0;
            string textoIngresado = "";

            Console.WriteLine("PROGRAMA PARA CONTABILIZAR CUANTOS ALUMNOS SUBEN A UN BUS");
            Console.WriteLine();

            while (textoIngresado.Equals("")) //EQUALS ES PARA CHEQUEAR QUE EL TEXTO INGRESADO SEA SIEMPRE EL MISMO, SI NO LO ES, TERMINA EL PROGRAMA.
            {                             
                Console.WriteLine("Ha subido un alumno al bus? si es asi, presione enter. Para finalizar pulse otra tecla!");
                textoIngresado = Console.ReadLine();
                contador++;      
            }

            Console.WriteLine();
            Console.WriteLine("Alumnos en el bus: " + contador);

            Console.Read();
        }
    }
}
