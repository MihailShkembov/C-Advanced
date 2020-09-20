﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _0._3_MaxMinElement
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<int>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int[] command = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (command[0]==1)
                {
                    stack.Push(command[1]);

                }
                else if (command[0]==2)
                {
                    stack.Pop();
                }
                else if (stack.Any())
                {
                    if (command[0]==3)
                    {
                        Console.WriteLine(stack.Max());
                    }
                    else
                    {
                        Console.WriteLine(stack.Min());
                    }
                }
            }
            Console.WriteLine(string.Join(", ",stack));
        }
    }
}
