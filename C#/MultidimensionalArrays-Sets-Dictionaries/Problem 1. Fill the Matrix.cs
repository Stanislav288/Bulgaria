using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication68
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи размер на матрицата: ");
            int number = int.Parse(Console.ReadLine());
            int[,] array1 = new int[number, number];
            int[,] array2 = new int[number, number];
            int numberToBePrint = 1;
            for (int col = 0; col < number; col++)
            {
                for (int row = 0; row < number; row++)
                {
                    array1[row, col] = numberToBePrint;
                    numberToBePrint++;
                }
            }
            for (int row = 0; row < number; row++)
            {
                for (int col = 0; col < number; col++)
                {

                    Console.Write(array1[row, col] + "    ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            numberToBePrint = 1;
            for (int col = 0; col < number; col++)
            {
                for (int row = 0; row < number; row++)
                {
                    if (col % 2 == 0)
                    {
                        array2[row, col] = numberToBePrint;
                    }
                    else
                    {
                        array2[number - row - 1, col] = numberToBePrint;
                    }
                    numberToBePrint++;
                }
            }
            for (int row = 0; row < number; row++)
            {
                for (int col = 0; col < number; col++)
                {

                    Console.Write(array2[row, col] + "    ");
                }
                Console.WriteLine();
            }
        }
    }
}
