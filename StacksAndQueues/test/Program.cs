using System;
using System.Text;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string abc = "abc";
            var sb = new StringBuilder(abc);
            var chararr = abc.ToCharArray();
            Array.Reverse(chararr);
            abc = new string(chararr);
           abc= abc.Remove(0, 3);
            Console.WriteLine(abc);
            //0 1 2
            //a b c

        }
    }
}
