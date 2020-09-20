using System;
using System.Collections.Generic;
using System.Linq;

namespace _0._4_FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var orders = Console.ReadLine().Split().Select(int.Parse);
            var queue = new Queue<int>(orders);
            Console.WriteLine(queue.Max());
            while (queue.Count>0)
            {
                
                if (n-queue.Peek() >=0)
                {
                    n = n - queue.Peek();
                    queue.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(' ',queue)}");
                    return;
                }
            }
            Console.WriteLine("Orders complete");
        }
    }
}
