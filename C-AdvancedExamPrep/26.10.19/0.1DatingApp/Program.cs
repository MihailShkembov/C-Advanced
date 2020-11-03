using System;
using System.Collections.Generic;
using System.Linq;

namespace _0._1DatingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var maleInput = Console.ReadLine().Split().Select(int.Parse).ToList();
            var femaleInput = Console.ReadLine().Split().Select(int.Parse).ToList();
            var male = new Stack<int>(maleInput);
            var female = new Queue<int>(femaleInput);
            int matches = 0;
            while (male.Any()&&female.Any())
            {
                int currMale = male.Peek();
                int currFemale = female.Peek();
                if (currMale<=0)
                {
                    male.Pop();
                    continue;
                }
                else if (currFemale <= 0)
                {
                    female.Dequeue();
                    continue;
                }
                if (male.Peek() % 25==0&& male.Peek() != 0)
                {
                    male.Pop();
                    if (male.Any())
                    {
                        male.Pop();
                    }
                    continue;
                }
                else if (female.Peek() % 25 == 0&& female.Peek() != 0)
                {
                    female.Dequeue();
                    if (female.Any())
                    {
                        female.Dequeue();
                    }
                    continue;
                }
                if (male.Peek()== female.Peek())
                {
                    matches++;
                    male.Pop();
                    female.Dequeue();
                    continue;
                }
                else if (female.Peek() != male.Peek())
                {
                    male.Push(male.Pop() - 2);
                    female.Dequeue();
                    continue;
                }

            }
            Console.WriteLine($"Matches: {matches}");
            if (male.Any())
            {
                Console.WriteLine($"Males left: {string.Join(',',male)}");
            }
            else
            {
                Console.WriteLine("Males left: none");
            }
            if (female.Any())
            {
                Console.WriteLine($"Females left: {string.Join(", ", female)}");
            }
            else
            {
                Console.WriteLine("Females left: none");
            }

        }
    }
}
