using System;


// Programa para adivinar un numero en varios intentos con bucles.

namespace Bucles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a adivinador");
            Console.WriteLine();
            Console.WriteLine("Como te llamas?");
            string nombre = Console.ReadLine();

            Console.WriteLine($"Hola {nombre}, yo elejire un numero entre 0 y 100 y tu intentas adivinarlo");
            Console.WriteLine();
            Console.WriteLine("Introduce un numero por favor");
            int numeroIngresado = Int32.Parse(Console.ReadLine());

            Random numero = new Random();
            int numeroAleatorio = numero.Next(0, 100);

            int intentos = 0;

            while (numeroIngresado != numeroAleatorio)
            {
                if (numeroIngresado > numeroAleatorio)
                {
                    Console.WriteLine("El numero que escogiste es mayor que el mio");
                    numeroIngresado = Int32.Parse(Console.ReadLine());
                }
                else if (numeroIngresado < numeroAleatorio)
                {
                    Console.WriteLine("El numero que escogiste es menor que el mio");
                    numeroIngresado = Int32.Parse(Console.ReadLine());
                }

                intentos++;

            }

            Console.WriteLine("Felicitaciones adivinaste el numero");
            Console.WriteLine($"{nombre} lo intentaste {intentos} veces!");





            /*Console.WriteLine("Deseas entrar en el bucle while?");
            string respuesta = Console.ReadLine();
            while (respuesta != "no")
            {

                Console.WriteLine("estas ejecutando el interior del bucle while");

                Console.WriteLine("Introduce tu nombre por favor");

                string nombre = Console.ReadLine();

                Console.WriteLine($"Saldras del bucle {nombre} cuando respondas a la pregunta.");

                Console.WriteLine("Deseas repetir otra vez?");

                respuesta = Console.ReadLine();

            }*/
          //  Console.WriteLine("Has salido del bucle");
        }
    }
}
