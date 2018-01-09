using System;

class Program
{
    static void Main()
    {
        var firstValue = int.Parse(Console.ReadLine());
        var secondValue = int.Parse(Console.ReadLine());
        var thirdValue = int.Parse(Console.ReadLine());

        if (firstValue==secondValue && secondValue==thirdValue)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}

