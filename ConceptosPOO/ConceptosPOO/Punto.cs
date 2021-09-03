using System;
using System.Collections.Generic;
using System.Text;

namespace ConceptosPOO
{
    class Punto
    {

        private int x, y;

        public Punto (int x, int y)
        {
            this.x = x;
            this.y = y;

          //Console.WriteLine($"Coordenada x: {x}, Coordenada y: {y}");


        }

        public double DistanciaHasta(Punto otroPunto)
        {

            int xDif = this.x - otroPunto.x;

            int yDif = this.y - otroPunto.y;

            double distanciaPuntos= Math.Sqrt(Math.Pow(xDif,2)+Math.Pow(yDif,2));

            return distanciaPuntos;

        }
        public Punto()
        {

            this.x = 0;
            this.y = 0;

           //onsole.WriteLine("Este es el construcutor por defecto");


        }


    }
}
