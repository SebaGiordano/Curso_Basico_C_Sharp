using System;

namespace Declaracion_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cuantos autos tiene: ");
            int cantAutos = Convert.ToInt32(Console.ReadLine()); // CONVERT.TOINT32, CONVIERTE EL VALOR INGRERSADO POR EL USUARIO
                                                                 // EN UN 'INT 32' PARA PODER SER GUARDADO EN 'INT'
            Console.WriteLine();
            
            switch (cantAutos) //SWITCH SIRVE PARA LA TOMA DE DESICIONES. ES UNA ALTERNATIVA MAS AL IGUAL QUE EL IF.
            {
                case 0:
                    Console.WriteLine("Unted no adeuda impuestos");
                    break;
                case 1:
                    Console.WriteLine("Unted adeuda $15 de impuestos");
                    break;
                case 2:
                    Console.WriteLine("Unted adeuda $30 de impuestos");
                    break;
                case 3:
                    Console.WriteLine("Unted adeuda $50 de impuestos");
                    break;
                default:
                    Console.WriteLine("Unted adeuda $50 de impuestos por vehiculo");
                    break;

            }

            Console.WriteLine();

            // MISMO EJERCICIO CON SWITCH AND IF

            if (cantAutos == 0)
            {
                Console.WriteLine("Unted no adeuda impuestos");
            }
            else if (cantAutos == 1)
            {
                Console.WriteLine("Unted adeuda $15 de impuestos");
            }
            else if (cantAutos == 2)
            {
                Console.WriteLine("Unted adeuda $30 de impuestos");
            }
            else if (cantAutos == 3)
            {
                Console.WriteLine("Unted adeuda $50 de impuestos");
            }
            else
            {
                Console.WriteLine("Unted adeuda $50 de impuestos por vehiculo");
            }

            Console.WriteLine();
            Console.WriteLine("Jugaremos piedra-papel-tijera");
            Console.WriteLine("Usted debe elegir por piedra / papel / tijera: ");
            string pierdaPapelTijera = Console.ReadLine();

            Console.WriteLine();

            switch (pierdaPapelTijera)
            {
                case "piedra":
                    Console.WriteLine("Piedra mata a tijera");
                    break;
                case "papel":
                    Console.WriteLine("Papel mata a piedra");
                    break;
                case "tijera":
                    Console.WriteLine("Tijera mata a papel");
                    break;
                default:
                    Console.WriteLine("Unted ha ingresado un valor incorrecto");
                    break;
            }

            Console.Read();
        }
    }
}
