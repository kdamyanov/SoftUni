using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var season= (Console.ReadLine());

            var country = "";
            var place = "";
            var pFromBudget = 0.0;

            if (budget<=100)
            {
                country = "Bulgaria";
                if (season=="summer")
                {
                    place = "Camp";
                    pFromBudget = 0.3;
                }
                else if (season == "winter")
                {
                    place = "Hotel";
                    pFromBudget = 0.7;
                }
            }
            else if (budget <= 1000)
            {
                country = "Balkans";
                if (season == "summer")
                {
                    place = "Camp";
                    pFromBudget = 0.4;
                }
                else if (season == "winter")
                {
                    place = "Hotel";
                    pFromBudget = 0.8;
                }
            }
            else if (budget > 1000)
            {
                country = "Europe";
                place = "Hotel";
                pFromBudget = 0.9;
            }

            Console.WriteLine("Somewhere in {0}", country);
            Console.WriteLine("{0} - {1:F2}", place,budget*pFromBudget);
        }
    }
}
