using System;

namespace Break_and_Continue //ELEMENTOS PARA TRABAJAR CON LOOPS (BREAK AND CONTINUE)
{
    class Program
    {
        static void Main(string[] args)
        {
            // B R E A K 

            //ESTE ELEMENTO DETIENE/CORTA EL CICLO EN UN MOMENTO DETERMINADO Y FIJADO EN EL BUCLE. CORTA EL CICLO ANTES QUE EL MISMO LLEGUE A SU FIN.
            
            for (int contador = 0; contador < 10; contador++)
            {
                Console.WriteLine(contador);
                if (contador == 3)
                {
                    Console.WriteLine("Al numero 3 se detiene el programa!");
                    break;
                }
            }

            Console.WriteLine("--------------------------------------------");

            // C O N T I N U E

            //CONTINUE NO HACE QUE EL CICLO SIGA POR DONDE VENIA, HACE QUE SE CORTE LA VUELTA QUE ESTABA DANDO EL LOOP, Y VAYA
            //DESDE ALLI DIRECTAMENTE AL SIGUIENTE INGRESO DEL FOR. ES DECIR, QUE NO CONTINUO EJECUTANDO LO QUE SEGUIA EN EL LOOP LUEGO DEL CONTINUE.
            //POR LO TANTO NO IMPRIMIO EL CONTADOR CUANDO TENIA EL VALOR DE 3, Y ES POR ESE MOTIVO QUE EN ESTE EJERCICIO NO IMPRIME EL NUMERO 3.

            for (int contador = 0; contador < 10; contador++)
            {   
                if (contador == 3)
                {
                    Console.WriteLine("El numero 3 es salteado!");
                    continue;
                }
                Console.WriteLine(contador);
            }

            Console.WriteLine("--------------------------------------------");

            // OTRA VARIACION MAS DEL CONTINIUE

            for (int contador = 0; contador < 10; contador++)
            {
                if (contador %2 == 0)
                {
                    Console.WriteLine("EL NUMERO " + contador + " ES PAR, EL PROXIMO ES IMPAR!");
                    continue;
                }
                Console.WriteLine(contador);
            }

            Console.Read();
        }
    }
}
