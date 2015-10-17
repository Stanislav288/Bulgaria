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
            string textPattern = @"<a\s+href=([^>]+)>([^<]+)</a>";
            Regex regex = new Regex(textPattern);
            string replace = "[URL href=$1]$2[/URL]";
            string result = Regex.Replace(text, textPattern, replace);
            Console.WriteLine(result);

        }
    }
}
