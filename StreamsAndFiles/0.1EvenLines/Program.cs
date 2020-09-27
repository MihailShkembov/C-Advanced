using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.WebSockets;

namespace _0._1EvenLines
{
    class Program
    {
        static void Main(string[] args)
        {
          using  var reader = new StreamReader(@"C:\Users\User\source\repos\C-Advanced\C-Advanced\StreamsAndFiles\0.1EvenLines\Text.txt");
            int count=0;
            while (true)
            {
                string temp = reader.ReadLine()
                    .Replace('-', '@').
                   Replace(',', '@').Replace('.', '@').Replace('!', '@').
                    Replace(',', '@');
                var stringArr = temp.Split();
                Array.Reverse(stringArr);
                temp = string.Join(" ",stringArr);
                if (count%2==0)
                {    
                    Console.WriteLine(temp);
                }

                count++;
                if (reader.EndOfStream)
                {
                    return;
                }
            }
      
        }
    }
}
