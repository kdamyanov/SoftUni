using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,long> resources = new Dictionary<string, long>();

            string resourceType = Console.ReadLine();

            while (!resourceType.Equals("stop"))
            {
                long resourceQuantity = long.Parse(Console.ReadLine());

                if (!resources.ContainsKey(resourceType))
                {
                    resources.Add(resourceType,0);
                }

                resources[resourceType] += resourceQuantity;

                resourceType = Console.ReadLine();
            }
            foreach (var print in resources)
            {
                Console.WriteLine($"{print.Key} -> {print.Value}");
            }
        }
    }
}
