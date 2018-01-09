using System;
class TrapeziodArea
{
    static void Main()
    {
        var sideA = double.Parse(Console.ReadLine());
        var sideB = double.Parse(Console.ReadLine());
        var h = double.Parse(Console.ReadLine());

        var area = (sideA + sideB) * h / 2;
        Console.WriteLine(area);
    }
}

