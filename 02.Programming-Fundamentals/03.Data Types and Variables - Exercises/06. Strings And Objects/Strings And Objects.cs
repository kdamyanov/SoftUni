using System;

namespace StringsAndObjects
{
    public class StringsAndObjects
    {
        public static void Main()
        {
            string variables1 = Console.ReadLine();
            string variables2 = Console.ReadLine();
            object variable3 = variables1 + " " + variables2;

            string variables4 = (string)variable3;

            Console.WriteLine(variables4);

        }
    }
}
