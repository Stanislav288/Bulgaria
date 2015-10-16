using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication62
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            for (int i = 0; i < input.Length - 1; i++)
            {
                Console.Write(input[i] + " ");
                if (input[i] != input[i + 1])
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine(input[input.Length - 1]);
        }
    }
}
