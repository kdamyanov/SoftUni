using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var projection = Console.ReadLine();
            var rows = int.Parse(Console.ReadLine());
            var columms = int.Parse(Console.ReadLine());

            var price = 0.0;
            if (projection== "Premiere")
            {
                price = 12.0;
            }
            else if (projection == "Normal")
            {
                price = 7.5;
            }
            else if (projection == "Discount")
            {
                price = 5.0;
            }

            Console.WriteLine("{0:F2} leva", columms*rows*price);
        }
    }
}
