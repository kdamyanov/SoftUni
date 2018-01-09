using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Reverse_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read
            
            int n = int.Parse(Console.ReadLine());

            int [] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            //Print

            for (int i = n-1; i>=0; i--)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();


        }

    }
}
