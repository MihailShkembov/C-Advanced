using System;
using System.Linq;

namespace _0._2Garden
{
    class Program
    {
        static void Main()
        {
            var dimensions = Console.ReadLine().Split().Select(int.Parse).ToList();
            int n = dimensions[0];
            int m = dimensions[1];
            var matrix = new int[n, m];

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = 0;
                }
            }
            string cmd = Console.ReadLine();

            while (cmd != "Bloom Bloom Plow")
            {
                var temp = cmd.Split().Select(int.Parse).ToList();
                int rowChange = temp[0];
                int colChange = temp[1];
                bool isValidIndex = rowChange < 0 || rowChange >= n || colChange < 0 || colChange >= m;
                if (isValidIndex)
                {
                    Console.WriteLine("Invalid coordinates.");
                }
                else
                {
                    matrix[rowChange, colChange] = 10;
                }
                cmd = Console.ReadLine();
            }
            matrix = BoomBoomPlow(matrix, n, m);
            PrintMatrix(matrix, n, m);
        }
        static int[,] BoomBoomPlow(int[,] matrix, int n, int m)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    if (matrix[row, col] == 10)
                    {
                        for (int i = 0; i < m; i++)
                        {
                            if (i == col)
                            {
                                matrix[row, col] = 1;
                                continue;
                            }
                            matrix[row, i] += 1;
                        }
                        for (int i = 0; i < n; i++)
                        {
                            if (i == row)
                            {
                                matrix[row, col] = 1;
                                continue;
                            }
                            matrix[i, col] += 1;
                        }
                    }
                }
            }
            return matrix;
        }
        static void PrintMatrix(int[,] matrix, int n, int m)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
