using System;
using System.Collections.Generic;

namespace _0._2Bee
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var matrix = new char[n, n];
            var startingPlaceCordinates = new List<int>();
            for (int row = 0; row < n; row++)
            {
                string currInput = Console.ReadLine();
                for (int col = 0; col < n; col++)
                {
                    char tempChar = currInput[col];
                    if (tempChar=='B')
                    {
                        startingPlaceCordinates.Add(row);
                        startingPlaceCordinates.Add(col);
                    }
                    matrix[row, col] = currInput[col];
                }
            }
            int currRow = startingPlaceCordinates[0];
            int currCol = startingPlaceCordinates[1];
            int flowersEaten = 0;
            bool outOfRange = false;
            bool feeded = false;
            string cmd = string.Empty;
            matrix[currRow, currCol] = '.';
            while (cmd!="End")
            {
                 feeded = flowersEaten >= 5;
                outOfRange = currRow > n - 1 || currCol > n - 1 || currRow < 0 || currCol < 0;
                if (outOfRange == true)
                {
                    Console.WriteLine($"The bee got lost!");
                    break;
                }
                if (matrix[currRow,currCol]!='O')
                {
                     cmd = Console.ReadLine();
                }
                else
                {
                    matrix[currRow, currCol] = '.';
                }
                 if (matrix[currRow,currCol]=='f')
                {
                    flowersEaten++;
                    matrix[currRow, currCol] = '.';
                }
                if (cmd== "up")
                {
                    currRow--;
                }
                else if (cmd=="down")
                {
                    currRow++;
                }
                else if (cmd=="left")
                {
                    currCol--;
                }
                else if (cmd=="right")
                {
                    currCol++;
                }
               
            }
            if (!outOfRange)
            {
                matrix[currRow, currCol] = 'B';
            }
            if (feeded)
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {flowersEaten} flowers!");
            }
            else
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5-flowersEaten} flowers more");
            }
            PrintMatrinx(matrix, n);
        }
        static void PrintMatrinx(char[,] matrix,int n)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write($"{matrix[row, col]}");
                }
                Console.WriteLine();
            }
        }
    }
}
