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
            int[] numbers = {1,5,8,10,1,20};
            string[] strings ={"av","ab","ist","ost","fards"} ;
            DateTime[] dates =
            {
                new DateTime(2002,3,1),new DateTime(2015,5,6),new DateTime(2014,1,1)
            };
            SortArray(numbers);
            SortArray(strings);
            SortArray(dates);
        }
        static void SortArray(int[] numbersToBeSorted)
        {
            Array.Sort(numbersToBeSorted);
            Console.WriteLine(string.Join(" ",numbersToBeSorted));
        }
        static void SortArray(string[] stringsToBeSorted)
        {
            Array.Sort(stringsToBeSorted);
            Console.WriteLine(string.Join(" ", stringsToBeSorted));
        }
        static void SortArray(DateTime[] datesToBeSorted)
        {
            Array.Sort(datesToBeSorted);
            Console.WriteLine(string.Join(" ", datesToBeSorted));
        }

    }
}
