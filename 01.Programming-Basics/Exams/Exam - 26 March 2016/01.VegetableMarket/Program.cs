using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceVegetables = double.Parse(Console.ReadLine());
            var priceFruits = double.Parse(Console.ReadLine());
            var priceVegetablesKg = double.Parse(Console.ReadLine());
            var priceFruitsKg = double.Parse(Console.ReadLine());

            var priceVegetablesTotal = priceVegetables * priceVegetablesKg;
            var priceFruitsTotal = priceFruits * priceFruitsKg;

            var totalPrice = priceVegetablesTotal + priceFruitsTotal;

            Console.WriteLine(totalPrice/1.94);
        }
    }
}
