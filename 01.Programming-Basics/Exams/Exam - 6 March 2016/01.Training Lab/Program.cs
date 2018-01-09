using System;

class Program
{
    static void Main()
    {
        var widthCm = double.Parse(Console.ReadLine()) * 100;
        var heightCm = double.Parse(Console.ReadLine()) * 100 - 100;

        var deskWidthCm = 120;
        var deskHeightCm = 70;

        var desksPerRow = (int)(heightCm / deskHeightCm);
        var desksPerColomn = (int)(widthCm / deskWidthCm);

        var totalDesks = desksPerRow * desksPerColomn - 3;

        Console.WriteLine(totalDesks);
    }
}

