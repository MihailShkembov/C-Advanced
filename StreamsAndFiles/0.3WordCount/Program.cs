using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _0._3WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = File.ReadLines("words.txt").ToList();
            var text =new StreamReader("text.txt");
            using var writer = new StreamWriter("actualResult.txt");
            var charar = new char[6] { '-', ',', '.', '!', '?',' ' };
            var dictionary = new Dictionary<string, int>();
            for (int i = 0; i < words.Count; i++)
            {
               
                while (!text.EndOfStream)
                {
                    var tempArr = text.ReadLine().Split(charar, StringSplitOptions.RemoveEmptyEntries);

                    string searching = words[i];
                    for (int k = 0; k < tempArr.Length; k++)
                    {
                        if (tempArr[k].ToLower() == searching.ToLower())
                        {
                            if (!dictionary.ContainsKey(tempArr[k].ToLower()))
                            {
                                dictionary.Add(tempArr[k].ToLower(), 0);
                            }
                            dictionary[tempArr[k].ToLower()]++;
                        }
                    }
                }
                text = new StreamReader("text.txt");
            }
            foreach (var item in dictionary)
            {
                writer.WriteLine($"{item.Key} - {item.Value}");
                writer.Flush();
            }
            
        }

    }
}
