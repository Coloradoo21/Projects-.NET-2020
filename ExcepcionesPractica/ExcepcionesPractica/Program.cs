using System;

namespace ExcepcionesPractica
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numero = new Random();

            int aleatorio = numero.Next(0, 100);

            int minumero;

            int intentos = 0;
            Console.WriteLine("Introduce un numero entre 0 y 100");

            do
            {
                intentos++;

                try
                {
                    minumero = int.Parse(Console.ReadLine());
                }
                catch(Exception e) when(e.GetType()!=typeof(FormatException))
                {

                    Console.WriteLine("Ha habido un error. Se toma como numero introducido el 0");
                    //Console.WriteLine(e.Message);

                    minumero = 0;

                }

                catch(FormatException e)
                {

                    Console.WriteLine("Has introducido texto");

                    minumero = 0;

                }

                /*catch(FormatException e)
                {

                    Console.WriteLine("Has introducido texto");

                    minumero = 0;

                }
                
                catch (OverflowException ex)
                {

                    Console.WriteLine("Has introducido un valor demasiado alto. Se toma como numero introducido el 0");
                    minumero = 0;

                }*/

                if (minumero > aleatorio) Console.WriteLine("El n° es mas bajo");

                if (minumero < aleatorio) Console.WriteLine("El n° es mas alto");

            } while (aleatorio != minumero);

            Console.WriteLine($"Correcto! Has necesitado {intentos} intentos");

            Console.WriteLine("A partir de esta linea de codigo el programa continuaria");
        }
    }
}
