using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            var distance = int.Parse(Console.ReadLine());
            var time = Console.ReadLine();

            var priceTaxi = 0.7;
            var priceAutobus = 0.09;
            var priceTrain = 0.06;

            if (distance < 20)
            {
                if (time == "day")
                {
                    Console.WriteLine(priceTaxi += distance * 0.79);
                }
                else
                {
                    Console.WriteLine(priceTaxi += distance * 0.90);
                }
            }

            else if (distance <100) 
            {
                Console.WriteLine(priceAutobus *= distance);
            }
            else if (distance>=100)
            {
                Console.WriteLine(priceTrain *= distance); 
            }
        }
    }
}
