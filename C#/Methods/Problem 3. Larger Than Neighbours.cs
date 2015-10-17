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
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            IsLargerThatNeighbours(input);

        }
        static void IsLargerThatNeighbours(int[] array)
        {
            if (array[0] > array[1])
            {
                Console.WriteLine("true");
            }
            else if (array[0] <= array[1])
            {
                Console.WriteLine("false");
            }
            for (int k = 1; k < array.Length - 1; k++)
            {

                if (array[k - 1] < array[k] && array[k + 1] < array[k])
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }

            }
            if (array[array.Length - 1] > array[array.Length - 2])
            {
                Console.WriteLine("true");
            }
            else if (array[array.Length - 1] <= array[array.Length - 2])
            {
                Console.WriteLine("false");
            }
        }
    }
}
