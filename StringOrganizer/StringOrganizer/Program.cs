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
            ArrayList stringList = new ArrayList();
            stringList.Add("one");
            stringList.Add("two");
            stringList.Add("three");
            stringList.Add("four");
            stringList.Add("five");

            foreach (string item in OrganizeStrings(stringList))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            foreach (string s in OrganizeStringsInGenericStorage(stringList))
            {
                Console.WriteLine(s);
            }

            Console.ReadLine();
        }

        static ArrayList OrganizeStrings(ArrayList arrayList)
        {
            arrayList.Sort();
            return arrayList;
        }

        static List<string> OrganizeStringsInGenericStorage(ArrayList arrayList)
        {
            List<string> myList = new List<string>(arrayList.Cast<string>().ToList());
            myList.Sort();
            return myList;
        }
    }
}
