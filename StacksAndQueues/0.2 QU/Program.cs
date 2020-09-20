using System;
using System.Collections.Generic;
using System.Linq;

namespace _0._2_QU
{
    class Program
    {
        static void Main(string[] args)
        {
            var xyz = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var output = Console.ReadLine().Split().Select(int.Parse).ToList();
            var queue = new Queue<int>();
            for (int i = 0; i < xyz[0]; i++)
            {
                queue.Enqueue(output[i]);

            }
            for (int i = 0; i < xyz[1]; i++)
            {
                queue.Dequeue();
            }
            if (queue.Contains(xyz[2]))
            {
                Console.WriteLine("true");
                return;
            }
            else
            {
                if (!queue.Any())
                {
                    Console.WriteLine("0");
                }
                else
                {
                    Console.WriteLine(queue.Min());
                }
            }




        }
    }
}
    

