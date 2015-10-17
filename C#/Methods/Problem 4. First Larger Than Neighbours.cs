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
            int[] sequenceOne = { 1, 3, 4, 5, 1, 0, 5 };
            int[] sequenceTwo = { 1, 2, 3, 4, 4, 5, 6, 6 };
            int[] sequenceThree = { 1, 1, 1 };
            IsLargerThatNeighbours(sequenceOne);
            IsLargerThatNeighbours(sequenceTwo);
            IsLargerThatNeighbours(sequenceThree);

        }
        static void IsLargerThatNeighbours(int[] array)
        {
            int count = 0;
            if (array[0] > array[1])
            {
                Console.WriteLine(Array.IndexOf(array, array[0]));
                return;
            }
            else
            {
                count++;
            }
            for (int k = 1; k < array.Length - 1; k++)
            {

                if (array[k - 1] < array[k] && array[k + 1] < array[k])
                {
                    Console.WriteLine(Array.IndexOf(array, array[k]));
                    return;
                }
                else
                {
                    count++;
                }
            }
            if (array[array.Length - 1] > array[array.Length - 2])
            {
                Console.WriteLine(Array.IndexOf(array, array[array.Length - 1]));
                return;
            }
            else
            {
                count++;
            }
            if (count == array.Length)
            {
                Console.WriteLine("-1");
            }
        }
    }
}

