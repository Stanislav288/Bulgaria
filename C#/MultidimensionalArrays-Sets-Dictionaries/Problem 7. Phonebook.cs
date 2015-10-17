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
            string[] input=Console.ReadLine().Split('-');
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            while(input[0]!="search")
            {
                phonebook[input[0]] = input[1];
                 input=Console.ReadLine().Split('-');
            }
            string value;
            Console.WriteLine();
           while(input.Length!=0)
            {
                if (input[0] == "search")
                {
                    input = Console.ReadLine().Split('-');
                    continue;
                }
                if(phonebook.ContainsKey(input[0]))
                {
                    value = phonebook[input[0]];
                    Console.WriteLine("{0} -> {1}",input[0],value);
                }
                else
                {
                    Console.WriteLine("Contact {0} does not exist.", input[0]);
                }
                Console.WriteLine();
                input = Console.ReadLine().Split('-');
            }
        }
    }
}
