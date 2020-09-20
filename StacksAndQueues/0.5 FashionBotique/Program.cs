using System;
using System.Collections.Generic;
using System.Linq;

namespace _0._5_FashionBotique
{
    class Program
    {
        static void Main(string[] args)
        {
            var boxes = Console.ReadLine().Split().Select(int.Parse);
            int capacity = int.Parse(Console.ReadLine());
            var stack = new Stack<int>(boxes);
            int capacityLeft = 16;
            int shelves = 1;
            while (stack.Any())
            {
                //5 4 8 6 3 8 7 7 9
                // 16
               


                int first = stack.Pop();
                capacityLeft -= first;
                if (capacityLeft<=0)
                {
                    shelves++;
                    capacityLeft = capacity - first;
                }
                
                

            }
            Console.WriteLine(shelves);
        }
    }
}
