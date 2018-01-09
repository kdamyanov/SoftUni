using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SmartLilly
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = int.Parse(Console.ReadLine());
            var priceMachine = double.Parse(Console.ReadLine());
            var presentPrice = int.Parse(Console.ReadLine());

            
            var moneyTotal = 0;
            var bonus = 10;
            var moneyFromPresents = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0) 
                {
                    moneyTotal += bonus;
                    bonus += 10;
                    moneyTotal -= 1;
                }
                else
                {
                    moneyFromPresents += presentPrice;
                }
            }
            var allMoney = moneyTotal + moneyFromPresents;

            if (allMoney>= priceMachine)
            {
                Console.WriteLine("Yes! {0:F2}",allMoney-priceMachine);
            }
            else
            {
                Console.WriteLine("No! {0:F2}",  priceMachine-allMoney);
            }
          

        }
    }
}
