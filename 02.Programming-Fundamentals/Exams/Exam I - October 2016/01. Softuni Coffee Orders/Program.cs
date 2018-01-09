using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Softuni_Coffee_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            decimal totalPrice = 0;

            for (int i = 0; i < num; i++)
            {
                decimal price = decimal.Parse(Console.ReadLine());
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy",CultureInfo.InvariantCulture);
                long count = long.Parse(Console.ReadLine());

                decimal currentPrice = DateTime.DaysInMonth(date.Year, date.Month)*count*price;
                totalPrice += currentPrice;
                Console.WriteLine($"The price for the coffee is: ${currentPrice:F2}");
            }
            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}
