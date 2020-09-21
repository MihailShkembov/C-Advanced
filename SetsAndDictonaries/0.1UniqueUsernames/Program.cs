using System;
using System.Collections.Generic;

namespace _0._1UniqueUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var hashset = new HashSet<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string temp = Console.ReadLine();
                hashset.Add(temp);

            }
            foreach (var item in hashset)
            {
                Console.WriteLine(item);
            }
        }
    }
}
