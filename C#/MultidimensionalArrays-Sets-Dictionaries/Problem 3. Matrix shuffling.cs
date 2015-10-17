using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixRow = int.Parse(Console.ReadLine());
            int matrixCol = int.Parse(Console.ReadLine());
            string[,] matrix = new string[matrixRow, matrixCol];
            for (int row = 0; row < matrixRow; row++)
            {
                for (int col = 0; col < matrixCol; col++)
                {
                    matrix[row, col] = Console.ReadLine();
                }
            }

            string[] command = Console.ReadLine().Split();
            string temp = "";
            int x1 = 0;
            int x2 = 0;
            int y1 = 0;
            int y2 = 0;

            while (command[0] != "END")
            {
                if (command[0] != "swap" || command.Length != 5)
                {
                    Console.WriteLine("Invalid input!");
                    Console.WriteLine();
                    command = Console.ReadLine().Split();
                    continue;
                }
                x1 = int.Parse(command[1]);
                x2 = int.Parse(command[3]);
                y1 = int.Parse(command[2]);
                y2 = int.Parse(command[4]);
                if (x1 < 0 || x2 < 0 || y1 < 0 || y2 < 0 ||
                x1 >= matrixRow || x2 >= matrixRow || y1 >= matrixCol || y2 >= matrixCol)
                {
                    Console.WriteLine("Invalid input!");
                    Console.WriteLine();
                    command = Console.ReadLine().Split();
                    continue;
                }
                else
                {
                    Console.WriteLine("(after swapping {0} and {1})", matrix[x1, y1], matrix[x2, y2]);
                    temp = matrix[x1, y1];
                    matrix[x1, y1] = matrix[x2, y2];
                    matrix[x2, y2] = temp;
                }
                for (int row = 0; row < matrixRow; row++)
                {
                    for (int col = 0; col < matrixCol; col++)
                    {
                        Console.Write(matrix[row, col] + "  ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                command = Console.ReadLine().Split();
            }
        }
    }
}

