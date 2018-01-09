using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Other_Operations_over_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6 };
            nums = nums.Reverse();
            // nums = 6, 5, 4, 3, 2, 1

            int[] nums = { 1, 2, 3, 4, 5, 6 };
            int[] otherNums = { 7, 8, 9, 0 };
            nums = nums.Concat(otherNums);
            // nums = 1, 2, 3, 4, 5, 6, 7, 8, 9, 0

        }
    }
}
