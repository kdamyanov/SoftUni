using System;

class CelsiusToFahrenheit
{
    static void Main()
    {
        var Celsius = double.Parse(Console.ReadLine());

        var Fahrenheit = Celsius * 1.8 + 32;

        Console.WriteLine(Math.Round(Fahrenheit,2));
    }
}

