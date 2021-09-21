using System;

namespace Propiedades //ENCAPSULAMIENTO, GET, SET
{
    class Program
    {
        static void Main(string[] args)
        {
            Caja caja = new Caja(5, 4, 10);
            Console.WriteLine("El valor del volumen es: " + caja.Volumen);
            caja.MuestraInfo();
            Console.Read();
        }
    }

    class Caja
    {
        //VARIABLES (Van con MINUSCULA)

        private int largo;
        private int alto;
        private int ancho;
        private int volumen;     


        //CONSTRUCTOR

        public Caja(int largo, int alto, int ancho)
        {
            this.Largo = largo;
            this.Alto = alto;
            this.Ancho = ancho;
        }

        
        //PROPIEDADES (Van con MAYUSCULA)

        //PROPIEDAD GET/SET, 2 ABORDAJES (AMBOS TRABAJAN IGUAL)

        
        //1) ABORDAJE LARGO

        public int Largo //Largo es una propiedad que nos proporciona acceso a la variable 'largo' que es privada y ahora es segura
        {
            get
            {
                return largo;
            }
            set
            {
                largo = value;
            }
        }


        //2) ABORDAJE CORTO (Propiedad Autoimplementada) public int Largo { get; set; }

        //DE ESTA FORMA YA NO ES NECESARIA LA VARIABLE QUE FUE DECLARADA AL COMIENZO, PODRIA NO TENERLA Y QUEESTA PROPIEDAD FUNCIONE IGUAL
        //LA PROPIEDAD SE CONVERTIRIA EN VARIABLE


        //ABORDAJE LARGO
        public int Ancho {
            get
            {
                return ancho;
            }   
            set
            {
                if (value < 0) throw new Exception("El ancho debe ser positivo");
                else
                    ancho = value;
            }       
        } 

        //ABORDAJE LARGO
        public int Alto {
            get
            {
                return alto;
            }
            set
            {
                if (value < 0) throw new Exception("El alto debe ser positivo");
                else
                    alto = value;
            }           
        }

        //ABORDAJE LARGO
        public int Volumen { 
            get
            {
                return Alto * Ancho * Largo;
            }
            set
            {
                volumen = value;
            }
        }


        // OTRA MANERA DE PLANTEAR EL GET Y SET
        
        /*
        public void SetLargo(int largo) //ES PUBLIC VOID Y NO INT PORQUE AQUI NO ESPERAMOS QUE NOS DEVUELVA NADA
        {
            this.largo = largo;
        }

        public int GetLargo() //ES PUBLIC INT PORQUE AQUI SI QUEREMOS QUE NOS DEVUELVA UN VALOR ENTERO CUANDO LO PIDAMOS
        {
            return this.largo;
        }
        */


        //METODOS

        public void MuestraInfo()
        {
            Console.WriteLine("El largo es: " + largo + ", el alto es: " + alto + ". el ancho es: " + ancho + ", por lo tanto el volumen es: " + (volumen = ancho * largo * alto));
        }
    }
}
