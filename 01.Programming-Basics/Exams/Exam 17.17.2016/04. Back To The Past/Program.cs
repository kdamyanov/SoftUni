using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine()); //Наследените пари
            var year = double.Parse(Console.ReadLine()); //Годината, до която трябва да живее

            var countYear = 18;

            for (int i = 1800; i <= year; i++)
            {
                if (i % 2 == 0)
                {
                    money = money - 12000;
                    countYear++;
                }
                else
                {
                    money = money - (12000+(countYear*50));
                    countYear++;
                }
            }

            if (money>=0)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:F2} dollars left.",money);
            }
            else
            {
                Console.WriteLine("He will need {0:F2} dollars to survive.",Math.Abs( money));
            }
        }
    }
}
