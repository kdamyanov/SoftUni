﻿using System;

namespace BooleanVariable
{
    public class BooleanVariable
    {
        public static void Main()
        {
            string booleanInput = Console.ReadLine();
            bool isTrue = Convert.ToBoolean(booleanInput);

            Console.WriteLine(isTrue ? "Yes" : "No");
        }
    }
}
