using System;

class CurrencyConverter
{
    static void Main()
    {


        decimal moneyToString = decimal.Parse(Console.ReadLine());
        string firstcurrency = Console.ReadLine();
        string secondcurrency = Console.ReadLine();
        decimal firstRate = 0.0m;
        decimal secondRate = 0.0m;

        decimal BGN = 1m;
        decimal USD = 1.79549m;
        decimal EUR = 1.95583m;
        decimal GBP = 2.53405m;


        if (firstcurrency == "BGN")
        {
            firstRate = BGN;
        }
        else if (firstcurrency == "USD")
        {
            firstRate = USD;
        }
        else if (firstcurrency == "EUR")
        {
            firstRate = EUR;
        }
        else if (firstcurrency == "GBP")
        {
            firstRate = GBP;
        }
        if (secondcurrency == "BGN")
        {
            secondRate = BGN;
        }
        else if (secondcurrency == "USD")
        {
            secondRate = USD;
        }
        else if (secondcurrency == "EUR")
        {
            secondRate = EUR;
        }
        else if (secondcurrency == "GBP")
        {
            secondRate = GBP;
        }
        decimal result = moneyToString * (firstRate / secondRate);

        Console.WriteLine("{0} {1}", Math.Round(result, 2), secondcurrency);
    }
}