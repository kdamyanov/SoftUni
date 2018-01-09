using System;

class AreaOfFigures
{
    static void Main()
    {
        var figures = (Console.ReadLine());

        if (figures == "square")
        {
            var square = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F3}", square * square);
        }
        else if (figures == "rectangle")
        {
            var rectangleFirstSide = double.Parse(Console.ReadLine());
            var rectangleSecondSide = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F3}", rectangleFirstSide * rectangleSecondSide);
        }
        else if (figures == "circle")
        {
            var radius = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F3}", Math.PI * (radius * radius));
        }
        else if (figures == "triangle")
        {
            var triangleFirstSide = double.Parse(Console.ReadLine());
            var triangleSecondSide = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F3}", triangleFirstSide * triangleSecondSide / 2);
        }
        else
        {
            Console.WriteLine("Please type : square, rectangle, circle or triangle");
        }
    }
}

