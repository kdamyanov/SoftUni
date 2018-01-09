using System;

class GreaterNumber
{
    static void Main()
    {
        var number1 = int.Parse(Console.ReadLine());
        var number2 = int.Parse(Console.ReadLine());

        if (number1 > number2)
        {
            Console.WriteLine(number1);
        }
        else
        {
            Console.WriteLine(number2);
        }
    }
}

