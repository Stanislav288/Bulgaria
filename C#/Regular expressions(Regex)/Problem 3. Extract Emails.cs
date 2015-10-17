using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"[^\.\-_\d\s][a-z\.\-_\d]*@[a-z\-]*(\.[a-z]{2,3}\.[a-z]{2,3}|\.[a-z]{2,3})";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);
            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
