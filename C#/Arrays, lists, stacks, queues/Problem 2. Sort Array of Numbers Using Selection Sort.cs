using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication60
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int[] numbers = Array.ConvertAll(input, int.Parse);
            int change = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int k = i+1; k < numbers.Length; k++)
                {
                    if (numbers[i] > numbers[k])
                    {
                        change = numbers[i];
                        numbers[i] = numbers[k];
                        numbers[k] = change;
                    }

                }
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
