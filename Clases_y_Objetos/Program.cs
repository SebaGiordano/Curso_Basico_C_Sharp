using System;

namespace Clases_y_Objetos //CLASES Y OBJETOS, CONSTRUCTORES, MULTIPLES CONSTRUCTORES
{
    class Program
    {
        static void Main(string[] args)
        {
            //CREA UN ONJETO DESDE MI CLASE
            //UNA INSTANCIA DE HUMANO
            //Humano juan = new Humano();

            //AQUI SE ACCEDE A UNA VARIABLE PUBLICA DE LA CLASE HUMANO
            //juan.primerNombre = "Juancho";
            //juan.primerApellido = "Perez";

            //AQUI SE ACCEDE A UN METODO PUBLICO DE LA CLASE HUMANO
            //juan.presentarme();

            //Console.WriteLine();

            //Humano pedro = new Humano();
            //pedro.primerNombre = "Pedrito";
            //pedro.primerApellido = "Santos";
            //pedro.presentarme();


            //OTRA FORMA DE PLANTEAR LOS OBJETOS CREADOS, ESTA VEZ CON EL CONSTRUCTOR, A TRAVES DE PARAMETROS         
            //Humano laura = new Humano("Laura", "Lopez", 1, "Celeste");
            //Humano franco = new Humano("Franco", "Milano", 30, "Marron");

            //laura.presentarme();
            //franco.presentarme();

            
            //EJEMPLO DE HABER CREADO VARIOS CONSTRUCTORES PARA LAS POSIBLES CONSTRUCCIONES DE OBJETOS CON MAS Y MENOS PARAMETROS
            Humano humanoBasico = new Humano("Juana", "Lopez",10, "Azul");

            Humano nico = new Humano("Nikolas");

            Humano pedro = new Humano("Pedro", "Perez");

            Humano maria = new Humano("Maria", "Lopez", "Marron");

            Humano mariano = new Humano();

            humanoBasico.presentarme();
            nico.presentarme();
            pedro.presentarme();
            maria.presentarme();
            mariano.presentarme();

            Console.Read();
        }
    }

    class Humano
    {
        // MIEMBRO VARIABLE
        //UNA VEZ CREADO EL CONSTRUCTOR, LAS VARIABLES PUEDEN DEJAR DE SER PUBLICAS Y COMENZAR A SER PRIVADAS
        public string primerNombre; // PRIVATE string primerNombre;
        public string primerApellido; // PRIVATE string primerApellido;
        public string colorOjos; // PRIVATE string colorOjos;
        public int edad; //  PRIVATE int edad;


        //MIEMBRO CONSTRUCTOR PARAMETRIZADO
        public Humano(string primerNombre, string primerApellido, int edad, string colorOjos)
        {
            this.primerNombre = primerNombre;
            this.primerApellido = primerApellido;
            this.edad = edad;
            this.colorOjos = colorOjos;
        }


        //CONSTRUCTOR POR DEFECTO
        public Humano()
        {
            Console.WriteLine("CONSTRUCTOR POR DEFECTO");
        }

        //MIEMBRO CONSTRUCTOR PARAMETRIZADO, PERO CON MENOS PARAMETROS
        public Humano(string primerNombre, string primerApellido, string colorOjos)
        {
            this.primerNombre = primerNombre;
            this.primerApellido = primerApellido;
            this.colorOjos = colorOjos;
        }

        public Humano(string primerNombre, string primerApellido)
        {
            this.primerNombre = primerNombre;
            this.primerApellido = primerApellido;
        }

        public Humano(string primerNombre)
        {
            this.primerNombre = primerNombre;
        }


        //MIEMBRO METODO
        public void presentarme()
        {
            if (edad != 0 && primerNombre != null && primerApellido != null && colorOjos != null)
            {
                if (edad == 1)
                {
                    Console.WriteLine("Hola, mi nombre y apellido es " + primerNombre + " " + primerApellido + ", tengo " + edad + " año y el color de mis ojos es " + colorOjos);
                }
                else
                    Console.WriteLine("Hola, mi nombre y apellido es " + primerNombre + " " + primerApellido + ", tengos " + edad + " años y el color de mis ojos es " + colorOjos);
            }
            else if (primerNombre != null && primerApellido != null && colorOjos != null)
                Console.WriteLine("Hola, mi nombre y apellido es " + primerNombre + " " + primerApellido + " y el color de mis ojos es " + colorOjos);
            else if (primerNombre != null && primerApellido != null)
                Console.WriteLine("Hola, mi nombre y apellido es " + primerNombre + " " + primerApellido);
            else if (primerNombre != null)
                Console.WriteLine("Hola, mi nombre es " + primerNombre);

        }
    }
}
