using System;
using System.Linq;

namespace _0._6_JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            double[][] jagged = new double[rows][];
            jagged = ReadJagged(jagged, rows);
            jagged = ReturnDouble(jagged, rows);
            jagged = MakeChanges(jagged, rows);
            PrintFinal(jagged, rows);

        }
        static double[][] ReadJagged(double[][] jagged, int rows)
        {
            for (int row = 0; row < rows; row++)
            {
                double[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
                jagged[row] = input;
               
            }
            return jagged;
        }
        static double[][] MakeChanges(double[][] jagged, int rows)
        {
            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "End")
            {
                if (command[0] == "Add")
                {
                    int row1 = int.Parse(command[1]);
                    int col1 = int.Parse(command[2]);
                    int value = int.Parse(command[3]);
                    if ((row1 >= 0 && row1 < rows) && (col1 >= 0 && col1 < jagged[row1].Length))
                    {
                        jagged[row1][col1] += value;
                    }

                }
                else if (command[0] == "Subtract")
                {
                    int row1 = int.Parse(command[1]);
                    int col1 = int.Parse(command[2]);
                    int value = int.Parse(command[3]);
                    if ((row1 >= 0 && row1 < rows) && (col1 >= 0 && col1 < jagged[row1].Length))
                    {
                        jagged[row1][col1] -= value;
                    }
                }
                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            return jagged;
        }
        static void PrintFinal(double[][]jagged,int rows)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < jagged[row].Length; col++)
                {
                    Console.Write($"{jagged[row][col]} ");
                }
                Console.WriteLine();
            }
        }
        static double[][] ReturnDouble(double[][] jagged, int rows)
            {
            for (int row = 0; row < rows - 1; row++)
            {

                if (jagged[row].Length == jagged[row + 1].Length)
                {
                    for (int col = 0; col < jagged[row].Length; col++)
                    {
                        jagged[row][col] *= 2;
                        jagged[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < jagged[row].Length; col++)
                    {
                        jagged[row][col] /= 2;

                    }
                    for (int col = 0; col < jagged[row + 1].Length; col++)
                    {
                        jagged[row + 1][col] /= 2;
                    }
                }
            }
            return jagged;
        }
    }
}
