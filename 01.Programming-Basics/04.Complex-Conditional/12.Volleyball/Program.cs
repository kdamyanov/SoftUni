using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            var year = Console.ReadLine();         // високосна година или невисокосна
            var holidaysPerYear = double.Parse(Console.ReadLine()); //брой празници в годината (които не са събота и неделя).
            var weeksReturnHome = double.Parse(Console.ReadLine()); //брой уикенди, в които Влади си пътува до родния град.

            var weekendsInYear = 48.0 -weeksReturnHome;
            var sofiaPlays = weekendsInYear * (3.0 / 4);
            var gamesHoliday = holidaysPerYear * (2.0 / 3);
            var totalGames = gamesHoliday + sofiaPlays + weeksReturnHome;
            

            if (year == "leap")
            {
                totalGames = totalGames * 1.15;
            }
            Console.WriteLine(Math.Truncate(totalGames));
        }
    }
}
