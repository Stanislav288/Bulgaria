using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication59
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int[] array = Array.ConvertAll(input,int.Parse);
            Array.Sort(array);
            Console.WriteLine(string.Join(" ",array));
        }
    }
}
