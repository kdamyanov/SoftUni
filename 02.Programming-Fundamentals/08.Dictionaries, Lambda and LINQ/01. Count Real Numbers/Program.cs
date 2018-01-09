using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');

            var counts = new SortedDictionary<double, int>();
            foreach (var numberString in numbers)
            {
                double parsedNum = double.Parse(numberString);
                if (counts.ContainsKey(parsedNum))
                {
                    counts[parsedNum]++;
                }
                else
                {
                    counts[parsedNum] = 1;
                }
            }

            foreach (var pair in counts)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
           

        }
    }
}
