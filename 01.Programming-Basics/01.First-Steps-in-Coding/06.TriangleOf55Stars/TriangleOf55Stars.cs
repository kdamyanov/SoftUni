using System;

class TriangleOf55Stars
{
    static void Main()
    {
        int n = 10;
        for (int i = 0; i <= n; i++)
        {
            string asterisks = new string('*', i);
            string spaces = new string(' ', n - i);
            Console.Write(asterisks);
            Console.WriteLine(spaces);
        }
    }
}