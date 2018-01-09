    using System;

    class SmallShop
    {
        static void Main()
        {
            var product = Console.ReadLine().ToLower();
            var city = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());

            if (city == "sofia")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(0.5*quantity);
                }
                else if (product == "water")
                {
                    Console.WriteLine(0.8 * quantity);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(1.2 * quantity);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(1.45*quantity);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(1.6 * quantity);
                }
            }
            else if (city == "plovdiv")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(0.4 * quantity);
                }
                else if (product == "water")
                {
                    Console.WriteLine(0.7 * quantity);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(1.15 * quantity);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(1.3 * quantity);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(1.5 * quantity);
                }
            }
            else if (city == "varna")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(0.45 * quantity);
                }
                else if (product == "water")
                {
                    Console.WriteLine(0.7 * quantity);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(1.10 * quantity);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(1.35 * quantity);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(1.55 * quantity);
                }
            }
        }
    }

