using System;

class EqualWords
{
    static void Main()
    {
        string wordFirst = (Console.ReadLine().ToLower()); 
        string wordSecond = (Console.ReadLine().ToLower());

        if (wordFirst==wordSecond)
        {
            Console.WriteLine("yes");
        }
        else if (wordFirst != wordSecond)
        {
            Console.WriteLine("no");
        }
    }
}

