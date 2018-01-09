using System;

namespace Variable_in_Hex_Format
{
    public class VariableInHexFormat
    {
        public static void Main()
        {
            string variableInHex = Console.ReadLine();
            int number = Convert.ToInt32(variableInHex, 16);

            Console.WriteLine(number);
        }
    }
}
