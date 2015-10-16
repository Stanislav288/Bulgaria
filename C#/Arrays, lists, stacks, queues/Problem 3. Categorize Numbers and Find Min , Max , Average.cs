using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication61
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            float[] array = Array.ConvertAll(input, float.Parse);
            List<float> roundNumbers = new List<float>();
            List<float> floatingPointNumbers = new List<float>();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 1 == 0)
                {
                    roundNumbers.Add(array[i]);
                }
                else
                {
                    floatingPointNumbers.Add(array[i]);
                }
            }

            Console.WriteLine("[" + string.Join(" ,", floatingPointNumbers) + "]" + " -> min: {0}, max:{1}, sum:{2}, avg:{3}",
                floatingPointNumbers.Min(), floatingPointNumbers.Max(), floatingPointNumbers.Sum(), String.Format("{0:0.00}", floatingPointNumbers.Average()));

            Console.WriteLine("[" + string.Join(" ,", roundNumbers) + "]" + " -> min: {0}, max:{1}, sum:{2}, avg:{3}",
                roundNumbers.Min(), roundNumbers.Max(), roundNumbers.Sum(), String.Format("{0:0.00}", roundNumbers.Average()));

        }
    }
}
