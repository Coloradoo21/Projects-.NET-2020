using System;

namespace Practica_Metodos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Suma(7,5.3));

           /* MensajeEnPantalla();

            Console.WriteLine(sumaNumeros(7, 5));

            Console.WriteLine("Y dividir: ");

            Console.WriteLine(dividirNumeros(18, 7));*/
        }

        static int Suma(int operador1, int operador2) => operador1 + operador2;

        static int Suma(int numero1, double numero2) => numero1;

        static int Suma(int numero1, int numero2, int numero3, int numero4) => numero1 + numero2;

        



        
        /*void primerMetodo()
        {

            int numero1 = 5;
            int numero2 = 7;

            Console.WriteLine(numero1 + numero2);
        }

        void segundoMetodo()
        {

            Console.WriteLine(numero1+numero2);


        }
        static void MensajeEnPantalla()
        {

        Console.WriteLine("A continuacion vamos a sumar dos numeros");

        }
        static void sumaNumeros(int num1, int num2)
        {

            Console.WriteLine($"La suma entre los numeros es: {num1 + num2}");


        }

        static int sumaNumeros(int num1, int num2)
        {

            return num1 + num2;


        }
        static double dividirNumeros(double num3, int num4)

        {

            return num3 / num4;


        }*/

    }
}
