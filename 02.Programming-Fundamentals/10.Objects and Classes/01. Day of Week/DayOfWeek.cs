using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DayOfWeek
{
    static void Main()
    {
        string input = Console.ReadLine();

        DateTime date = DateTime.ParseExact(input, "d-m-yyyy", CultureInfo.InvariantCulture);

        Console.WriteLine(date.DayOfWeek);
    }
}

