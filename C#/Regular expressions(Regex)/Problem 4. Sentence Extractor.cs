using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {


            string keyword = Console.ReadLine();
            keyword = @"\b" + keyword + @"\b";
            string text = Console.ReadLine();
            string pattern = @"[A-Z][A-Za-z\s\:\'\’\-\ – ]*[\!\.\?]";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);
            foreach (Match match in matches)
            {
                string sentence = match.Value;
                if (Regex.IsMatch(sentence, keyword))
                {
                    Console.WriteLine(sentence);
                }
            }
        }
    }
}
