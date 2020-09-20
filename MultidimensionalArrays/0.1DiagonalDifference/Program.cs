using System;
using System.Linq;

namespace MultidimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = rows;
            var matrix = new int[rows, cols];
            int sum1 = 0;
            int sum2 = 0;
            for (int row = 0; row < rows; row++)
            {
                int[] command = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = command[col];
                }
            }
            for (int i = 0; i < rows; i++)
            {
                sum1 += matrix[i, i];
            }
            int k = 0;
            for (int i = rows - 1; i >= 0; i--)
            {

                sum2 += matrix[k, i];
                k++;
            }
            Console.WriteLine(Math.Abs(sum1 - sum2));
        }
    }
}
