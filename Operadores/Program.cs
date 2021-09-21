using System;

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 5;
            double num2 = 3;
            double num3;

            // OPERADORES UNARIOS

            num3 = -num1;
            Console.WriteLine("El valor de num3 es igual a {0}", num3);

            bool haySol = true;
            Console.WriteLine("Hay sol? {0}", !haySol); //EL SIGNO DE EXCLAMACION CAMBIA EL VALOR BOOLEANO

            // OPERADORES DE ADICION

            int num = 0;
            num++;
            Console.WriteLine("Num es igual a: " + num);
            Console.WriteLine("Num es igual a: " + num++); //AQUI ESTARIAMOS ADICIONANDO UN VALOR MAS A NUM, CUANDO LOS OPERADORES + SE AGREGAN A LA DERECHA DE LA VARIABLE,
                                                           //ESE VALOR ADICIONADO SE AGREGA RECIEN EN LA PROXIMA IMPRESION
            Console.WriteLine("Num es igual a: " + num); // AQUI SE AGREGA EL VALOR DE ARRIBA

            // OPERADORES DE SUSTRACCION

            num--;
            Console.WriteLine("Num es igual a: " + num);
            Console.WriteLine("Num es igual a: " + --num); //CUANDO LOS OPERADORES SE ADICIONAN A LA IZQUIERDA DE LA VARIABLE, LA VARIABLE QUE SE MIDIFICA
                                                           //SEA SUMA O RESTA, ES ESA MISMA Y NO LA QUE LE SIGUE A CONTINUACION
            Console.WriteLine("Num es igual a: " + num);

            //OPERADORES MATEMATICOS

            double resultado1 = num1 + num2;
            Console.WriteLine("El resultado de " + num1 + " + " + num2 + " es: " + resultado1);
            double resultado2 = num1 - num2;
            Console.WriteLine("El resultado de " + num1 + " - " + num2 + " es: " + resultado2);
            double resultado3 = num1 * num2;
            Console.WriteLine("El resultado de " + num1 + " * " + num2 + " es: " + resultado3);
            double resultado4 = num1 / num2;
            Console.WriteLine("El resultado de " + num1 + " / " + num2 + " es: " + resultado4);

            // OPERADOR MODULAE

            double resultado5 = num1 % num2;
            Console.WriteLine("El resultado de " + num1 + " % " + num2 + " es: " + resultado5);

            // OPERADOR RELACIONAL

            bool esMenor;
            esMenor = num1 < num2;
            Console.WriteLine("El resultado de " + num1 + " < " + num2 + " es: " + esMenor);

            // OPERADORES DE IGUALDAD

            bool esIgual;
            esIgual = num1 == num2;
            Console.WriteLine("El resultado de " + num1 + " == " + num2 + " es: " + esIgual);

            esIgual = num1 != num2;
            Console.WriteLine("El resultado de " + num1 + " != " + num2 + " es: " + esIgual);

            // OPERADORES CONDICIONALES

            // "Y" AMBAS DEBEN SER TRUE

            bool esMenorYSoleado;
            esMenorYSoleado = esMenor && haySol;
            Console.WriteLine("El resultado de " + esMenor + " && " + haySol + " es: " + esMenorYSoleado);

            // "O" UNA DE ELLA DEBE SER TRUE

            esMenorYSoleado = esMenor || haySol;
            Console.WriteLine("El resultado de " + esMenor + " || " + haySol + " es: " + esMenorYSoleado);

            Console.Read();
        }
    }
}
