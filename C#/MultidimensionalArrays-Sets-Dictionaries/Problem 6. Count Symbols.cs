using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            Array.Sort(input);
            int count = 1;
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    count++;
                }
                if (input[i] != input[i + 1])
                {
                    Console.WriteLine("{0}: {1} time/s", input[i], count);
                    count = 1;
                }
            }
        }
    }
}
