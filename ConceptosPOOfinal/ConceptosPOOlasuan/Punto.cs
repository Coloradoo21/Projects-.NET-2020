using System;
using System.Collections.Generic;
using System.Text;

namespace ConceptosPOOlasuan
{
    class Punto
    {

        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
            contadorDeObjetos++;
            // Console.WriteLine($"Coordenada x: {x}, coordenada y: {y}");
        }

        public Punto()
        {

            this.y = 0;
            this.x = 0;
            contadorDeObjetos++;
            //Console.WriteLine("este es el constructor por defecto");

        }

        public double DistanciaHasta(Punto otroPunto)
        {
            int xDif = this.x - otroPunto.x;

            int yDif = this.y - otroPunto.y;

            double distanciaPuntos = Math.Sqrt(Math.Pow(xDif, 2) + Math.Pow(yDif, 2));

            return distanciaPuntos;
        }


        private int x, y;

        private static int contadorDeObjetos = 0;

        /*public static int ContadorDeObjetos()
        {
            return contadorDeObjetos;
        }*/

        public static int ContadorDeObjetos() => contadorDeObjetos;

        public const int constantePrueba = 7;


    }
}
