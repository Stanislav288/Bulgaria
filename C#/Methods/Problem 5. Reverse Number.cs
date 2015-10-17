using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            double reversed = double.Parse(Console.ReadLine());
            GetReversedNumber(reversed);

        }
        static void GetReversedNumber(double reversed)
        {
            char[] numberToString = reversed.ToString().ToCharArray();
            Array.Reverse(numberToString);
            Console.WriteLine(string.Join("", numberToString));
        }
    }
}
