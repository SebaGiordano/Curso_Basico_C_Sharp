using System;

namespace Constantes
{
    class Program
    {
        const double PI = 3.14;
        const int semanas = 52;
        const int dias = 365;
        const string nacimiento = "25/10/1997";

        static void Main(string[] args)
        {
            Console.WriteLine("Mi nacimiento es el: {0}", nacimiento);
            Console.Read();
        }
    }
}
