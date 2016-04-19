using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextNumsToNumerals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your number with alphabetical chars:");
            string input = Console.ReadLine();
            Console.WriteLine("Your number with numerals:");
            Console.WriteLine(ShowIntPair(input));
            Console.ReadLine();
        }
                
        static int ShowIntPair(string numberKey)
        {
            Dictionary<string, int> stringDictionary = new Dictionary<string, int>();
            stringDictionary.Add("zero", 0);
            stringDictionary.Add("one", 1);
            stringDictionary.Add("two", 2);
            stringDictionary.Add("three", 3);
            stringDictionary.Add("four", 4);
            stringDictionary.Add("five", 5);
            stringDictionary.Add("six", 6);
            stringDictionary.Add("seven", 7);
            stringDictionary.Add("eight", 8);
            stringDictionary.Add("nine", 9);

            if (stringDictionary.ContainsKey(numberKey.ToLower()))
            {
                return stringDictionary[numberKey];
            }
            return -1;
        }
    }
}
