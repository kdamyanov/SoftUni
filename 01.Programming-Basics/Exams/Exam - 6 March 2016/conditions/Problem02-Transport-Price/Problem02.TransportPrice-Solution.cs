using System;

class TransportPrice
{
    static void Main()
    {
        var distance = int.Parse(Console.ReadLine());
        var time = Console.ReadLine();

        var priceTaxi = 0.7;
        var priceAutobus = 0.09;
        var priceTrain = 0.06;

        if (time == "day")
        {
            if (distance < 20)
            {
                priceTaxi = distance * 0.79;
            }
        }
        else
        {
            priceTaxi = distance * 0.90;
        }
        Console.WriteLine(priceTaxi);
    }   
}
