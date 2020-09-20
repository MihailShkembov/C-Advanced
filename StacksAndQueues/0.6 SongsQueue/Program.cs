using System;
using System.Collections;
using System.Collections.Generic;

namespace _0._6_SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            var queue = new Queue<string>(input);
            
            while (queue.Count>0)
            {
                string command = Console.ReadLine();
                if (command.Contains("Play"))
                {
                    queue.Dequeue();
                }
                else if (command.Contains("Add"))
                {
                    string newstring = command.Replace("Add ", string.Empty);
                    if (queue.Contains(newstring))
                    {
                        Console.WriteLine($"{newstring} is already contained!");
                    }
                    else
                    {
                        queue.Enqueue(newstring);
                    }
                }
                else if (command.Contains("Show"))
                {
                    Console.WriteLine(string.Join(", ",queue));
                }
           
            }
            Console.WriteLine("No more songs!");
            
        }
    }
}
