using System;
using System.Collections.Generic;

namespace _0._6Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            var dicitionary = new Dictionary<string, Dictionary<string, int>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] cmd = Console.ReadLine().Split(new char[2] { ',',' ' }, StringSplitOptions.RemoveEmptyEntries);
              

                string color = cmd[0];
                for (int k = 2; k < cmd.Length; k++)
                {
                    string dress = cmd[k];
                    if (dicitionary.ContainsKey(color))
                    {
                        if (dicitionary[color].ContainsKey(cmd[k]))
                        {
                            dicitionary[color][dress]++;
                        }
                        else
                        {
                            dicitionary[color].Add(cmd[k], 1);
                        }
                    
                    }
                    else
                    {
                        var temp = new Dictionary<string, int>();
                        temp.Add(dress, 1);
                        dicitionary.Add(color,temp);
                        //existing dress!!!
                    }
                }
            }
            string[] toLookFor = Console.ReadLine().Split();
            string dressToLookFor = toLookFor[1];
            string colorToLookFor = toLookFor[0];
            foreach (var item in dicitionary)
            {
                Console.WriteLine($"{item.Key} clothes: ");
                foreach (var dress in item.Value)
                {
                    
                    if (item.Key==colorToLookFor&&dress.Key==dressToLookFor)
                    {
                        Console.Write($"* {dress.Key} - {dress.Value} (found!)");
                    }
                    else
                    {
                        Console.Write($"* {dress.Key} - {dress.Value}");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
