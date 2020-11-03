using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _0._1Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            var taskInput = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
            var threadInput = Console.ReadLine().Split().Select(int.Parse).ToList();
            int taskValue = int.Parse(Console.ReadLine());
            var tasks = new Stack<int>(taskInput);
            var threads = new Queue<int>(threadInput);
            while (true)
            {
                int currTask = tasks.Peek();
                int currThread = threads.Peek();
                if (currTask == taskValue)
                {
                    Console.WriteLine($"Thread with value {currThread} killed task {currTask}");
                    Console.WriteLine(string.Join(' ', threads));
                    return;
                }
                if (currThread>=currTask)
                {
                    tasks.Pop();
                    threads.Dequeue();
                }
                else
                {
                    threads.Dequeue();
                }
            }
            
        }
    }
}
