using System;

namespace Ingresos_de_usuarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("La suma de los 2 numeros ingresados, es: " + Calcular()); //LLAMA AL METODO INT
            Calcular1(); //LLAMA AL METODO VOID
            Console.Read();
        }

        //UNA MANERA DE HACER EL METODO ES CON PUBLIC STATIC INT

        public static int Calcular()
        {
            Console.WriteLine("Ingrese un numero: ");
            string num1 = Console.ReadLine();
            Console.WriteLine("Ingrese otro numero: ");
            string num2 = Console.ReadLine();

            int numero1 = int.Parse(num1);
            int numero2 = int.Parse(num2);

            int resultado = numero1 + numero2;
            return resultado;

        }

        //OTRA MANERA DE HACER EL METODO ES CON PUBLIC STATIC VOID

        public static void Calcular1()
        {
            Console.WriteLine("Ingrese un numero: ");
            string num1 = Console.ReadLine();
            Console.WriteLine("Ingrese otro numero: ");
            string num2 = Console.ReadLine();

            int numero1 = int.Parse(num1);
            int numero2 = int.Parse(num2);

            int resultado = numero1 + numero2;

            Console.WriteLine("La suma de los 2 numeros ingresados, es: " + resultado);
        }
    }
}
