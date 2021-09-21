using System;

namespace Metodos_con_retorno
{
    class Program
    {
        //METODOS CON RETORNO

        static void Main(string[] args)
        {
            int resultado = Sumar(15, 31);
            Console.WriteLine(resultado);

            Console.WriteLine(Sumar(20, 31)); //AMBAS MANERAS SON POSIBLES

            int resultado1 = Multiplicar(2, 5);
            Console.WriteLine(resultado1);

            Console.WriteLine(Multiplicar(3, 6)); //AMBAS MANERAS SON POSIBLES

            double resultado2 = Division(10, 3);
            Console.WriteLine(resultado2);

            Console.WriteLine(Division(9, 2)); //AMBAS MANERAS SON POSIBLES

            Console.Read();
        }

        public static int Sumar(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double Division(double num1, double num2)
        {
            return num1 / num2;
        }

    }
}
