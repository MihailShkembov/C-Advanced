using System;
using System.Collections.Generic;
using System.Linq;

namespace _0._2SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var hashsetN = new HashSet<int>();
            var hashsetM = new HashSet<int>();
            int[] nm = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = nm[0];
            int m = nm[1];
            for (int i = 0; i < n; i++)
            {
                hashsetN.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < m; i++)
            {
                hashsetM.Add(int.Parse(Console.ReadLine()));
            }

            if (n > m)
            {
                foreach (var item in hashsetM)
                {
                    if (hashsetN.Contains(item))
                    {
                        Console.Write($"{item} ");
                    }
                }
            }
            else
            {
                foreach (var item in hashsetN)
                {
                    if (hashsetM.Contains(item))
                    {
                        Console.Write($"{item} ");
                        }
                }
            }
        }
    }
}
