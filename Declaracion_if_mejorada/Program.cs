using System;

namespace Declaracion_if_mejorada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la temperatura actual: ");
            int tempreratura = Convert.ToInt32(Console.ReadLine());
            string estadoDelAgua;

            if (tempreratura < 0)
                estadoDelAgua = "Solido";
            else if (tempreratura > 0 && tempreratura < 99)
                estadoDelAgua = "Liquido";
            else
                estadoDelAgua = "Gaseaso";

            Console.WriteLine("El agua se encuentra en estado " + estadoDelAgua);

            /*
            tempreratura += 30;

            estadoDelAgua = tempreratura < 0 ? "Solido" : "Liquido";
            Console.WriteLine("El agua se encuentra en estado " + estadoDelAgua);
            */

            // CONDICIONAL IF (MEJORADO)

            estadoDelAgua = tempreratura > 99 ? "Gaseoso" : tempreratura < 0 ? "Solido" : "Liquido";
            Console.WriteLine("El agua se encuentra en estado " + estadoDelAgua);

            Console.Read();
        }
    }
}
