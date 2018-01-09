using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Take_Single_Element_from_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6 };
            int num = nums.First(x => x % 2 == 0);
            // num = 2

            int[] nums = { 1, 2, 3, 4, 5, 6 };
            int num = nums.Last(x => x % 2 == 1);
            // num = 5

            int[] nums = { 1, 2, 3, 4, 5, 6 };
            int num = nums.Single(x => x == 4);
            // num = 4
        }
    }
}
