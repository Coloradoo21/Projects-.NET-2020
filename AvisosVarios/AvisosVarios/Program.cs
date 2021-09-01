using System;

namespace AvisosVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            AvisosTrafico av1 = new AvisosTrafico();

            av1.mostrarAviso();

            AvisosTrafico av2 = new AvisosTrafico("Jefatura Provincial Madrid", "Sancion de velocidad: $300", "02-05-19");

            av2.getFecha();

            av2.mostrarAviso();


        }
    }
}
