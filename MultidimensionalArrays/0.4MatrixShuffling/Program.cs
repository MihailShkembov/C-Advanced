using System;
using System.Linq;

namespace _0._4MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];
            var matrix = new string[rows, cols];
            bool iSValid = true;
            for (int row = 0; row < rows; row++)
            {
                string[] com = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = com[col];
                }
            }
            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            while (command[0] != "END")
            {
                string swap = command[0];
              
                if (swap != "swap" || command.Length - 1 != 4
                    || int.Parse(command[1]) > matrix.GetLength(0) || int.Parse(command[1]) < 0
                    || int.Parse(command[2]) > matrix.GetLength(1) || int.Parse(command[2]) < 0
                    || int.Parse(command[3]) > matrix.GetLength(0) || int.Parse(command[3]) < 0
                    || int.Parse(command[4]) > matrix.GetLength(1) || int.Parse(command[4]) < 0)
                {
                    iSValid = false;
                    Console.WriteLine("Invalid input!");
                    command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    continue;
                }
                int row1 = int.Parse(command[1]);
                int col1 = int.Parse(command[2]);
                int row2 = int.Parse(command[3]);
                int col2 = int.Parse(command[4]);
               
                    string temp = matrix[row1, col1];
                    matrix[row1, col1] = matrix[row2, col2];
                    matrix[row2, col2] = temp;
                    for (int row = 0; row < rows; row++)
                    {
                        for (int col = 0; col < cols; col++)
                        {
                            Console.Write($"{matrix[row, col]} ");
                        }
                        Console.WriteLine();
                    }
                
                
                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                iSValid = true;
            }

        }
    }
}
