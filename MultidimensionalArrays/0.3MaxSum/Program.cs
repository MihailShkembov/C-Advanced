using System;
using System.Linq;

namespace _0._3_BiggestSumRectamgular
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];
            var matrix = new int[rows, cols];
            int maxValue = int.MinValue;

            int temp = 0;
            int colStart = 0;
            int rowStart = 0;
            if (rows < 3 || cols < 3)
            {
                return;
            }

            for (int row = 0; row < rows; row++)
            {
                var numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }
            for (int col = 0; col < cols - 2; col++)
            {
                for (int row = 0; row < rows - 2; row++)
                {
                    //row 0 col 2
                    temp =
                        matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                        + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                        + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (temp >= maxValue)
                    {
                        colStart = col;
                        rowStart = row;
                        maxValue = temp;
                    }
                }

            }
            Console.WriteLine($"Sum = {maxValue}");
            for (int row = rowStart; row < rowStart + 3; row++)
            {
                for (int col = colStart; col < colStart + 3; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }

        }
    }
}
