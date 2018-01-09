using System;
public class myclass
{
    public static void Main(string[] args)
    {
        var hour = int.Parse(Console.ReadLine());
        var min = int.Parse(Console.ReadLine());

        var sum = ((hour * 60) + min + 15);
        var resultHour = sum / 60;

        if (resultHour >= 24)
        {
            resultHour -= 24;
        }
        var resultMin = sum % 60;
        Console.WriteLine("{0}:{1:00}", resultHour,resultMin);
    }
}