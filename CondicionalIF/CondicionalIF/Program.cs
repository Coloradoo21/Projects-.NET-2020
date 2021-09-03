using System;
using System.Dynamic;

namespace CondicionalIF
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Introduce tu edad");

            int edad = Int32.Parse(Console.ReadLine());

            if (edad < 18) Console.WriteLine("Eres un niño");
            
           else if (edad < 30) Console.WriteLine("Eres joven");

           else if (edad < 60) Console.WriteLine("Eres maduro");

            else Console.WriteLine("Deber cuidarte ya");












            /*string carnet="no";
            Console.WriteLine("Vamos a evaluar si puedes conducir un vehiculo");
            Console.WriteLine("Introduce tu edad por favor");
            int edad = Int32.Parse(Console.ReadLine());

            if (edad >= 18)
            {

                Console.WriteLine("Tienes carnet?");
                carnet = Console.ReadLine();
            }
            if(edad >=18 && carnet == "si")
                Console.WriteLine("puedes conducir");
            else Console.WriteLine("no puedes conducir vehiculos");
            


            
             bool haceFrio;
            haceFrio = false;

            Console.WriteLine(haceFrio);*/




        }
    }
}
