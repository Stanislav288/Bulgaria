using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication63
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> temp = new List<int>();
            List<int> longest = new List<int>();
            for (int i = 0, k = 1; i < input.Length; i++, k++)
            {
                temp.Add(input[i]);
                if (k < input.Length && input[i] <= input[k])
                {
                    continue;
                }
                else
                {

                    if (temp.Count > longest.Count)
                    {
                        longest.Clear();
                        longest.AddRange(temp);
                        Console.WriteLine(string.Join(" ",temp));
                        temp.Clear();
                    }
                    else 
                    {
                        Console.WriteLine( string.Join(" ",temp));
                        temp.Clear();
                    }
                }
            }
            Console.WriteLine("Longest: "+string.Join(" ",longest));

        }
    }
}
