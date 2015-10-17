using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> cityVenue = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> venuePerformer = new Dictionary<string, List<string>>();
            while (true)
            {
                string[] splittedArray = Console.ReadLine().Split(';');
                if (splittedArray[0] == "END")
                {
                    break;
                }
                if (cityVenue.ContainsKey(splittedArray[0]))
                {
                    List<string> tempList = cityVenue[splittedArray[0]];
                    tempList.Add(splittedArray[1]);
                    tempList.Sort();
                    cityVenue[splittedArray[0]] = tempList;
                }
                else
                {
                    List<string> tempList = new List<string>();
                    tempList.Add(splittedArray[1]);
                    cityVenue.Add(splittedArray[0], tempList);
                }
                if (venuePerformer.ContainsKey(splittedArray[1]))
                {
                    List<string> tempList2 = venuePerformer[splittedArray[1]];
                    tempList2.Add(splittedArray[2]);
                    tempList2.Sort();
                    venuePerformer[splittedArray[0]] = tempList2;
                }
                else
                {
                    List<string> tempList2 = new List<string>();
                    tempList2.Add(splittedArray[2]);
                    venuePerformer.Add(splittedArray[1], tempList2);
                }

            }
            var cities = cityVenue.Keys;

            foreach (var city in cities)
            {
                Console.WriteLine(city);

                foreach (var venue in cityVenue[city].Distinct())
                {
                    Console.Write("-> " + venue + " : ");
                    Console.WriteLine(String.Join(", ", venuePerformer[venue].Distinct()));
                }
            }
        }
    }
}
