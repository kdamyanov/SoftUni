using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _03.Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWorks = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string text = Console.ReadLine();

            foreach (var bannedWork in bannedWorks)
            {
                if (text.Contains(bannedWork))
                {
                    text = text.Replace(bannedWork, new string('*',bannedWork.Length));
                }
            }
            Console.WriteLine(text);
        }
    }
}
