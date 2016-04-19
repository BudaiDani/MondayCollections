using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> intLinkedList = new LinkedList<int>();
            intLinkedList.AddFirst(5);
            intLinkedList.AddAfter(intLinkedList.First,6);
            intLinkedList.AddLast(10);
            intLinkedList.AddAfter(intLinkedList.First, 15);
            foreach (int i in intLinkedList)
            {
                Console.WriteLine(i);
            }
            
            LinkedList<string> stringLinkedList = new LinkedList<string>();
            stringLinkedList.AddFirst("first");
            stringLinkedList.AddAfter(stringLinkedList.First, "afterfirst");
            stringLinkedList.AddLast("four");
            stringLinkedList.AddAfter(stringLinkedList.First, "afterfirs2");
            foreach (string s in stringLinkedList)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}
