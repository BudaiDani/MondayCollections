using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace StringOrganizer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string firstString = Console.ReadLine();
            Console.WriteLine("Enter another string: ");
            string secondString = Console.ReadLine();
            Console.WriteLine("Enter another string: ");
            string thirdString = Console.ReadLine();

            List<string> stringList = new List<string>();
            stringList.Add(firstString);
            stringList.Add(secondString);
            stringList.Add(thirdString);

            Console.WriteLine("The ArrayList initially contains the following values:");
            PrintValues(stringList);

            stringList.Sort();
            Console.WriteLine("After sorting:");
            PrintValues(stringList);
            Console.ReadLine();
        }

        public static void PrintValues(IEnumerable stringList)
        {
            foreach (Object obj in stringList)
                Console.WriteLine("   {0}", obj);
            Console.WriteLine();
        }
    }
}
