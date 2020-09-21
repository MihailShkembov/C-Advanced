using System;
using System.Collections.Generic;

namespace _0._3_Pr
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var hashset = new SortedSet<string>();
            for (int i = 0; i < n; i++)
            {
                string[] cmd = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int k = 0; k < cmd.Length; k++)
                {
                    hashset.Add(cmd[k]);
                }
            }
            Console.WriteLine(string.Join(" ",hashset));
        }
    }
}
