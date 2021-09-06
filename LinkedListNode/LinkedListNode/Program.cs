using System;
using System.Collections.Generic;

namespace LinkedListNode
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a new linked list node of type string and display its properties

            LinkedListNode<string> lln = new LinkedListNode<string>("Orange");
            Console.WriteLine("After creating this nde....");
            DisplayProperties(lln);

            //Create a new linded list

            LinkedList<string> ll = new LinkedList<string>();

            //add the orange node and display its properties

            ll.AddLast(lln);
            Console.WriteLine("After adding the node to the empty linked list....");
            DisplayProperties(lln);

            //add nodes before and after the "orange" node and display the "orange" nodes properties.

            ll.AddFirst("Red");
            ll.AddLast("Blue");
            Console.WriteLine("After adding red and blue....");
            DisplayProperties(lln);

        }

        private static void DisplayProperties(LinkedListNode<string> lln)
        {
            if (lln.List==null)
                Console.WriteLine("Node is not linked.");
            else
                Console.WriteLine("Node belons to a linked list with {0} elements.",lln.List.Count);

            if (lln.Previous==null)
                Console.WriteLine("Previous node is null");
            else
                Console.WriteLine("Value of previous node: {0}", lln.Previous.Value);

                Console.WriteLine("Value of current node: {0}",lln.Value);

            if (lln.Next==null)
                Console.WriteLine("Next node is null");

            else
                Console.WriteLine("Value of the next node: {0}",lln.Next.Value);

            Console.WriteLine();


            
            
            
        }
    }
}
