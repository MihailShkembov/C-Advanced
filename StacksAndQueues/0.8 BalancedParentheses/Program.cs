using System;
using System.Collections.Generic;
using System.Linq;

namespace _0._8_BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var queue = new Queue<char>(input);
            var stack = new Stack<char>(input);
            bool check = false;
            if (string.IsNullOrEmpty(input)||input.Length%2!=0)
            {
                Console.WriteLine("NO");
                return;
            }
           
            for (int i = 0; i < input.Length/2; i++)
            {
                if (queue.Peek()=='{'&&stack.Peek()=='}')
                {
                    queue.Dequeue();
                    stack.Pop();
                    check = true;
                }
                else if (queue.Peek() == '['&& stack.Peek() == ']')
                {
                    queue.Dequeue();
                    stack.Pop();
                    check = true;
                }
                else if (queue.Peek() == '('&& stack.Peek() == ')')
                {
                    queue.Dequeue();
                    stack.Pop();
                    check = true;
                }
                else
                {
                    check = false;
                    
                }
                if (check==false)
                {
                    Console.WriteLine("NO");
                    return;
                }
            }
            if (check==false)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
              
            
        }
    }
}
