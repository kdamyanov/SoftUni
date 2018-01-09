using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Take_Skip_N_Elements_from_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using Take(), Skip():

            int[] nums = { 1, 2, 3, 4, 5, 6 };
            nums = nums
                    .Take(3)
                    .ToArray();
            // nums = [1, 2, 3]


            int[] nums2 = { 1, 2, 3, 4, 5, 6 };
            nums2 = nums2
                    .Skip(3)
                    .ToArray();
            // nums = [4, 5, 6]
        }
    }
}
