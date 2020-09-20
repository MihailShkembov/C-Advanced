using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = 3;

            int[][] jaggedArray2 = new int[3][]
  {
    new int[] { 1, 3, 5, 7, 9 },
    new int[] { 0, 2, 4, 6 },
    new int[] { 11, 22 }
  };
            Console.WriteLine(jaggedArray2[1].Length);

        }
    }
}
