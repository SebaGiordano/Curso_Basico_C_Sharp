using System;

namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.ForegroundColor = ConsoleColor.DarkCyan; //CAMBIA EL COLOR DE LA LETRA
            //Console.BackgroundColor = ConsoleColor.Magenta; //PINTA EL FONDE DE LA LETRA
            //Console.Clear(); //LIMPOIA LAS INSTRUCCIONES ANTERIORES Y TOMA LAS NUEVAS ORDENES,
                             //A PARTIR DE ALLI, PUEDE PINTAR TODO EL FONDO CON EL COLOR DE LA INSTRUCCION ANTERIOR
            
            Console.WriteLine("Hello World!");
            Console.WriteLine("Mi nombre es Sebastian");
            //Console.Read();

            int num1 = 10; // int num1, num2, num3, etc
            int num2 = 5;
            int sum = num1 + num2;
            Console.WriteLine("La suma de " + num1 + " mas " + num2 + " es " + sum);

            double d1 = 3.5; // double d1, d2, d3, d4, etc
            double d2 = 10.5;
            double sumd = d1 + d2;
            Console.WriteLine("La suma de " + d1 + " mas " + d2 + " es " + sumd);

            double d3 = 3.5;
            double d4 = 10.5;
            double sum1d = d1 + num2; // SI EN VEZ DE SER DOUBLE LA VARIABLE FUESE INT, DARIA ERROR EL CALCULO PORQUE ESTAMOS SUMANDO NUMEROS
                                      // ENTEROS Y DE COMA FLOTANTE, CUANDO DECLARAMOS UNA VARIABLE INT ANTERIORMENTE
            Console.WriteLine("La suma de " + d3 + " mas " + num2 + " es " + sum1d);

            float f1 = 3.56f;
            float f2 = 22.6f;
            float sumf = f1 + f2;
            Console.WriteLine("La suma de " + f1 + " mas " + f2 + " es " + sumf);

            string MiNombre = "SEBASTIAN";
            string mensaje = "Mi nombre es " + MiNombre;
            string MensjMay = mensaje.ToUpper(); //DEVUELVE EL TEXTO DE LA VARIABLE mensaje EN MAYUSCULA
            string MensjMin = mensaje.ToLower();
            Console.WriteLine("Mi nombre es " + MiNombre);
            Console.WriteLine(mensaje);
            Console.WriteLine(MensjMay);
            Console.WriteLine(MensjMin);

            string miString = "15";
            string miSegString = "10";
            string Resultado = miString + miSegString;
            Console.WriteLine(Resultado);

            // AL MOMENTO DE TRANSFORMAR STINGS EN ENTEROS, ESTAS VATIABLES DE STRING DEBEN SER NUMEROS SIN LETRAS PARA POSRTERIOMENTE PODER PASARLAS A ENTEROS
            // POR EJEMPLO (string miString = "15"), ASI DEBERIA SER UNA VARIABLE STRING PARA PASARLA A ENTERO
            // SI FUERE ASI (string miString = "15AAAA", NO PODRIA SER POSIBLE)
            //int32 ES UNA ESTRUCTURA QUE NOS PERMITE REPRESENTAR UN ENTERO DE 32 BIT CON SIGNO. Parse ES UN METODO QUE TRADUCE UN STRING EN ENTERO
            //TryParse ES UN METODO QUE EN VEZ DE TRADUCIR UN STRING EN ENTERO, ARROJA UN VALOR BOOLEANO, PARA SABER SI ES POSIBLE CONVERTIR O NO EL STRING
            int n1 = Int32.Parse(miString); 
            int n2 = Int32.Parse(miSegString);
            int resultado = n1 + n2; 
            Console.WriteLine(resultado);

            Console.Read();
        }
    }
}
