using System;

class PriceChangeAlert
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double priceTreshold = double.Parse(Console.ReadLine());
        double firstPrice = double.Parse(Console.ReadLine());
        double lastPrice = firstPrice;

        for (int i = 0; i < n - 1; i++)
        {
            double currentPrice = double.Parse(Console.ReadLine());
            double difference = GetPercentageDifference(lastPrice, currentPrice);
            bool isSignificantDifference = IsSignificantDifference(difference, priceTreshold);           
            string message = GetMessage(currentPrice, lastPrice, difference, isSignificantDifference);
            Console.WriteLine(message);
            lastPrice = currentPrice;
        }
    }

    private static string GetMessage(double currentPrice, double lastPrice, double difference , bool isSignificantDifference)
    {
        string result = "";
        if (difference  == 0)
        {
            result = string.Format("NO CHANGE: {0}", currentPrice);
        }
        else if (!isSignificantDifference)
        {
            result = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference *100);
        }
        else if (isSignificantDifference && (difference  > 0))
        {
            result = string.Format("PRICE UP: {0} to {1} ({2:F}%)", lastPrice, currentPrice, difference * 100);
        }
        else if (isSignificantDifference && (difference  < 0))
        {
            result = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
        }            
        return result;
    }
    private static bool IsSignificantDifference(double defference, double priceTreshold)
    {
        if (Math.Abs(defference) >= priceTreshold)            
        {
            return true;
        }
        return false;
    }

    private static double GetPercentageDifference(double lastPrice, double currentPrice)
    {
        double result = ((currentPrice - lastPrice) / lastPrice);
        return result;
    }
}
