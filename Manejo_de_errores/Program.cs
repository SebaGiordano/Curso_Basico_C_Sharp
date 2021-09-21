using System;

namespace Manejo_de_errores
{
    class Program
    {
        static void Main(string[] args)
        {
            Calcular();
            Console.Read();
        }

        public static void Calcular()
        {
            Console.WriteLine("Por favor, ingrese un numero: ");
            string valorIngresado1 = Console.ReadLine();

            Console.WriteLine("Por favor, ingrese otro numero: ");
            string valorIngresado2 = Console.ReadLine();

            int resultado;

            //int num1 = 5;
            //int num2 = 0;
            //int resultado;

            //try
            //{
                //resultado = num1 / num2;
            //}
            //catch (DivideByZeroException)
            //{
                //Console.WriteLine("No se puede dividir por 0!");
            //}

            try
            {
                int valoringresadoint1 = int.Parse(valorIngresado1);
                int valoringresadoint2 = int.Parse(valorIngresado2);
                resultado = valoringresadoint1 / valoringresadoint2;
                Console.WriteLine("El resultado de dividir " + valorIngresado1 + " por " + valorIngresado2 + " , es: " + resultado);
            }

            catch (FormatException)
            {
                Console.WriteLine("El formato del valor ingresado es incorrecto!");
            }

            catch (OverflowException)
            {
                Console.WriteLine("El numero ingresado es demasiado largo o demasiado corto!");
            }

            catch (ArgumentNullException)
            {
                Console.WriteLine("No se ha ingresado ningun valor!");
            }

            finally
            {
                Console.WriteLine("Esta frase aparecera pase lo que pase!");
            }

            Console.Read();
        }
    }
}
