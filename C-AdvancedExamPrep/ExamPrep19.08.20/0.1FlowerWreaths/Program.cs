using System;
using System.Collections.Generic;
using System.Linq;

namespace _0._1FlowerWreaths
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstInput = Console.ReadLine().Split(',',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var secondInput = Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var firstRow = new Stack<int>(firstInput);
            var secondRow = new Queue<int>(secondInput);
            int sumForLater = 0;
            int wreaths = 0;
            while (firstRow.Any()&&secondRow.Any())
            {
                int sumOfBoth = firstRow.Pop() + secondRow.Dequeue();
                if (sumOfBoth==15)
                {
                    wreaths++;
                }
                else if (sumOfBoth<15)
                {
                    sumForLater += sumOfBoth;
                }
                else if (sumOfBoth>15)
                {
                    while (true)
                    {
                        sumOfBoth -= 2;
                        if (sumOfBoth==15)
                        {
                            wreaths++;
                            break;
                        }
                        if (sumOfBoth < 15)
                        {
                            sumForLater += sumOfBoth;
                            break;
                        }
                    }
                }
            }
            wreaths += sumForLater / 15;
            if (wreaths<5)
            {
                Console.WriteLine($"You didn't make it, you need {5-wreaths} wreaths more!");
            }
            else
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreaths} wreaths!");
            }
        }
    }
}
