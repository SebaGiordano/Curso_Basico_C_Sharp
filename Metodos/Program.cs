using System;

namespace Metodos

    // UN METODO ES UN BLOQUE DE CODIGO QUE CONTIRENE UNA SERIE DE INSTRUCCIONES. UN PROGRAMA HACE QUE SE EJECUTEN LAS INSTRUCCIONES AL LLAMAR AL METODO
    // Y ESPECIFICANDO LOS ARGUMENTOS DE METODOS NECESARIOS. EN C# TODAS LAS INSTRUCCIONES EJECUTADAS SE REALIZAN EN EL CONTEXTO DE UN METODO.
    // EL METODO Main ES EL PUNTO DE ENTRADA PARA CADA APLICACION DE C# Y SE LLAMA MEDIANTE Common Language Runtime (CLR) CUANDO SE INICIA EL PROGRAMA

    // METODOS DEL TIPO void
{
    class Program
    {
        static void Main(string[] args)
        {
            EscribeAlgo();
            EscribeAlgoEspecifico("Soy un argumento y me llamaron desde un metodo");
            Console.Read();
        }

        // ESTRUCTURA QUE SIEMPRE DEBE CUMPLIRSE AL CONSTRUIR UN METODO:
        // Nivel de acceso - (static) si queremos que el metodo sea llamdo desde Main - Tipo de retorno - Nombre del metodo (Parametro1, Parametro2)
        // static, es una declaracion de que este metodo no pertenece a un objeto.
        // CUANDO VAS A LLAMAR UN METODO DESDE EL METODO Main, DEBE APARECER LA PALABRA STATIC EN EL METODO NUEVO CREADO QUE LUEGO SERA LLAMADO
        // METODOS SIN RETORNO

        public static void EscribeAlgo()
        {
            Console.WriteLine("Yo naci en un metodo");
        }

        public static void EscribeAlgoEspecifico(string miTexto)
        {
            Console.WriteLine(miTexto);
        }

    }
}
