using System;
using System.Runtime.CompilerServices;

namespace UsoCoches
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche coche1 = new Coche(); //crear objeto de tipo coche y dar un estado inicial a nuestro coche.

            Coche coche2 = new Coche();

            Console.WriteLine(coche2.getInfoCoche());
            Console.WriteLine(coche2.getInfoCoche());

            Coche coche3 = new Coche(4500.25, 12.35);

            Console.WriteLine(coche3.getInfoCoche());

            coche3.setExtras(true, "cuero");

            Console.WriteLine(coche3.getExtras());
        }
    }

    partial class Coche
    {

        public Coche()
        {
            rueda = 4;

            largo = 2300.5;

            ancho = 0.800;

            tapiceria = "tela";
        }

        public Coche(double largoCoche, double anchoCoche)
        {

            rueda = 4;
            largo = largoCoche;
            ancho = anchoCoche;
            tapiceria = "tela";

        }
    }

    //------------------------------------------------------------------------------------------------------------------------------
    partial class Coche 
    { 

        public string getInfoCoche()
        {
            return "Informacion del coche:\n"+"Ruedas: " + rueda + "\nLargo: "+ largo +"\nAncho: "+ ancho;
        }

        public void setExtras(bool climatizador, string tapiceria)
        {
            this.climatizador = climatizador;

            this.tapiceria = tapiceria;

        }


        public string getExtras()
        {

            return "Extras del coche; \n" + "Tapiceria: " + tapiceria + " Climatizador: " + climatizador;

        }

        private int rueda;

        private double largo;

        private double ancho;

        private bool climatizador;

        private String tapiceria;


    }
}
