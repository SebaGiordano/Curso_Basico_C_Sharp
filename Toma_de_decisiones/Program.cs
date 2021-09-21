using System;

namespace Toma_de_decisiones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la temperatura que hace: ");

            int temperatura = Convert.ToInt32(Console.ReadLine());
            //string temperaturaactual = Console.ReadLine();
            //int temperatura = int.Parse(temperaturaactual);

            if (temperatura < 20)
            {
                Console.Write("Abrigate que hace frio");
            }
            if (temperatura == 20)
            {
                Console.WriteLine("Hace 20 grados de tremperatura");
            }
            if (temperatura > 20)
            {
                Console.WriteLine("El dia esta lindo");
            }

            Console.Read();
        }
    }
}
