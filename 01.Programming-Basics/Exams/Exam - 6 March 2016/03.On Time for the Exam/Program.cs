using System;

class Program
{
    static void Main()
    {
        var startHour = Console.ReadLine();
        var startMin = Console.ReadLine();
        var start = startHour + ":" + startMin;

        var arrivalHour = Console.ReadLine();
        var arrivalMin = Console.ReadLine();
        var arrival = arrivalHour + ":" + arrivalMin;

        var examStartTime = DateTime.ParseExact(start, "H:m", null);
        var arrivalTime = DateTime.ParseExact(arrival, "H:m", null);

        var difference = arrivalTime - examStartTime;

        if (difference > TimeSpan.Zero)
        {
            Console.WriteLine("Late");
        }
        else if (difference >= new TimeSpan(0, -30, 0) && difference <= TimeSpan.Zero)
        {
            Console.WriteLine("On time");
            if (difference == TimeSpan.Zero)
            {
                return;
            }
        }
        else 
        {
            Console.WriteLine("Early");
        }

        var modifier = (difference <= TimeSpan.Zero) ? "before" : "after";
        if (difference.Hours==0)
        {
            Console.WriteLine("{0} minutes {1} the start", Math.Abs( difference.Minutes), modifier);
        }
        else
        {
            Console.WriteLine("{0}:{1:D2} hours {2} the start", Math.Abs( difference.Hours),Math.Abs( difference.Minutes), modifier);
        }
    }
}

