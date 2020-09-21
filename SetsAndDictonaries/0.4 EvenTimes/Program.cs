using System;
using System.Collections.Generic;
namespace _0._4_EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dictionary = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                int temp =int.Parse( Console.ReadLine());
                if (!dictionary.ContainsKey(temp))
                {
                    dictionary.Add(temp, 1);
                }
                else
                {
                    dictionary[temp]++;
                }
            }
            foreach (var item in dictionary)
            {
                if (item.Value%2==0)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}
