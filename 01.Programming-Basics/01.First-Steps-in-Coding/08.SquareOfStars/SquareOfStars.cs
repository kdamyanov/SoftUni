using System;

class SquareOfStars
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string star = new string('*', n);

        Console.WriteLine(star);
        for (int i = 1; i < n - 1; i++)
            {
            Console.WriteLine("*" + new string(' ', n - 2) + "*");
            }
        Console.WriteLine(star);
    }
}


