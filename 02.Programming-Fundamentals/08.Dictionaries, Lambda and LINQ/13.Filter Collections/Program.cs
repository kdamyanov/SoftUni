using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Filter_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 11, 99, 33, 55, 77, 44, 66, 22, 88 };
            nums.OrderBy(x => x).Take(3);
            // 11 22 33
            nums.Where(x => x < 50);
            // 11 33 44 22
            nums.Count(x => x % 2 == 1);
            // 5
            nums.Select(x => x * 2).Take(5);
            // 22 198 66 110 154

            int[] nums2 = { 1, 2, 2, 3, 4, 5, 6, -2, 2, 0, 15, 3, 1, 0, 6 };
            nums2 = nums2
                .Distinct()
                .ToArray();
            // nums = [1, 2, 3, 4, 5, 6, -2, 0, 15]
        }
    }
}
