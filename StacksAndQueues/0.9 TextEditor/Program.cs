using System;
using System.Collections.Generic;
using System.Text;

namespace _0._9_TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int n = int.Parse(Console.ReadLine());
            var sb = new StringBuilder();
            var updates= new Stack<string>();
            updates.Push(sb.ToString());
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string task = command[0];
               
                switch (task)
                {
                    case "1":
                        sb.Append(command[1]);
                        updates.Push(sb.ToString());
                        break;
                    case "2":
                        int count = int.Parse(command[1]);
                        sb.Remove(sb.Length - count, count);
                        updates.Push(sb.ToString());
                        break;
                    case "3":
                        int index = int.Parse(command[1]);
                        Console.WriteLine(sb[index-1]);
                        break;
                    case "4":
                        updates.Pop();
                        sb = new StringBuilder(updates.Peek().ToString());
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
