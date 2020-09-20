using System;
using System.Collections.Generic;
using System.Linq;

namespace _0._7_TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int counter = 0;
            var pumps = new Queue<int[]>();
            for (int i = 0; i < N; i++)
            {
                int[] currPump = Console.ReadLine().Split().Select(int.Parse).ToArray();
                pumps.Enqueue(currPump);

            }
            while (true)
            {
                int fuelAmount = 0;
                bool foundPoint = true;
                for (int i = 0; i < N; i++)
                {
                    int[] currentPump = pumps.Dequeue();
                    fuelAmount += currentPump[0];
                    if (fuelAmount<currentPump[1])
                    {
                        foundPoint = false;
                    }
                    fuelAmount -= currentPump[1];
                    pumps.Enqueue(currentPump);
                }
                if (foundPoint)
                {
                    break;
                }
                counter++;
                pumps.Enqueue(pumps.Dequeue());
            }
            Console.WriteLine(counter);

        }
    }
}
