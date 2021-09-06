using System;

namespace PerimetroTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo triang1 = new Triangulo();
            triang1.pA = 3;
            triang1.pB = 4;
            triang1.pC = 5;
            Console.WriteLine($"Perimetro de un triangulo de lados 3, 4 y 5\nEl perimetro del triangulo es: {triang1.perimetro()}");
            // Console.ReadKey();

            Rectangulo rectang1 = new Rectangulo();
            rectang1.pA = 3;
            rectang1.pB = 5;
            Console.WriteLine($"El perimetro del rectangulo es: {rectang1.perimetro()}");
            Console.WriteLine($"La superficie del rectangulo es: {rectang1.superficie()}");

            Silo silo1 = new Silo();

            silo1.pAltura = 25;
            silo1.pDiametro = 15;
            Console.WriteLine(value: $"El volumen del silo es: {silo1.volumen}");
        
        }
    }
    //Volumen maximo de un silo. V=(pi.D°2/4).H

    class Silo
    {
        int altura, diametro;

        public int pAltura
        {
            set { altura = value; }
            get { return altura; }
        }
        public int pDiametro
        {
            set { diametro = value; }
            get { return diametro; }

        }

        public int volumen()
        {
            return (int)(((3.14 * diametro * diametro) / 4) * altura);
        }


    }



    //clase triangulo
    class Triangulo
    {
        int a, b, c;
        //propiedades
        public int pA
        {
            set { a = value; }
            get { return  a; }
        }
        public int pB
        {
            set { b = value; }
            get { return b; }
        }
        public int pC
        {
            set { c = value; }
            get { return c; }
        }
        //metodos
        public int perimetro()
        {
            return (a + b + c);
        }
    }//fin clase triangulo
    
    //calcular el perimetro y la superficie de un rectangulo de base 3 y alto 5

    class Rectangulo
    {
        int a, b;

        public int pA
        {
            set { a = value; }
            get { return a; }
        }
        public int pB
        {
            set { b = value; }
            get { return b; }
        }

        public int perimetro()
        {
            return (a * 2 + b * 2);
        }
        public int superficie()
        {
            return (a * b);
        }




    }


}
