using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Stack stack = new Stack();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(" Write here an int: ");
                stack.Push(Int32.Parse(Console.ReadLine()));
            }

            Console.ReadLine();

            foreach (int item in stack)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
