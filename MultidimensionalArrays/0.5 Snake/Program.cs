using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _0._5_Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string snake = Console.ReadLine();
            
           
            int rows = dimensions[0];
            int cols = dimensions[1];
            var matrix = new string[rows, cols];
            var queue = new Queue<char>(snake);
            for (int row = 0; row < rows; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        queue.Enqueue(queue.Peek());
                        matrix[row, col] = queue.Dequeue().ToString();      
                    }
                }
                //iSoftun
                //Softuni
                else
                {
                    for (int col = cols-1; col >= 0; col--)
                    {
                        queue.Enqueue(queue.Peek());
                        matrix[row, col] = queue.Dequeue().ToString();
                    }
                }
            }
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine() ;
            }
        }
    }
}
