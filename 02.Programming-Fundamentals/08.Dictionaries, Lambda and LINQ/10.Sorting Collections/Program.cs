using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Sorting_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using OrderBy() to sort collections:

            List<int> nums = { 1, 5, 2, 4, 3 };

            nums = nums.OrderBy(num => num)
                       .ToList();

            //Using OrderByDescending() to sort collections:

            List<int> numsTwo = { 1, 5, 2, 4, 3 };

            numsTwo = numsTwo.OrderByDescending(num => num)
                       .ToList();

        }
    }
}
