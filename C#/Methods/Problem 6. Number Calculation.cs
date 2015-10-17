using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the numbers on a single row separated by a single space: ");
            string[] input = Console.ReadLine().Split();
            decimal[] numbers = Array.ConvertAll(input, decimal.Parse);

            MinMax(numbers);
            SumAverageProduct(numbers);
        }

        static void MinMax(decimal[] array)
        {
            decimal change = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int k = i + 1; k < array.Length; k++)
                {
                    if (array[i] > array[k])
                    {
                        change = array[i];
                        array[i] = array[k];
                        array[k] = change;
                    }

                }
            }
            Console.WriteLine("Min -> " + array[0]);
            Console.WriteLine("Max -> " + array[array.Length - 1]);
        }
        static void SumAverageProduct(decimal[] array)
        {
            decimal sum = 0;
            decimal product = 1;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                product *= array[i];
            }
            Console.WriteLine("Average -> " + (sum / array.Length));
            Console.WriteLine("Sum -> " + sum);
            Console.WriteLine("Product -> " + product);
        }

    }
}

