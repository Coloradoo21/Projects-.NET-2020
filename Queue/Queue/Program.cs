using System;
using System.Collections.Generic;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Dictionary<string, int> edades = new Dictionary<string, int>();

            //Rellenar diccionario

            edades.Add("Alberto", 50);
            edades.Add("Juliana", 24);

            edades["Maria"] = 35;
            edades["Erwin"] = 26;

            //recorrer el diccionario

            foreach (KeyValuePair <string,int> persona in edades)
            {
                Console.WriteLine("Nombre: {0} Edad: {1}",persona.Key, persona.Value);
            }*/

            Queue<string> numbers = new Queue<string>();
            numbers.Enqueue("One");
            numbers.Enqueue("Two");
            numbers.Enqueue("Three");
            numbers.Enqueue("Four");
            numbers.Enqueue("Five");

            //A Queue can be enumerated without disturbing its contents.

            foreach (string number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("\nDequeuing '{0}'",numbers.Dequeue());
            Console.WriteLine("Peek at next item to dequeue: {0}", numbers.Peek());
            Console.WriteLine("Dequeuing '{0}'",numbers.Dequeue());

            //create a copy of the queue, using the ToArray method and the construct that accepts an IEnumerable<T>

            Queue<string> queueCopy = new Queue<string>(numbers.ToArray());

            Console.WriteLine("\nContents of the first copy");
            foreach (string number in queueCopy)
            {
                Console.WriteLine(number);
            }

            //create an array twice the size of the queue and copy the elements of the queue, starting at middle of the array

            string[] array2 = new string[numbers.Count * 2];
            numbers.CopyTo(array2, numbers.Count);

            //create a second queue, using the constructor that accepts an IEnumerable(of T)

            Queue<string> queueCopy2 = new Queue<string>(array2);

            Console.WriteLine("\nContents of second copy with duplicant and nulls:");
            foreach (string number in queueCopy2)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("\nqueueCopy.Contains(\"Four\") = {0}",queueCopy.Contains("Four"));

            Console.WriteLine("\nqueueCopy.Clear()");
            queueCopy.Clear();
            Console.WriteLine("\nqueueCopy.Count = {0}", queueCopy.Count);




           









        }
    }
}
