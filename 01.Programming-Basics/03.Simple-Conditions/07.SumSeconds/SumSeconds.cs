using System;

class SumSeconds
{
    static void Main()
    {
        var sec1 = int.Parse(Console.ReadLine());
        var sec2 = int.Parse(Console.ReadLine());
        var sec3 = int.Parse(Console.ReadLine());

        var sum = sec1 + sec2 + sec3;
        var minutes = sum / 60;
        var seconds = sum % 60;

        Console.WriteLine("{0}:{1:D2}",minutes, seconds);
    }
}

