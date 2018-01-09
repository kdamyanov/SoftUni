using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString_1
{
    class ReverseString_1
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string reverseText = new string(text.Reverse().ToArray());
            Console.WriteLine(reverseText);
        }
    }
}