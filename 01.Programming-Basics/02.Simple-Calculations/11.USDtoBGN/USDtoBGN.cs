using System;

class USDtoBGN
{
    static void Main()
    {
        var usd = decimal.Parse(Console.ReadLine());

        var bgn = usd * 1.79549m;

        Console.WriteLine("{0:f2}", bgn);
    }
}

