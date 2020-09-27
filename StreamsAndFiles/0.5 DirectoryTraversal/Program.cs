using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _0._5_DirectoryTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string directory = @"C:\Users\User\source\repos\C-Advanced\C-Advanced\StreamsAndFiles\0.5 DirectoryTraversal\bin\Debug\netcoreapp3.1";
              var temp = Directory.GetFiles(directory);
            var dictionary = new Dictionary<string, Dictionary<string,long>>();
            foreach (var file in temp)
            {
                FileInfo fileInfo = new FileInfo(file);
              
                string fullName = Path.GetFileName(file);
                string fileName = fileInfo.FullName;
                string extension = fileInfo.Extension;
                long size = fileInfo.Length;
                if (!dictionary.ContainsKey(extension))
                {
                    var tempDic = new Dictionary<string, long>();
                    tempDic.Add(fullName, size);
                    dictionary.Add(extension, tempDic);
                }
                else
                {
                   
                    dictionary[extension].Add(fullName, size);
                }

            }
       
            
             using var writer = new StreamWriter("report.txt");
            foreach (var item in dictionary)
            {
                writer.WriteLine($"{item.Key}");
               
                foreach (var pair in item.Value)
                {
                    writer.WriteLine($"{pair.Key} - {pair.Value}");
                    writer.Flush()
                }
            }
        }
    }
}
