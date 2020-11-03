using System;
using System.Collections.Generic;
using System.Linq;

namespace _0._2Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var matrix = new char[n, n];
            var indexOfStart = new List<int>();
            var b1 = new List<int>();
            for (int row = 0; row < n; row++)
            {
                string currInput = Console.ReadLine();
                for (int col = 0; col < n; col++)
                {
                    if (currInput[col]=='S')
                    {
                       indexOfStart = new List<int> { row,col};
                    }
                    else if (currInput[col]=='B')
                    {
                        b1.Add(row);
                        b1.Add(col);
                    }
                    matrix[row, col] = currInput[col];
                }
            }
            int currRow = indexOfStart[0];
            int currCol = indexOfStart[1];
            int foodsEaten = 0;
            while (true)
            {
                string cmd = Console.ReadLine();
                if (cmd=="left")
                {
                    matrix[currRow, currCol] = '.';
                    currCol--;
                }
                else if (cmd == "right")
                {
                    matrix[currRow, currCol] = '.';
                    currCol++;
                }
                else if (cmd=="down")
                {
                    matrix[currRow, currCol] = '.';
                    currRow++;
                }
                else if (cmd=="up")
                {
                    matrix[currRow, currCol] = '.';
                    currRow--;
                }
                 bool isOutside = currRow == n || currCol == n||currRow<0||currCol<0;
                if (isOutside == true)
                {
                    Console.WriteLine("Game over!");
                    Console.WriteLine($"Food eaten: {foodsEaten}");
                    break;
                }
                if (b1.Any())
                {
                    if (currRow == b1[0] && currCol == b1[1])
                    {
                        matrix[currRow, currCol] = '.';
                        currRow = b1[2];
                        currCol = b1[3];
                        matrix[currRow, currCol] = '-';

                    }
                    else if (currRow == b1[2] && currCol == b1[3])
                    {
                        matrix[currRow, currCol] = '.';
                        currRow = b1[0];
                        currCol = b1[1];
                        matrix[currRow, currCol] = '-';
                    }
                }
                if (matrix[currRow,currCol]=='*')
                {
                    foodsEaten++;
                }
                bool isEaten = foodsEaten == 10;
                 if (isEaten==true)
                {
                    matrix[currRow, currCol] = 'S';
                    Console.WriteLine("You won! You fed the snake.");
                    Console.WriteLine($"Food eaten: {foodsEaten}");
                    break;
                }
            }
            PrintMatrix(matrix, n);
         
           
        }
        static void PrintMatrix(char[,] matrix,int n)
        {
            var matrix2 = matrix;
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(matrix2[row, col]);

                }
                Console.WriteLine();
            }
        }
    }
}
