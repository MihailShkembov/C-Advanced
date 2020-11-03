using System;
using System.Collections.Generic;
using System.Linq;

namespace _0._2_Revolt
{
    class Program
    {
        static void Main(string[] args)
        {
            int squareMatrixSide = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string[,] matrix = new string[squareMatrixSide,squareMatrixSide];
            var startingPos = new List<int>();
            for (int rows = 0; rows < squareMatrixSide; rows++)
            {
                string command = Console.ReadLine();
                for (int cols = 0; cols < squareMatrixSide; cols++)
                {
                    
                    switch (command[cols])
                    {
                        case '-':matrix[rows, cols] = "-";
                            break;
                        case 'f':
                            matrix[rows, cols] = "f";
                            startingPos.Add(rows);
                            startingPos.Add(cols);
                            break;
                        case 'F':
                            matrix[rows, cols] = "F";
                            break;
                        case 'B':
                            matrix[rows, cols] = "B";              
                            break;
                        case 'T':
                            matrix[rows, cols] = "T";
                            break;
                        default:
                            break;
                    }

                }
            }
            matrix[startingPos[0], startingPos[1]] = "-";
        
            int currRow = startingPos[0];
            int currCol = startingPos[1];
            string cmd = "";
            for (int i = 0; i < n; i++)
            {
                int temp = currRow;//3
                int temp2 = currCol;//1
               
                if (matrix[currRow,currCol]!="B")
                {
                      cmd = Console.ReadLine();
                }
                else
                {
                    i--;
                }
                
                
                if (cmd=="down")
                {
                    if (currRow== squareMatrixSide - 1)
                    {
                        currRow = 0;
                    }
                    else
                    {
                        currRow++;
                    }
                }
                else if (cmd == "up")
                {
                    if (currRow ==0)
                    {
                        currRow = squareMatrixSide - 1;
                    }
                    else
                    {
                        currRow--;
                    } 
                }
                else if (cmd == "left")
                {
                    if (currCol == 0)
                    {
                        currCol = squareMatrixSide - 1;
                    }
                    else { currCol--; }
                   
                }
                else if (cmd == "right")
                {
                    if (currCol == squareMatrixSide - 1)
                    {
                        currCol = 0;
                    }
                    else
                    {
                        currCol++;
                    }
                }
                if (matrix[currRow, currCol] == "T")
                {
                    currRow = temp;
                    currCol = temp2;
                }
                else if (matrix[currRow,currCol]=="F")
                {
                    matrix[currRow, currCol] = "f";
                    Console.WriteLine("Player won!");
                    PrintMatrix(matrix, squareMatrixSide);
                    return;
                }
                
            }
            matrix[currRow, currCol] = "f";
            Console.WriteLine("Player lost!");
            PrintMatrix(matrix, squareMatrixSide);
        }
        static void PrintMatrix(string[,] matrix,int n)
        {
            
           
            for (int row = 0; row < n; row++)
            {
                
                for (int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
