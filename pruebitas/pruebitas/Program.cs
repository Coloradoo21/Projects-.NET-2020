using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebitas
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1, num2;
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");
            Console.WriteLine("Ingrese un numero, luego presione enter.");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese otro numero, luego presione enter.");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Your option? ");

            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Tu resultado: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Tu resultado: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Tu resultado: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"Tu resultado: {num1} / {num2} = " + (num1 / num2));
                    break;
            }
            Console.WriteLine("Presione tecla cualquiera para cerrar");
            Console.ReadKey();
        }
    }

    class ConcatenacionCorrecta
    {
        private void concatenaString()
        {

            StringBuilder cadena = new StringBuilder();
            List<int> numeros = new List<int>() { 1, 2, 3, 4 };

            foreach (var numero in numeros)
            {
                cadena.Append(numero);
            }
        }
    }
        
        
}


    