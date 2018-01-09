using System;

class TriangleArea
{
    static void Main()
    {
        var a = double.Parse(Console.ReadLine());
        var h = double.Parse(Console.ReadLine());

        //var area = (a * h) / 2;
        //Console.WriteLine(Math.Round(area,2));
        //Console.WriteLine("{0:f2}", area);
        Console.WriteLine(Math.Round((a*h/2),2));
    } 
}

