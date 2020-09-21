using System;
using System.Collections.Generic;

namespace _0._5_CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var dictionary = new SortedDictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                char curr = input[i];
                if (!dictionary.ContainsKey(curr))
                {
                    dictionary.Add(curr, 1);
                }
                else
                {
                    dictionary[curr]++;
                }
            }
           
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
