using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterOfTwoValues
{
    class GreaterOfTwoValues
    {
        static void Main()
        {
            var type = Console.ReadLine();
            if (type == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                GetMax(first,second);
            }
            else if (type == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                GetMax(first, second);
            }
            else if (type == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                GetMax(first, second);
            }

        }

        static void GetMax(int first, int second)
        {
            if (first >=second)
            {
                Console.WriteLine(first);
            }
            else if (first < second)
            {
                Console.WriteLine(second);
            }
        }

        static void GetMax(string first, string second)
        {
            if (first.CompareTo(second) >= 0) 
            {
                Console.WriteLine(first);
            }
            else if (first.CompareTo(second) < 0)
            {
                Console.WriteLine(second);
            }
        }

        static void GetMax(char first, char second)
        {
            if (first >= second)
            {
                Console.WriteLine(first);
            }
            else if (first < second)
            {
                Console.WriteLine(second);
            }
        }
    }
}
