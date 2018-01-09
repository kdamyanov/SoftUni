using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine()); //
            var category = (Console.ReadLine()); //VIP or Normal
            var people = double.Parse(Console.ReadLine()); //

            var percentFromBudget = 0.0;
            var ticket = 0.0;

            if (people>=1 && people<=4)
            {
                percentFromBudget = budget * 0.75;
            }
            else if (people >= 5 && people <= 9)
            {
                percentFromBudget = budget * 0.60;
            }
            else if (people >= 10 && people <= 24)
            {
                percentFromBudget = budget * 0.50;
            }
            else if (people >=25 && people <= 49)
            {
                percentFromBudget = budget * 0.40;
            }
            else if (people >= 50 )
            {
                percentFromBudget = budget * 0.25;
            }

            if (category == "VIP")
            {
                ticket = 499.99;
            }
            else if (category == "Normal")
            {
                ticket = 249.99;
            }

            
            var moneyForTickets = budget - percentFromBudget;
            var ticketPriceForGroup = people * ticket;

        

            if (moneyForTickets>=ticketPriceForGroup)
            {
                Console.WriteLine("Yes! You have {0:F2} leva left.",moneyForTickets-ticketPriceForGroup);
            }
            else
            {
                Console.WriteLine("Not enough money! You need {0:F2} leva.", ticketPriceForGroup- moneyForTickets);
            }
        }
    }
}
