using System;

namespace Loop_For

//T I P O S D E L O O P S

//LOOP FOR
//LOOP WHILE (EVALUA LA CONDICION Y LUEGO EJECUTA)
//LOOP DO WHILE (PRIMERO EJECUTA Y LUEGO VERIFICA)
//LOOP FOREACHO (RECORRE UNA LISTA O ARRAY)

//<<<< LOOP FOR >>>>>
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int contador = 0; contador <= 10; contador++)
            {
                Console.WriteLine("Numero: " + contador);
            }

            Console.WriteLine();

            for (int contador = 1; contador <= 20; contador += 2)
            {
                Console.WriteLine("Numero: " + contador);
            }
            
            Console.Read();
        }
    }
}
