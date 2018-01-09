using System;

class MetricConverter
{
    static void Main()
    {
        var number = double.Parse(Console.ReadLine());
        string fromUnit = Console.ReadLine();
        string toUnit = Console.ReadLine();

        double factor = 0.0;

        if (fromUnit == "m")
        {
            factor = 1;
        }
        else if (fromUnit == "mm")
        {
            factor = 1/1000.0;
        }
        else if (fromUnit == "cm")
        {
            factor = 1/100.0;
        }
        else if (fromUnit=="mi")
        {
            factor = 1 / 0.000621371192;
        }
        else if (fromUnit == "in")
        {
            factor = 1 / 39.3700787;
        }
        else if (fromUnit == "km")
        {
            factor = 1 / 0.001;
        }
        else if (fromUnit == "ft")
        {
            factor = 1 / 3.2808399;
        }
        else if (fromUnit == "yd")
        {
            factor = 1 / 1.0936133;
        }

        var valueInMeters = number * factor;

        if (toUnit == "m")
        {
            factor = 1;
        }
        else if (toUnit == "mm") 
        {
            factor = 1000;
        }
        else if (toUnit == "cm") 
        {
            factor = 100;
        }
        else if (toUnit == "mi")
        {
            factor =  0.000621371192;
        }
        else if (toUnit == "in")
        {
            factor =  39.3700787;
        }
        else if (toUnit == "km")
        {
            factor =  0.001;
        }
        else if (toUnit == "ft")
        {
            factor =  3.2808399;
        }
        else if (toUnit == "yd")
        {
            factor =  1.0936133;
        }

        Console.WriteLine("{0} {1}", valueInMeters * factor,toUnit);
    }
}

