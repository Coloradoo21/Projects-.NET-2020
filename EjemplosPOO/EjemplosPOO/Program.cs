using System;

namespace EjemplosPOO
{
    class Program
    {
        static void Main(string[] args)
        {

            ConversorEuroDolar obj = new ConversorEuroDolar();

            Console.WriteLine(obj.Convierte(50));

            obj.euro = 1.45;
            
            Circulo miCirculo;//Creacion de objeto de tipo circulo, variable/objeto de tipo circulo.

            miCirculo = new Circulo();//Iniciacion de variable objeto de tipo circulo.Instanciar una clase
            //Instanciacion. Ejemplarizacion. Creacion de ejemplar de clase.

            Console.WriteLine(miCirculo.CalculoArea(5));

            Circulo miCirculo2 = new Circulo();

            Console.WriteLine(miCirculo2.CalculoArea(9));

            

        }
    }

    class Circulo
    {

        private const double pi = 3.1416;     //propiedad de la clase circulo. Campo de clase.

        public double CalculoArea(int radio)  //Metodo de clase. Que hacen los objetos de tipo circulo.
        {

            return pi * radio * radio;

        }

    }

    class ConversorEuroDolar
    {

        public double euro = 1.253;

        public double Convierte(double cantidad)
        {

            return cantidad * euro;

        }

        public void CambiaValorEuro(double nuevoValor)
        {
            if (nuevoValor < 0) euro = 1.253;

            else 
            euro = nuevoValor;

        }


    }
}
