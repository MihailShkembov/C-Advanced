using System;
using System.Collections.Generic;
using System.Linq;

namespace _0._1Lootbox
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstInput = Console.ReadLine().Split().Select(int.Parse).ToList();
            var secondInput = Console.ReadLine().Split().Select(int.Parse).ToList();
            var firstLootbox = new Queue<int>(firstInput);
            var secondLootbox = new Stack<int>(secondInput);
            int totalSum = 0;
            while (true)
            {
                int numberFromFirst = firstLootbox.Peek();
                int numberFromSecond = secondLootbox.Peek();
                int sumOfBoth = numberFromFirst + numberFromSecond;
                if (sumOfBoth%2==0)
                {
                    totalSum +=sumOfBoth;
                    firstLootbox.Dequeue();
                    secondLootbox.Pop();
                }
                else
                {
                    firstLootbox.Enqueue(secondLootbox.Pop());    
                }
                if (!firstLootbox.Any())
                {
                    Console.WriteLine("First lootbox is empty");
                    break;
                }
                else if (!secondLootbox.Any())
                {
                    Console.WriteLine("Second lootbox is empty");
                    break;
                }
            }
            if (totalSum>=100)
            {
                Console.WriteLine($"Your loot was epic! Value: {totalSum}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {totalSum}");
            }
        }
    }
}
