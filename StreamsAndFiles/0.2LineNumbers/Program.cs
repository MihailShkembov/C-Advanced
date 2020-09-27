using System;
using System.IO;
using System.Linq;

namespace _0._2LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //"-", ",", ".", "!", "?
            var reader = new StreamReader("Text.txt");
            int linecount = 1;

            while (!reader.EndOfStream)
            {
              
                string temp = reader.ReadLine();
                int charCount = 0;
                int letterCount = 0;
                for (int i = 0; i < temp.Length; i++)
                {
                    if (Char.IsPunctuation(temp[i]))
                    {
                        charCount++;
                    }
                    if (Char.IsLetter(temp[i]))
                    {
                        letterCount++;
                    }

                }
                Console.WriteLine($"Line {linecount}: {temp} ({letterCount})({charCount})");
                linecount++;
            }

        }
    }
}
