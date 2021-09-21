using System;

namespace If_y_else_if_con_tryparse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la temperatura que hace: ");

            //int temperatura = Convert.ToInt32(Console.ReadLine());
            string temperaturaactual = Console.ReadLine();
            int temperatura; // = int.Parse(temperaturaactual);

            int numero;

            if (int.TryParse(temperaturaactual, out numero))
            {
                temperatura = numero;
            }
            else
            {
                temperatura = 0;
                Console.WriteLine("El valor ingresado no es valido, se establecio por defecto la temperatura en 0");
            }

            if (temperatura < 20)
            {
                Console.Write("Abrigate que hace frio");
            }
            else if (temperatura == 20)
            {
                Console.WriteLine("Hace 20 grados de tremperatura");
            }
            else 
            {
                Console.WriteLine("El dia esta lindo");
            }

            Console.Read();
        }
    }
}
