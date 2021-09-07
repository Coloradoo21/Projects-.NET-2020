using System;
using System.Collections.Generic;

namespace Predicados
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listaNumeros = new List<int>();
            listaNumeros.AddRange(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

            //declaramos delegado predicado

            Predicate<int> elDelegadoPred = new Predicate<int>(DamePares);

            List<int> numPares = listaNumeros.FindAll(elDelegadoPred);

            foreach (int num in numPares)
            {
                Console.WriteLine(num);
            }
        }

        static bool DamePares(int num)
        {


            if (num % 2 == 0) return true;
            else return false;

            


        }
    }
}
