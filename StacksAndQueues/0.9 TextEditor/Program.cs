using System;
using System.Collections.Generic;
using System.Text;

namespace _0._9_TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            int n = int.Parse(Console.ReadLine());
            var sb = new StringBuilder();
            var updates= new Stack<string>();
            updates.Push(string.Empty);
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string task = command[0];
               
                switch (task)
                {
                    case "1":
                        string word = command[1];
                        sb.Append(word);
                        updates.Push(sb.ToString());
                        break;
                    case "2":
                         word = command[1];
                        int count = int.Parse(word);
                        var tempStack = new Stack<char>(sb.ToString());
                        for (int k = 0; k < count; k++)
                        {
                            tempStack.Pop();
                        }
                        sb = new StringBuilder(string.Join("",tempStack));
                        updates.Push(sb.ToString());

                        break;
                    case "3":
                         word = command[1];
                        int index = int.Parse(word);
                        Console.WriteLine(sb[index-1]);
                        break;
                    case "4":
                        updates.Pop();
                        string temp = updates.Peek().ToString();
                        sb = new StringBuilder(temp);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
