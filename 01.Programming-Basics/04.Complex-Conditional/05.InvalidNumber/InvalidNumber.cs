using System;

class InvalidNumber
{
    static void Main()
    {
        var number = int.Parse(Console.ReadLine());

        var inRange = (number >= 100 && number <= 200 || number == 0);

        if (!inRange)
        {
            Console.WriteLine("invalid");
        }
    }
}

