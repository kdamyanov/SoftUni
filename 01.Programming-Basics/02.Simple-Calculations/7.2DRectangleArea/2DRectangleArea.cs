﻿using System;

class RectangleArea
{
    static void Main()
    {
        var x1 = double.Parse(Console.ReadLine());
        var y1 = double.Parse(Console.ReadLine());
        var x2 = double.Parse(Console.ReadLine());
        var y2 = double.Parse(Console.ReadLine());

        double width = Math.Max(x1, x2) - Math.Min(x1, x2);
        double height = Math.Max(y1, y2) - Math.Min(y1, y2);

        Console.WriteLine("Area = {0}", width * height);
        Console.WriteLine("Perimeter = {0}", 2 * (width + height));
    }
}

