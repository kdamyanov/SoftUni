using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CharityMarathon
{
    static void Main()
    {
        long days = long.Parse(Console.ReadLine());
        long runners = long.Parse(Console.ReadLine());
        long averageLaps = long.Parse(Console.ReadLine());
        long lengthTrack = long.Parse(Console.ReadLine());
        long maxRunners = long.Parse(Console.ReadLine());
        decimal money = decimal.Parse(Console.ReadLine());

        long maxTrack = days * maxRunners;
        long totalKm = 1;

        //да оправя променливите ако остане време

        if (maxTrack >= runners)
        {
            totalKm = (runners * averageLaps * lengthTrack) / 1000;
        }
        else if (maxTrack < runners)
        {
            totalKm = (days * maxRunners * averageLaps * lengthTrack) / 1000;
        }



        decimal raised = totalKm * money;


        Console.WriteLine($"Money raised: {raised:F2}");
    }
}

