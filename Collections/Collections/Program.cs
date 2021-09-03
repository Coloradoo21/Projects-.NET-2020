using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> numeros = new LinkedList<int>();

            foreach (int numero  in new int[] {10, 8, 6, 4, 2, 0 })
            {
                numeros.AddLast(numero);
            }

            //numeros.Remove(6);

            LinkedListNode<int> nodoImportante = new LinkedListNode<int>(15);

            numeros.AddFirst(nodoImportante);

           /* foreach (int  numero in numeros)
            {
                Console.WriteLine(numero);
            }*/

            for (LinkedListNode<int> nodo=numeros.First; nodo !=null; nodo = nodo.Next)
            {
                int numero = nodo.Value;
                Console.WriteLine(numero);
            }
        }
    }
}
