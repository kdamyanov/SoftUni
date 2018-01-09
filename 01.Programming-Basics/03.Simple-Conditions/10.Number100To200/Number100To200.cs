using System;

class Number100To200
{
    static void Main()
    {
        var value = int.Parse(Console.ReadLine());

        if (value < 100)
        {
            Console.WriteLine("Less than 100");
        }
        else if (value <= 200)
        {
            Console.WriteLine("Between 100 and 200");
        }
        else if (value > 200)
        {
            Console.WriteLine("Greater than 200");
        }
    }
}

