using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Sorting_Collections2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using ThenBy() to sort collections by more than 1 criteria:

            Dictionary<int, string> products = new Dictionary<int, string>();
            Dictionary<int, string> sortedDict = products.OrderBy(pair => pair.Value)
                                                         .ThenBy(pair => pair.Key)
                                                         .ToDictionary(pair => pair.Key,pair => pair.Value);

          

            foreach (var item in sortedDict)
            {
                Console.WriteLine(item);
            }

            

            //Similar to OrderByDescending(),there is also ThenByDescending()
        }
    }
}
