using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int maxSumRow = 0;
            int maxSumCol = 0;
            int sum = 0;
            int bestSum = int.MinValue;
            int[][] jaggedArray = new int[4][];

            for (int row = 0; row < input[0]; row++)
            {
                jaggedArray[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }

            for (int row = 0; row < input[0] - 2; row++)
            {
                for (int col = 0; col < input[1] - 2; col++)
                {
                    sum = jaggedArray[row][col] + jaggedArray[row + 1][col] + jaggedArray[row][col + 1] +
                         jaggedArray[row + 1][col + 1] + jaggedArray[row + 2][col] + jaggedArray[row][col + 2] +
                             jaggedArray[row + 1][col + 2] + jaggedArray[row + 2][col + 1] + jaggedArray[row + 2][col + 2];
                    if (sum > bestSum) { bestSum = sum; maxSumRow = row; maxSumCol = col; }
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Sum = " + bestSum);
            for (int row = maxSumRow; row <= maxSumRow + 2; row++)
            {
                for (int col = maxSumCol; col <= maxSumCol + 2; col++)
                {
                    Console.Write(jaggedArray[row][col] + "  ");
                }
                Console.WriteLine();
            }
        }
    }
}
