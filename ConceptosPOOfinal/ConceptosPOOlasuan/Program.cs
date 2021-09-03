using System;

/*using static System.Math;

using static System.Console;*/

namespace ConceptosPOOlasuan
{
    class Program
    {
        static void Main(string[] args)
        {
            // realizarTarea();

            /*double raiz = Sqrt(9);

            double potencia = Pow(3, 4);

            WriteLine(raiz);
            WriteLine(potencia);*/

            var miVariable = new { Nombre = "Erwin", Edad = 25 };
            Console.WriteLine(miVariable.Nombre+" "+miVariable.Edad);

            var miOtraVariable = new { Nombre = "Romi", Edad = 22 };
            miVariable = miOtraVariable;
        }

        static void realizarTarea()
        {

            Punto origen = new Punto();

            Punto destino = new Punto(128, 80);

            Punto otroPunto = new Punto();

            double distancia = origen.DistanciaHasta(destino);

            Console.WriteLine($"La distancia entre los puntos es de: {distancia}");

            Console.WriteLine($"Numero de objetos creados: {Punto.ContadorDeObjetos()}");
        }



    }
}
