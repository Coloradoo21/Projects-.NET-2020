using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce n° de mes para calculo de la comision");

            int nMes=Int32.Parse (Console.ReadLine());

            switch(nMes)
            {

                case 1:
                    Console.WriteLine("Mes escogido: enero");
                    break;

                case 2:
                    Console.WriteLine("Mes escogido: febrero");
                    break;

                case 3:
                    Console.WriteLine("Mes escogido: marzo");
                    break;

                case 4:
                    Console.WriteLine("Mes escogido: abril");
                    break;

                case 5:
                    Console.WriteLine("Mes escogido: mayo");
                    break;

                case 6:
                    Console.WriteLine("Mes escogido: junio");
                    break;

                case 7:
                    Console.WriteLine("Mes escogido: julio");
                    break;

                case 8:
                    Console.WriteLine("Mes escogido: agosto");
                    break;

                case 9:
                    Console.WriteLine("Mes escogido: septiembre");
                    break;

                case 10:
                    Console.WriteLine("Mes escogido: octubre");
                    break;

                case 11:
                    Console.WriteLine("Mes escogido: noviembre");
                    break;

                case 12:
                    Console.WriteLine("Mes escogido: diciembre");
                    break;

                default:
                    Console.WriteLine("Mes incorrecto");
                    break;


            }

            /*switch(medioTransporte)
            {

                case "coche":
                    Console.WriteLine("Velocidad media: 100km/h");
                    break;

                case "tren":
                    Console.WriteLine("Velocidad media: 250 km/h");
                    break;

                case "avion":
                    Console.WriteLine("Velocidad media: 800 km/h");
                    break;

                default: Console.WriteLine("Transporte no contemplado");
                    break;

             }*/

            Console.WriteLine("Ha terminado el programa");
        }
    }
}
