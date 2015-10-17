using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string input = Console.ReadLine();
            Regex pattern =new Regex( @"(.)\1+");
            Console.WriteLine(pattern.Replace(input,"$1"));
          

        }
    }
}
